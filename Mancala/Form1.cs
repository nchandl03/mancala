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
                curMove = FileIO.readInMove("topInput.txt", "botInput.txt");

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
            curMove = FileIO.readInMove("topInput.txt", "botInput.txt");

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

                MessageBox.Show("Would you look at that, it's a tie.");

                return true;
            }
            else if (played == MOVE_ISSUE)
            {
                /* acknowledge invalid move */
                if (Game.bottomTurn)
                {
                    MessageBox.Show("Player one made an invalid move. Game over.");
                }

                MessageBox.Show("Player two made an invalid move. Game over.");

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
        }
        private void updateMarbleNums()
        {
            slot0.Text = Game.board[0].ToString();
            slot1.Text = Game.board[1].ToString();
            slot2.Text = Game.board[2].ToString();
            slot3.Text = Game.board[3].ToString();
            slot4.Text = Game.board[4].ToString();
            slot5.Text = Game.board[5].ToString();
            slot6.Text = Game.board[6].ToString();
            slot7.Text = Game.board[7].ToString();
            slot8.Text = Game.board[8].ToString();
            slot9.Text = Game.board[9].ToString();
            slot10.Text = Game.board[10].ToString();
            slot11.Text = Game.board[11].ToString();
            slot12.Text = Game.board[12].ToString();
            slot13.Text = Game.board[13].ToString();
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
    }
}
