using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Shooting_Game
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        void load_voice()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\user\Downloads\load.wav");
            player.Play();
        }
        void spin_voice()
        {
            System.Media.SoundPlayer player1 = new System.Media.SoundPlayer(@"C:\Users\user\Downloads\spin.wav");
            player1.Play();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            load_voice();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            spin_voice();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 openForm = new Form1 ();
            openForm.Show();
            Visible = false;
            this.Hide();
        }
    }
}
