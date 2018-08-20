using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shooting_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // The below line initialized the form appearance.
            InitializeComponent();
        }

       // We are intereted in random number generator.

        Random r = new Random();

   

       // int nndNumber = r.Next(0, 6);
            // We inialised the score with a zero value.
        int Score = 0;

        // We inialised the total_shots with a zero value.
        int total_shots = 0;

        //We inialised the miss_shots with a zero value.
        int miss_shots = 0;

        //We inialised the _shot voice .
        void shot_voice()
        {
            //Sound
            System.Media.SoundPlayer player = new System.Media.SoundPlayer (@"C:\Users\user\Downloads\shot.wav");
            player.Play();
        }

        // Total Score
        void fn_shot ()
        {
            // We incremented the Score and added Score to the label
            Score++;
            label1.Text = "score=" + Score;
            
            total_shots++;  // We incremented the shots and added Shots to the label
            label3.Text = "Total Shots=" + total_shots;
            
            shot_voice();
            
        }

        // Miss fire
        void fn_miss_shot()
        {
            //  We incremented the Missing Shots and added Missing Shots to the labe2
            miss_shots++;
            label2.Text = "Missing Shots=" + miss_shots;
            total_shots++; //  We incremented the Shots and added Shots to the labe2
            label3.Text = "Total Shots=" + total_shots;
           
            shot_voice();
        }
        //Count of Total Shots
        void reset()
        {
            // code to create a reset funtion
            Score = 0;
            miss_shots = 0;
            total_shots = 0;
            label2.Text = "Missing Shots=" + miss_shots;
            label3.Text = "Total Shots=" + total_shots;
            label1.Text = "score=" + Score;
            timer1.Start();
            label4.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x, y;
            x = r.Next(20, 195);
            y = r.Next(130, 150);
            pictureBox1.Location = new Point(x, y);
            if (miss_shots>=6)
            {
                timer1.Stop();
                label4.Text = "Game Over";
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            fn_shot();

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            fn_miss_shot();
        }
     
        private void button3_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
