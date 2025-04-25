using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Game
{
    public partial class Meniu_Principal : Form
    {
        SoundPlayer p;
        public Meniu_Principal()
        {
            InitializeComponent();
            Mutebtn.Image = Properties.Resources.Mute;

            SoundPlayer play = new SoundPlayer(Properties.Resources.Arcade_ish);
            p=play;
            play.Play();
            play.PlayLooping();

            this.FormClosing += new FormClosingEventHandler(Meniu_Principal_FormClosing);
        }
       


    private void Meniu_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Close();

        }



        private void Dificultate_Click(object sender, EventArgs e)
        {
            Dificulty window = new Dificulty(this);
            window.Show();

            this.Hide();
        }
        int k = 0;
        private void Mutebtn_Click(object sender, EventArgs e)
        {
            k++;
            if (k % 2 == 1)
            {
                p.Stop();
                Mutebtn.Image = Properties.Resources.Unmute;
                Mutebtn.Refresh();
                Mutebtn.Visible = true;
            }
            else
            {
                p.Play();
                p.PlayLooping();
                Mutebtn.Image = Properties.Resources.Mute;
                Mutebtn.Refresh();
                Mutebtn.Visible = true;
            }
        }
    }
}
