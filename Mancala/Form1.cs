using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mancala
{
    public partial class Form1 : Form
    {

        public int player1;
        public int player2;
        public string fileName = "";
        public int playerTurn;

        public Form1()
        {
            InitializeComponent();
        }

        private void human1_CheckedChanged(object sender, EventArgs e)
        {
            if (human1.Checked)
            {
                player1 = 0;
            }

        }

        private void computer1_CheckedChanged(object sender, EventArgs e)
        {
            if (computer1.Checked)
            {
                player1 = 1;
            }

        }

        private void human2_CheckedChanged(object sender, EventArgs e)
        {
            if (human2.Checked)
            {
                player2 = 0;
            }

        }

        private void computer2_CheckedChanged(object sender, EventArgs e)
        {
            if (computer2.Checked)
            {
                player2 = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (player1 == 1 && player2 == 1)
            {  // both computers

            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
