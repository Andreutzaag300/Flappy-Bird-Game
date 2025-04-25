using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Flappy_Bird_Game
{
    public partial class Dificulty : Form
    {
        Form _meniu;
        public Dificulty(Meniu_Principal meniu)
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            _meniu = meniu;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _meniu.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dificulty = 1;
            Form1 gameWindow = new Form1(this, dificulty);
            gameWindow.Show();


            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dificulty = 2;
            Form1 gameWindow = new Form1(this, dificulty);
            gameWindow.Show();


            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int dificulty = 3;
            Form1 gameWindow = new Form1(this, dificulty);
            gameWindow.Show();


            this.Hide();
        }

        private void Dificulty_Load(object sender, EventArgs e)
        {

        }

        private void Return_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
