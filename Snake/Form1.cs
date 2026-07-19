using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Snake
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        Snake mySnake;
        Board mainBoard;
        Rewards apples;

        string mode;
        Timer clock;
        Timer clock2;
        int duration;//How long the game has been running
        int speed = 500; //500ms
        int score;
        int level;
        SoundPlayer eat;


        public Form1()
        {
            InitializeComponent();
            player.URL = "snake.mp3";

            // need this to use keyboard controls
            this.KeyPreview = true;
            //You don't have to worry about the auto-size
            this.AutoSize = true;       //The size of the Form will autoadjust.
            boardPanel.AutoSize = true; //The size of the panel grouping all the squares will auto-adjust

            /*this.BackColor = Color.LightBlue;*/

            //sound
            eat = new SoundPlayer(Properties.Resources.pacman_eatfruit);
            eat.LoadAsync();

            //Set up the main board
            mainBoard = new Board(this);

            //Set up the game timer at the given speed
            clock = new Timer();
            clock2 = new Timer(); //Set the clock to tick every 500ms
            clock2.Interval = speed;
            clock.Tick += new EventHandler(refresh); //Call the refresh method at every tick to redraw the board and snake.

            duration = 0;
            score = 0;
            level = 1;
            modeLBL.Text = mode;

            userinput sp = new userinput();
            sp.ShowDialog();
            name.Text = sp.getname();
            
            gotoNextLevel(level);

        }

        private void gotoNextLevel(int nextLevel)
        {
            mode = "REST";
            mySnake = new Snake(mainBoard); //Brand new snake with length 1
            apples = new Rewards(nextLevel, mainBoard); //<--- Generate 5 apples

            //timer
            if(level == 1)
            {
                speed = 300;
                clock.Interval = speed;
            }
            else if (level == 2)
            {
                speed = 100;
                clock.Interval = speed;
            }
            else if (level == 3)
            {
                speed = 100;
                clock.Interval = 100;
            }
            else if (level == 4)
            {
                speed = 50;
                clock.Interval = 50;
            }
            else if(level == 5)
            {
                speed = 20;
                clock.Interval = 20;
            }
            else
            {
                speed = 20;
                clock.Interval = 20;
            }
            
            
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // wasd for controls
            if (e.KeyChar == 'w' || e.KeyChar == 'W')
            {
                
                mode = "UP";
               
            }
            else if (e.KeyChar == 'a' || e.KeyChar == 'A')
            {
                
                mode = "LEFT";
                
            }
            else if (e.KeyChar == 's' || e.KeyChar == 'S')
            {
                
                mode = "DOWN";
                
            }
            else if (e.KeyChar == 'd' || e.KeyChar == 'D')
            {

                mode = "RIGHT";
                
            }
        }

        private void refresh(Object myObject, EventArgs myEventArgs)
        {
            mySnake.move(mode); //Move the snake based on mode
            modeLBL.Text = mode;

            mainBoard.draw();
            apples.draw();  //<----- draw apples
            
            mySnake.draw();

            //change picture when moving in different direction
            if(mode == "UP")
            {
                mainBoard.draw(mySnake.getHeadPosition(), Properties.Resources.headup);
            }
            else if(mode == "LEFT")
            {
                mainBoard.draw(mySnake.getHeadPosition(), Properties.Resources.headleft);
            }
            else if(mode == "DOWN")
            {
                mainBoard.draw(mySnake.getHeadPosition(), Properties.Resources.headdown);
            }
            else if(mode == "RIGHT")
            {
                mainBoard.draw(mySnake.getHeadPosition(), Properties.Resources.headright);
            }
            //increment the duration by amount of time that has passed
            //this method is called every speed millisecond
            duration += speed;
            timerLBL.Text = Convert.ToString(duration / 1000); //Show time passed


            //Check if snke is biting itself. If so, call GameOver.
            if (mySnake.checkEatItself() == true)
            {
                GameOver();
            }
            else if (apples.checkIFSnakeHeadEatApple(mySnake.getHeadPosition()) == true)
            {
                if(level >= 1 && level <= 5)
                {
                    score += apples.eatAppleAtPostion(mySnake.getHeadPosition());
                }
                else
                {
                    score += apples.eatAppleAtPostion2(mySnake.getHeadPosition());
                }
                //sound plays
                eat.Play();
                
                scoreLBL.Text = Convert.ToString(score);


                if (apples.noMoreApples() == true)
                {
                    clock.Stop();
                    level++;
                    //if (Convert.ToInt32(levelLBL.Text) == 5)
                    //{
                    //    YouWin();
                    //}
                    levelLBL.Text = Convert.ToString(level);
                    gotoNextLevel(level);
                    MessageBox.Show("Press the start button to go to Level " + level, "Congrats");

                    for (int i = 1; i < Convert.ToInt32(levelLBL.Text); i++)
                    {
                        mySnake.addToTail(mySnake.GetPosition());
                    }
                }
                else
                {
                    //Length the snake and continue with the Game
                    mySnake.extendBody();
                }
            }
            
            



        }


        private void startBTN_Click(object sender, EventArgs e)
        {
            clock.Start();
        }

        private void pauseBTN_Click(object sender, EventArgs e)
        {
            clock.Stop();
        }
        
        
        private void GameOver()
        {
            clock.Stop();
            MessageBox.Show("Your time taken is " + duration / 1000 + " seconds. Your score is " +
            scoreLBL.Text + " Game Over");

            //String[] field;
            //String line;
            StreamWriter sw = new StreamWriter(@"D:\temp\Scores.txt",true);
            sw.WriteLine(scoreLBL.Text + '.'+name.Text + ',');
            
            sw.Close();

            this.Close();

            
        }
        //private void YouWin()
        //{
        //    clock.Stop();
        //    MessageBox.Show("You have won the game!!! Time taken is " + duration / 1000 + " seconds. Your score is " +
        //    scoreLBL.Text + " Game Over");

        //    //String[] field;
        //    //String line;
        //    StreamWriter sw = new StreamWriter(@"D:\temp\Scores.txt", true);
        //    sw.WriteLine(scoreLBL.Text + '.' + name.Text + ',');

        //    sw.Close();

        //    this.Close();


        //}

        private void highscore_Click(object sender, EventArgs e)
        {
            highscore hs = new highscore();
            hs.ShowDialog();

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for playing !!! Timing is " + duration / 1000 + " seconds. Your score is " + scoreLBL.Text);
            this.Close();
        }

        private void boardPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timerLBL_Click(object sender, EventArgs e)
        {

        }

        private void modeLBL_Click(object sender, EventArgs e)
        {

        }
    }
}