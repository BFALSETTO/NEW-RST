using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//need threading for Thread.Sleep for splash screen
using System.Threading;
//need System.Media for SoundPlayer
using System.Media;

namespace PacMan
{
    public partial class frmLevel1 : Form
    {
        //declare lists
        List<PictureBox> listOfCoins = new List<PictureBox>();
        List<PictureBox> listAllOtherObjects = new List<PictureBox>();

        //random number generator used for when the player loses
        Random rndNumGen = new Random();

        //declare the sound player
        SoundPlayer BackgroundMusic;

        //delcare and initialize variables
        bool goUp = false, goDown = false, goLeft = false,
            goRight = false, playerControllsEnabled = true, pacmanChar,
            gameOver;

        //type Image used for receiving different states of character chosen in previous form
        Image characterUp, characterRight, characterDown, characterLeft;

        const int SPEED = 8;

        //enemy 1 and 2 speed variables 
        int enemy1 = 8;
        int enemy2 = 8;

        //enemy3 variables
        int enemy3x = 8;
        int enemy3y = 8;

        //score variable
        int score = 0;

        //on formload, get the direction that the character will be facing (true = right, false = down),
        //  and all the images required to move the character in the different directions
        public frmLevel1(bool pacman, Image tmpCharacterUp, Image tmpCharacterRight, Image tmpCharacterDown, Image tmpCharacterLeft)
        {
            InitializeComponent();

            //load sounds and make certain objects invisible
            lblGameOver.Visible = false;
            BackgroundMusic = new SoundPlayer("Background Theme.wav");
            Console.WriteLine("***Sound Loaded");
            picUnmute.Hide();
            characterUp = tmpCharacterUp;
            characterRight = tmpCharacterRight;
            characterDown = tmpCharacterDown;
            characterLeft = tmpCharacterLeft;
            pacmanChar = pacman;

        }

        private void picUgandanKnuckles1_Click(object sender, EventArgs e)
        {

        }

        private void frmLevel1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if the user lost, the user will be able to return to the main menu
            //  by pressing any key
            if (gameOver == true)
            {
                Form frmMenu = new frmMenu();
                this.Hide();
                frmMenu.ShowDialog();
                this.Close();
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (playerControllsEnabled == true)
            {
                Console.WriteLine("***keyisdown called");

                //if the left arrow key || A key is pressed:
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    Console.WriteLine("***Keys." + e.KeyCode + " is pressed");
                    //move the character to the right
                    goLeft = true;
                    //change the image to the character moving left
                    picUserCharacter.Image = characterLeft;
                }

                //if the right arrow key || D key is pressed:
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    Console.WriteLine("***Keys." + e.KeyCode + " is pressed");
                    //move the character to the right
                    goRight = true;
                    //change the image to the character moving right
                    picUserCharacter.Image = characterRight;
                }

                //if the up arrow key || W key is pressed:
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                {
                    Console.WriteLine("***Keys." + e.KeyCode + " is pressed");
                    //move the character up
                    goUp = true;
                    //change the image to the character moving up
                    picUserCharacter.Image = characterUp;
                }

                //if the down arrow key || S key is pressed:
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                {
                    Console.WriteLine("***Keys." + e.KeyCode + " is pressed");
                    //move the character down
                    goDown = true;
                    //change the image to the character moving down
                    picUserCharacter.Image = characterDown;
                }
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            //if the left arrow key || A key is released:
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                //stop the character from moving to the left
                goLeft = false;
            }

