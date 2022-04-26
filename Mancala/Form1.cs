using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;



namespace Mancala
{
    public enum gameType
    {
        twoHuman,
        oneHuman,
        twoComps
    }
    public partial class Form1 : Form
    {

        const int GAME_WON = 0;
        const int MOVE_ISSUE = -1;
        const int IO_ISSUE = -5;

        public int player1 = -10;
        public int player2 = -10;
        public string fileName = "";
        public int playerTurn;
        public gameType playerTypes;

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

        // submit button
        private void button1_Click(object sender, EventArgs e)
        {
            Game.setGame(6, 4);
            updateMarbleNums();

            if (player1 == 1 && player2 == 1)
            {  // both computers
                playerTypes = gameType.twoComps;
                runCompVCompGame();
            }

            else if (player1 == 1 || player2 == 1)
            {
                // one computer
                playerTypes = gameType.oneHuman;
            }

            else if (player1 == 0 && player2 == 0)
            {
                playerTypes = gameType.twoHuman;
            }

            else
            {
                MessageBox.Show("Please choose Human OR Computer for each player, then start game");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            
        }

        private void pitClicked(string chosenPit)
        {
            if (playerTypes == gameType.twoComps)
            {
                return;
            }

            if (playerTypes == gameType.twoHuman)
            {
                runHumanVHumanTurn(chosenPit);
                return;
            }

            if (playerTypes == gameType.oneHuman)
            {
                runHumanVCompTurn(chosenPit);
                return;
            }

            /* else ask them to select each player type */
            MessageBox.Show("Please choose Human OR Computer for each player, then start game");
        }

        private void runCompVCompGame()
        {
            int curMove, played = 1;
            bool outCheck;

            while (played > 0)
            {
                outCheck = FileIO.outputBoard("output.txt");
                curMove = FileIO.readInMove("move.txt", "move.txt");

                if (curMove > -1 && outCheck) { 
                    played = Game.playMove(curMove);
                    updateMarbleNums();
                }
                else { played = IO_ISSUE; }
            }

            if (isGameOver(played))
            {
                resetGame();
            }
        }

        private void runHumanVCompTurn(string chosenButton)
        {
            if (Game.bottomTurn && chosenButton[0] != 'B')
            {
                /* acknowledge choice is on wrong side */
                return;
            }

            // human is always "bottom"
            if (!Game.bottomTurn) { return; }

            int curMove = chosenButton[1] - '0';
            int played = Game.playMove(curMove);
            updateMarbleNums();

            if (isGameOver(played))
            {
                resetGame();
                return;
            }

            bool outCheck;
                
            outCheck = FileIO.outputBoard("output.txt");

            // while it's top's turn !!
            Process.Start("Greedy.exe");

            curMove = FileIO.readInMove("move.txt", "move.txt");

            if (curMove > -1 && outCheck) { 
                played = Game.playMove(curMove);
                updateMarbleNums();
            }
            else { played = IO_ISSUE; }

            if (isGameOver(played))
            {
                resetGame();
            }
        }

        // B0   T0
        // B1   T1
        private void runHumanVHumanTurn(string chosenButton)
        {
            if (Game.bottomTurn && chosenButton[0] != 'B')
            {
                /* acknowledge choice is on wrong side */
                return;
            }

            if (!Game.bottomTurn && chosenButton[0] != 'T')
            {
                /* acknowledge choice is on wrong side */
                return;
            }

            int curMove = chosenButton[1] - '0';
            Console.Write(curMove);

            int played = Game.playMove(curMove);
            updateMarbleNums();


            if (isGameOver(played))
            {
                resetGame();
            }
        }

        private bool isGameOver(int played)
        {
            if (played == GAME_WON)
            {
                if (Game.winner.CompareTo("") != 0)
                {
                    MessageBox.Show("Congratulations! " + Game.winner + " wins!");
                }

                else { MessageBox.Show("Would you look at that, it's a tie."); }

                return true;
            }
            else if (played == MOVE_ISSUE)
            {
                /* acknowledge invalid move */
                if (Game.bottomTurn)
                {
                    MessageBox.Show("Player one made an invalid move. Game over.");
                }

                else { MessageBox.Show("Player two made an invalid move. Game over."); }

                return true;
            }
            else if (played == IO_ISSUE)
            {
                /* acknowledge I/O issue */
                MessageBox.Show("Sorry, I/O issue on our end! Try again later, or play a two Human player game.");
                return true;
            }

            return false;
        }

        private void resetGame()
        {
            Game.setGame(6, 0);
            updateMarbleNums();
        }
        private void updateMarbleNums()
        {
            // update label marble nums
            string name = "slot";
            for (int i = 0; i < 14; i++)
            {
                this.Controls[name + (i).ToString()].Text = Game.board[i].ToString();
            }

            // update bottom marble pics
            for (int i = 0; i < 6;  i++)
            {
                name = "B" + (i % 6).ToString();
                this.Controls[name].Text = Game.board[i].ToString();
            }

            // update top marble pics
            for (int i = 7; i < 13; i++)
            {
                name = "T" + (i - 7).ToString();
                this.Controls[name].Text = Game.board[i].ToString();
            }

            int index;
            var chosenPic = Properties.Resources.mancalaBrown4Marble;

            // update marble pics
            for (int i = 0; i < 12; i++)
            {


                if (i < 6) { name = "B" + (i % 6).ToString(); index = i; }
                else       { name = "T" + (i % 6).ToString(); index = 1 + i; }

                switch (Game.board[index])
                {
                    case 0:
                        chosenPic = Properties.Resources.MancalaWood2;
                        break;
                    case 1:
                        chosenPic = Properties.Resources._1Marble;
                        break;
                    case 2:
                        chosenPic = Properties.Resources._2Marble;
                        break;
                    case 3:
                        chosenPic = Properties.Resources._3Marble;
                        break;
                    case 4:
                        chosenPic = Properties.Resources._4Marble;
                        break;
                    case 5:
                        chosenPic = Properties.Resources._5Marble;
                        break;
                    default:
                        chosenPic = Properties.Resources._6Marble;
                        break;
                }

                this.Controls[name].BackgroundImage = chosenPic;
            }

        }

        private void B0_Click(object sender, EventArgs e)
        {
            pitClicked("B0");
        }

        private void B1_Click(object sender, EventArgs e)
        {
            pitClicked("B1");
        }

        private void B2_Click(object sender, EventArgs e)
        {
            pitClicked("B2");
        }

        private void B3_Click(object sender, EventArgs e)
        {
            pitClicked("B3");
        }

        private void B4_Click(object sender, EventArgs e)
        {
            pitClicked("B4");
        }

        private void B5_Click(object sender, EventArgs e)
        {
            pitClicked("B5");
        }

        private void T5_Click(object sender, EventArgs e)
        {
            pitClicked("T5");
        }

        private void T4_Click(object sender, EventArgs e)
        {
            pitClicked("T4");
        }

        private void T3_Click(object sender, EventArgs e)
        {
            pitClicked("T3");
        }

        private void T2_Click(object sender, EventArgs e)
        {
            pitClicked("T2");
        }

        private void T1_Click(object sender, EventArgs e)
        {
            pitClicked("T1");
        }

        private void T0_Click(object sender, EventArgs e)
        {
            pitClicked("T0");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void slot13_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
