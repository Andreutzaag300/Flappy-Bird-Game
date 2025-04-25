using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Game
{
    public partial class Form1 : Form
    {

        double pipeSpeed;

        int gravity = 10 ;
        int score = 0;
        bool GameOver = false;
  

        Form meniu;


        

        public Form1(Form _meniu, int dif_select)
        {

            InitializeComponent();
           
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
             meniu = _meniu;


            if (dif_select == 1)
            {
                pipeSpeed = 8;
            }
            else 
                if (dif_select == 2)
            {
                pipeSpeed = 20;
            }

            else 
                if (dif_select == 3) 
            { 
                pipeSpeed = 40;
            }
             
                else 
                    pipeSpeed = 8;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            meniu.Show();

        }

        

       
        

        //////////////////////////////////////////////////////////////////////////

        private void gameTimerEvent(object sender, EventArgs e)
        {

            Random rand = new Random ();
            


            flappyBird.Top += gravity;
            pipeBottom.Left -= ((int)pipeSpeed);
            pipeTop.Left -= ((int)pipeSpeed);
            pipeBottom2.Left -= ((int)pipeSpeed);
            pipeTop2.Left -= ((int)pipeSpeed);

            ScoreText.Text = "Score : " + score;
            if(pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                pipeBottom.Location = new Point(pipeBottom.Left, rand.Next(370,405));
                score++;
            }

            if(pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                pipeTop.Location = new Point(pipeTop.Left, rand.Next(-150,-100)); //437, -123
                score++;
            }

            if (pipeBottom2.Left < -150)
            {
                pipeBottom2.Left = 800;

                pipeBottom2.Location = new Point(pipeBottom2.Left, rand.Next(400,480));//564, 471 
                score++;
            }

            if (pipeTop2.Left < -180)
            {
                pipeTop2.Left = 950;
                pipeTop2.Location = new Point(pipeTop2.Left, rand.Next(-100,-60)); //640, -59
                score++;
            }
            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeBottom2.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop2.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                flappyBird.Top < -25 )
            {
                EndGame();
            }

            
           
                //pipeSpeed += 0.03;
             
            

        }
        
        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
                
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
            if(e.KeyCode == Keys.R && GameOver == true)
            { 
                RestartGame();
            }   

            if(e.KeyCode == Keys.E && GameOver == true)
            {
                Close();
            }


        }

        private void EndGame()
        {

            gameTimer.Stop();
            ScoreText.Text  += " Game over!";
            Countlbl.Location = new Point(56, 202);
            Countlbl.Show();
            Countlbl.Enabled = true;
            Countlbl.Font = new Font("OCR A Extended", 26 , FontStyle.Bold);
            Countlbl.Text = "Press R to retry!";

            EXIT.Show();
            EXIT.Enabled = true;
            EXIT.Font = new Font("OCR A Extended", 26, FontStyle.Bold);
            EXIT.Text = "Press E to exit!";



            GameOver = true;


        }

        int count = 4;

        private void timer1_Tick(object sender, EventArgs e)
        {
        
            Countlbl.Text=(count-1).ToString();

            if(count == 1)
            {
                Countlbl.Text = "GO!";
            }

            if (count == 0)
            {
                
                
                timer1.Enabled = false;
                gameTimer.Enabled = true;
                Countlbl.Enabled = false;
                Countlbl.Hide();
            }

            count--;
            

        }

      
    
        private void RestartGame()
        {
           

            pipeTop.Location = new Point(437, -123);

            pipeBottom.Location = new Point(285, 402);

            pipeBottom2.Location = new Point(564, 471);

            pipeTop2.Location = new Point(640, -59);

            GameOver = false;
            flappyBird.Location = new Point(12, 101);
            pipeTop.Left = 437;
            pipeBottom.Left = 285;
            pipeTop2.Left = 640;
            pipeBottom2.Left = 564;

            score = 0;
           
            ScoreText.Text = "Score : 0";
            Countlbl.Enabled = false;
            Countlbl.Hide();

            EXIT.Enabled = false;
            EXIT.Hide();

            Speed.Enabled = false;
            Speed.Hide();

            


            gameTimer.Start();

            count = 4;
            timer1.Enabled = true;
            Countlbl.Location = new Point(238, 197);
            Countlbl.Text = "";
            Countlbl.Font = new Font("OCR A Extended", 72, FontStyle.Bold);
            Countlbl.Enabled = true;
            Countlbl.Show();
            gameTimer.Enabled = false;
            
        }

       
    }
}