            //if the right arrow key || D key is released:
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                //stop the character from moving to the right
                goRight = false;
            }

            //if the up arrow key || W key is released:
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                //stop the character from moving up
                goUp = false;
            }

            //if the down arrow key || S key is released:
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                //stop the character from moving down
                goDown = false;
            }
        }

        //when the mute button is clicked, stop the background music,
        //  hide picMute and show picUnmute
        private void picMute_Click(object sender, EventArgs e)
        {
            BackgroundMusic.Stop();
            picMute.Hide();
            picUnmute.Show();
        }

        //when unmute button is clicked, play the background music,
        //  hide picUnmute and show picMute
        private void picUnmute_Click(object sender, EventArgs e)
        {
            BackgroundMusic.Play();
            picUnmute.Hide();
            picMute.Show();
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            //show the score on the board
            lblScore.Text = "Score: " + score;

            //playerCharacter movement code start
            if (goLeft)
            {
                //move the character to the left
                picUserCharacter.Left -= SPEED;
            }

            if (goRight)
            {
                //move the character to the right
                picUserCharacter.Left += SPEED;
            }

            if (goUp)
            {
                //move the character up
                picUserCharacter.Top -= SPEED;
            }

            if (goDown)
            {
                //move the character down
                picUserCharacter.Top += SPEED;
            }
            //player movements code end

            //moving enemies 1 and 2
            picUgandanKnuckles1.Left += enemy1;
            picWaluigi.Left += enemy2;

            //if the picUgandanKnuckles hits the wall then move in the opposite direction
            if (picUgandanKnuckles1.Bounds.IntersectsWith(picWall1.Bounds))
            {
                enemy1 = -enemy1;
            }
            //if the picUgandanKnuckles hits the wall then move in the opposite direction
            if (picUgandanKnuckles1.Bounds.IntersectsWith(picWall2.Bounds))
            {
                enemy1 = -enemy1;
            }
            //if the picUgandanKnuckles hits the wall then move in the opposite direction
            if (picUgandanKnuckles1.Bounds.IntersectsWith(picWall3.Bounds))
            {
                enemy1 = -enemy1;
            }
            //if the picUgandanKnuckles hits the wall then move in the opposite direction
            if (picUgandanKnuckles1.Bounds.IntersectsWith(picWall4.Bounds))
            {
                enemy1 = -enemy1;
            }
            //if the picWaluigi hits the wall then move in the opposite direction
            if (picWaluigi.Bounds.IntersectsWith(picWall1.Bounds))
            {
                enemy2 = -enemy2;
            }
            //if the picWaluigi hits the wall then move in the opposite direction
            if (picWaluigi.Bounds.IntersectsWith(picWall2.Bounds))
            {
                enemy2 = -enemy2;
            }
            //if the picWaluigi hits the wall then move in the opposite direction
            if (picWaluigi.Bounds.IntersectsWith(picWall3.Bounds))
            {
                enemy2 = -enemy2;
            }
            //if the picWaluigi hits the wall then move in the opposite direction
            if (picWaluigi.Bounds.IntersectsWith(picWall4.Bounds))
            {
                enemy2 = -enemy2;
            }
            //if the picWaluigi hits the wall then move in the opposite direction

            //for loop to check for intersections between the player and walls, ghosts, and points
            foreach (Control atag in this.Controls)
            {
                if (atag is PictureBox && atag.Tag == "ghost")
                {
                    //checking if the player hits an enemy, them game over
                    if (((PictureBox)atag).Bounds.IntersectsWith(picUserCharacter.Bounds))
                    {
                        int indexToRemove;

                        lblTransition.Show();
                        picUserCharacter.Left = 0;
                        picUserCharacter.Top = 25;
                        lblGameOver.Text = "GAME OVER";
                        lblGameOver.Show();
                        tmrTimer.Stop();
                        picUserCharacter.Hide();
                        picMute.Hide();
                        picUnmute.Hide();
                        BackgroundMusic.Stop();
                        
                        //while loop to hide remaining coins one at a time until none remain
                        while (listOfCoins.Count() > 0)
                        {
                            string tmpPicString;
                            PictureBox tmpPicBox;
                            indexToRemove = rndNumGen.Next(0, listOfCoins.Count());
                            tmpPicBox = listOfCoins.ElementAt(indexToRemove);
                            tmpPicString = tmpPicBox.Name;
                            Console.WriteLine("Name of picture to be removed: " + tmpPicString);
                            tmpPicBox.Hide();
                            listOfCoins.RemoveAt(indexToRemove);
                            Thread.Sleep(200);
                        }
                        Thread.Sleep(200);
                        picCoin13.Hide();
                        Thread.Sleep(2000);
                        gameOver = true;
                    }
                }
                if (atag is PictureBox && atag.Tag == "coin")
                {
                    //checking to see if the player touches a coin, then add score
                    if (((PictureBox)atag).Bounds.IntersectsWith(picUserCharacter.Bounds))
                    {
                        //remove the point
                        this.Controls.Remove(atag);
                        //add to the score
                        score++;
                        Console.WriteLine("***Score is " + score);
                        Console.WriteLine(atag.Name);
                        //remove the coin from the list to prevent inconsistincies in case of game loss
                        listOfCoins.Remove((PictureBox)atag);
                        Console.WriteLine("***listOfCoins.Count is " + listOfCoins.Count());

                    }
                    //if player wins
                    if (score == 30)
                    {
                        Console.WriteLine(lblScore.Text);
                        picUserCharacter.Left = 0;
                        picUserCharacter.Top = 25;
                        Console.WriteLine("PAC-MAN location: " + picUserCharacter.Location);
                        lblGameOver.Text = ("YOU WIN!");
                        lblGameOver.Show();
                        tmrTimer.Stop();
                        picUserCharacter.Hide();
                        picMute.Hide();
                        picUnmute.Hide();
                        BackgroundMusic.Stop();
                        Thread.Sleep(2000);
                        gameOver = true;
                    }
                }
                //if the character intersects with the top game-area-border, reverse their top speed
                if (atag is PictureBox && atag.Tag == "noMansLandTop")
                {
                    if (((PictureBox)atag).Bounds.IntersectsWith(picUserCharacter.Bounds))
                    {
                        picUserCharacter.Top += SPEED;
                    }
                }
                //if the character intersects with the right game-area-border, reverse their left speed
                if (atag is PictureBox && atag.Tag == "noMansLandRight")
                {
                    if (((PictureBox)atag).Bounds.IntersectsWith(picUserCharacter.Bounds))
                    {
                        picUserCharacter.Left -= SPEED;
                    }
                }
                //if the character intersects with the bottom game-area-border, reverse their top speed
                if (atag is PictureBox && atag.Tag == "noMansLandBottom")
                {
                    if (((PictureBox)atag).Bounds.IntersectsWith(picUserCharacter.Bounds))
                    {
                        picUserCharacter.Top -= SPEED;
                    }
                }
                //if the character intersects with the left game-area-border, reverse their left speed
                if (atag is PictureBox && atag.Tag == "noMansLandLeft")
                {
                    if (((PictureBox)atag).Bounds.IntersectsWith(picUserCharacter.Bounds))
                    {
                        picUserCharacter.Left += SPEED;
                    }
                }
                //if the character intersects with the left portion of a wall, reverse their speed
                if (atag is PictureBox && atag.Tag == "wallLeft")
                {
                    if (((PictureBox)atag).Bounds.IntersectsWith(picUserCharacter.Bounds))
                    {
                        picUserCharacter.Left -= SPEED;
                    }
                }
                //if the character intersects with the top portion of a wall, reverse their speed
                if (atag is PictureBox && atag.Tag == "wallTop")
                {
                    if (((PictureBox)atag).Bounds.IntersectsWith(picUserCharacter.Bounds))
                    {
                        picUserCharacter.Top -= SPEED;
                    }
                }
                //if the character intersects with the right portion of a wall, reverse their speed
                if (atag is PictureBox && atag.Tag == "wallRight")
                {
                    if (((PictureBox)atag).Bounds.IntersectsWith(picUserCharacter.Bounds))
                    {
                        picUserCharacter.Left += SPEED;
                    }
                }
                //if the character intersects with the bottom portion of a wall, reverse their speed
                if (atag is PictureBox && atag.Tag == "wallBottom")
                {
                    if (((PictureBox)atag).Bounds.IntersectsWith(picUserCharacter.Bounds))
                    {
                        picUserCharacter.Top += SPEED;
                    }
                }
            }//end the for loop for checking walls, points and ghosts

            //ghost 3 going crazy here
            //picUgandanKnuckles2.Left += enemy3x;
            picUgandanKnuckles2.Top += enemy3y;

            //code checking for intersection with wall
            if (picUgandanKnuckles2.Left < 1 ||
                picUgandanKnuckles2.Left + picUgandanKnuckles2.Width > ClientSize.Width - 2 ||
                (picUgandanKnuckles2.Bounds.IntersectsWith(picWall1.Bounds)) ||
                (picUgandanKnuckles2.Bounds.IntersectsWith(picWall2.Bounds)) ||
                (picUgandanKnuckles2.Bounds.IntersectsWith(picWall3.Bounds)) ||
                (picUgandanKnuckles2.Bounds.IntersectsWith(picWall4.Bounds))
                )
            {
                enemy3x = -enemy3x;
            }
            if (picUgandanKnuckles2.Top < 1 || picUgandanKnuckles2.Top + picUgandanKnuckles2.Height > ClientSize.Height - 2)
            {
                enemy3y = -enemy3y;
            }
            //end crazy ghost movements
        }


        private void PacManForm_Load(object sender, EventArgs e)
        {
            //play the music and display/hide objects and populate the lists
            //  also set the character to face in the correct direction
            BackgroundMusic.Play();
            PopulateList();
            PopulateAllOtherObjects();
            lblTransition.Hide();
            lblGameOver.Text = ("");
            if (pacmanChar == true)
            {
                picUserCharacter.Image = characterRight;
            }
            else
            {
                picUserCharacter.Image = characterDown;
            }
            gameOver = false;
        }

        //add each coin on the form to the list
        public void PopulateList()
        {
            listOfCoins.Add(picCoin1);
            listOfCoins.Add(picCoin2);
            listOfCoins.Add(picCoin3);
            listOfCoins.Add(picCoin4);
            listOfCoins.Add(picCoin5);
            listOfCoins.Add(picCoin6);
            listOfCoins.Add(picCoin7);
            listOfCoins.Add(picCoin8);
            listOfCoins.Add(picCoin9);
            listOfCoins.Add(picCoin10);

            listOfCoins.Add(picCoin11);
            listOfCoins.Add(picCoin12);
            listOfCoins.Add(picCoin12);
            listOfCoins.Add(picCoin14);
            listOfCoins.Add(picCoin15);
            listOfCoins.Add(picCoin16);
            listOfCoins.Add(picCoin17);
            listOfCoins.Add(picCoin18);
            listOfCoins.Add(picCoin19);
            listOfCoins.Add(picCoin20);

            listOfCoins.Add(picCoin21);
            listOfCoins.Add(picCoin22);
            listOfCoins.Add(picCoin23);
            listOfCoins.Add(picCoin24);
            listOfCoins.Add(picCoin25);
            listOfCoins.Add(picCoin26);
            listOfCoins.Add(picCoin27);
            listOfCoins.Add(picCoin28);
            listOfCoins.Add(picCoin29);
            listOfCoins.Add(picCoin30);
        }

        //add every wall and wall object on the form to the list
        private void PopulateAllOtherObjects()
        {
            //add all the walls
            listAllOtherObjects.Add(picWall1);
            listAllOtherObjects.Add(picWall2);
            listAllOtherObjects.Add(picWall3);
            listAllOtherObjects.Add(picWall4);

            //add each wall's boundaries

            //first wall
            listAllOtherObjects.Add(picWall1Top);
            listAllOtherObjects.Add(picWall1Right);
            listAllOtherObjects.Add(picWall1Bottom);
            listAllOtherObjects.Add(picWall1Left);

            //second wall
            listAllOtherObjects.Add(picWall2Top);
            listAllOtherObjects.Add(picWall2Right);
            listAllOtherObjects.Add(picWall2Bottom);
            listAllOtherObjects.Add(picWall2Left);

            //third wall
            listAllOtherObjects.Add(picWall3Top);
            listAllOtherObjects.Add(picWall3Right);
            listAllOtherObjects.Add(picWall3Bottom);
            listAllOtherObjects.Add(picWall3Left);

            //fourth wall
            listAllOtherObjects.Add(picWall4Top);
            listAllOtherObjects.Add(picWall4Right);
            listAllOtherObjects.Add(picWall4Bottom);
            listAllOtherObjects.Add(picWall4Left);

            //add each ghost
            listAllOtherObjects.Add(picWaluigi);
            listAllOtherObjects.Add(picUgandanKnuckles1);
            listAllOtherObjects.Add(picUgandanKnuckles2);
        }
    }
}