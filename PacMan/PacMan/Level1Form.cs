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
//need media for SoundPlayer
using System.Media;

namespace PacMan
{
    public partial class frmLevel1 : Form
    {
        List<PictureBox> listOfCoins = new List<PictureBox>();
        List<PictureBox> listAllOtherObjects = new List<PictureBox>();

        Random rndNumGen = new Random();

        //create the sound player
        private SoundPlayer BackgroundMusic;

        //delcare and initialize variables
        bool goUp = false, goDown = false, goLeft = false,
            goRight = false, playerControllsEnabled = true, pacmanChar,
            gameOver;

        Image characterUp, characterRight, characterDown, characterLeft;

        const int speed = 8;

        //ghost 1 and 2 variables 
        int ghost1 = 8;
        int ghost2 = 8;

        //ghost3 variables
        int ghost3x = 8;
        int ghost3y = 8;

        //score variable
        int score = 0;

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

        private void frmLevel1_KeyPress(object sender, KeyPressEventArgs e)
        {
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

                //if the left arrow key is pressed:
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    Console.WriteLine("***Keys." + e.KeyCode + " is pressed");
                    //set goLeft = true
                    goLeft = true;
                    //change the image to the pacman moving left
                    picPacman.Image = characterLeft;
                }

                //if the right arrow key is pressed:
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    Console.WriteLine("***Keys." + e.KeyCode + " is pressed");
                    goRight = true;
                    picPacman.Image = characterRight;
                }

                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                {
                    Console.WriteLine("***Keys." + e.KeyCode + " is pressed");
                    goUp = true;
                    picPacman.Image = characterUp;
                }

                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                {
                    Console.WriteLine("***Keys." + e.KeyCode + " is pressed");
                    goDown = true;
                    picPacman.Image = characterDown;
                }
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                goDown = false;
            }
        }

        private void picMute_Click(object sender, EventArgs e)
        {
            BackgroundMusic.Stop();
            picMute.Hide();
            picUnmute.Show();
        }

        private void picUnmute_Click(object sender, EventArgs e)
        {
            BackgroundMusic.Play();
            picUnmute.Hide();
            picMute.Show();
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine("***timer1_Tick called");
            //show the score on the board
            lblScore.Text = "Score: " + score;

            //player movement code start
            if (goLeft)
            {
                //move the player to the left
                picPacman.Left -= speed;
            }

            if (goRight)
            {
                picPacman.Left += speed;
            }

            if (goUp)
            {
                picPacman.Top -= speed;
            }

            if (goDown)
            {
                picPacman.Top += speed;
            }
            //player movements code end

            //moving the ghosts and bumping with the walls
            picUgandanKnuckles1.Left += ghost1;
            picWaluigi.Left += ghost2;

            //if the red ghost hits the wall then reverse speed
            if (picUgandanKnuckles1.Bounds.IntersectsWith(picWall1.Bounds))
            {
                ghost1 = -ghost1;
            }
            //if the red ghost hits the wall then reverse speed
            if (picUgandanKnuckles1.Bounds.IntersectsWith(picWall2.Bounds))
            {
                ghost1 = -ghost1;
            }
            if (picUgandanKnuckles1.Bounds.IntersectsWith(picWall3.Bounds))
            {
                ghost1 = -ghost1;
            }
            if (picUgandanKnuckles1.Bounds.IntersectsWith(picWall4.Bounds))
            {
                ghost1 = -ghost1;
            }
            //if the yellow ghost hits the wall then reverse speed
            if (picWaluigi.Bounds.IntersectsWith(picWall1.Bounds))
            {
                ghost2 = -ghost2;
            }
            if (picWaluigi.Bounds.IntersectsWith(picWall2.Bounds))
            {
                ghost2 = -ghost2;
            }
            //if the yellow ghost hits the wall then reverse speed
            if (picWaluigi.Bounds.IntersectsWith(picWall3.Bounds))
            {
                ghost2 = -ghost2;
            }
            if (picWaluigi.Bounds.IntersectsWith(picWall4.Bounds))
            {
                ghost2 = -ghost2;
            }

            //for loop to check walls ghosts and points
            foreach (Control atag in this.Controls)
            {
                if (atag is PictureBox && atag.Tag == "ghost")
                {
                    //checking if the player hits the wall or the ghost, them game over
                    if (((PictureBox)atag).Bounds.IntersectsWith(picPacman.Bounds))
                    {
                        int indexToRemove;

                        lblTransition.Show();
                        picPacman.Left = 0;
                        picPacman.Top = 25;
                        lblGameOver.Text = "GAME OVER";
                        lblGameOver.Show();
                        tmrTimer.Stop();
                        picPacman.Hide();
                        picMute.Hide();
                        picUnmute.Hide();
                        BackgroundMusic.Stop();
                       
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
                    //checking to see if the player hits the picturebox then add score
                    if (((PictureBox)atag).Bounds.IntersectsWith(picPacman.Bounds))
                    {
                        //remove the point
                        this.Controls.Remove(atag);
                        //add to the score
                        score++;
                        Console.WriteLine("***Score is " + score);
                        Console.WriteLine(atag.Name);
                        listOfCoins.Remove((PictureBox)atag);
                        Console.WriteLine("***listOfCoins.Count is " + listOfCoins.Count());

                    }
                    if (score == 30)
                    {
                        Console.WriteLine(lblScore.Text);
                        picPacman.Left = 0;
                        picPacman.Top = 25;
                        Console.WriteLine("PAC-MAN location: " + picPacman.Location);
                        lblGameOver.Text = ("YOU WIN!");
                        lblGameOver.Show();
                        tmrTimer.Stop();
                        picPacman.Hide();
                        picMute.Hide();
                        picUnmute.Hide();
                        BackgroundMusic.Stop();
                        Thread.Sleep(2000);
                        gameOver = true;
                    }
                }
                if (atag is PictureBox && atag.Tag == "noMansLandTop")
                {
                    if (((PictureBox)atag).Bounds.IntersectsWith(picPacman.Bounds))
                    {
                        picPacman.Top += speed;
                    }
                }
                if (atag is PictureBox && atag.Tag == "noMansLandRight")
                {
                    if (((PictureBox)atag).Bounds.IntersectsWith(picPacman.Bounds))
                    {
                        picPacman.Left -= speed;
                    }
                }
                if (atag is PictureBox && atag.Tag == "noMansLandBottom")
                {
                    if (((PictureBox)atag).Bounds.IntersectsWith(picPacman.Bounds))
                    {
                        picPacman.Top -= speed;
                    }
                }
                if (atag is PictureBox && atag.Tag == "noMansLandLeft")
                {
                    if (((PictureBox)atag).Bounds.IntersectsWith(picPacman.Bounds))
                    {
                        picPacman.Left += speed;
                    }
                }
                if (atag is PictureBox && atag.Tag == "wallLeft")
                {
                    if (((PictureBox)atag).Bounds.IntersectsWith(picPacman.Bounds))
                    {
                        picPacman.Left -= speed;
                    }
                }
                if (atag is PictureBox && atag.Tag == "wallTop")
                {
                    if (((PictureBox)atag).Bounds.IntersectsWith(picPacman.Bounds))
                    {
                        picPacman.Top -= speed;
                    }
                }
                if (atag is PictureBox && atag.Tag == "wallRight")
                {
                    if (((PictureBox)atag).Bounds.IntersectsWith(picPacman.Bounds))
                    {
                        picPacman.Left += speed;
                    }
                }
                if (atag is PictureBox && atag.Tag == "wallBottom")
                {
                    if (((PictureBox)atag).Bounds.IntersectsWith(picPacman.Bounds))
                    {
                        picPacman.Top += speed;
                    }
                }
            }//end the for loop for checking walls, points and ghosts

            //ghost 3 going crazy here
            //picUgandanKnuckles2.Left += ghost3x;
            picUgandanKnuckles2.Top += ghost3y;

            if (picUgandanKnuckles2.Left < 1 ||
                picUgandanKnuckles2.Left + picUgandanKnuckles2.Width > ClientSize.Width - 2 ||
                (picUgandanKnuckles2.Bounds.IntersectsWith(picWall1.Bounds)) ||
                (picUgandanKnuckles2.Bounds.IntersectsWith(picWall2.Bounds)) ||
                (picUgandanKnuckles2.Bounds.IntersectsWith(picWall3.Bounds)) ||
                (picUgandanKnuckles2.Bounds.IntersectsWith(picWall4.Bounds))
                )
            {
                ghost3x = -ghost3x;
            }
            if (picUgandanKnuckles2.Top < 1 || picUgandanKnuckles2.Top + picUgandanKnuckles2.Height > ClientSize.Height - 2)
            {
                ghost3y = -ghost3y;
            }
            //end crazy ghost movements
        }


        private void PacManForm_Load(object sender, EventArgs e)
        {
            BackgroundMusic.Play();
            PopulateList();
            PopulateAllOtherObjects();
            lblTransition.Hide();
            lblGameOver.Text = ("");
            if (pacmanChar == true)
            {
                picPacman.Image = characterRight;
            }
            else
            {
                picPacman.Image = characterDown;
            }
            gameOver = false;
        }

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