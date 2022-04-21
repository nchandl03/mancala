using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mancala
{
    static class Program
    {
        const int GAME_WON = 0;
        const int MOVE_ISSUE = -1;
        const int IO_ISSUE = -5;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            /*
            FileIO fileIO = new FileIO("topInput.txt", "botInput.txt", "output.txt");

            int curMove, played = 1;
            bool outCheck;

            while (played > 0)
            {
                outCheck = fileIO.outputBoard(game);

                if ((game.bottomTurn & game.botHuman) || (!game.bottomTurn && game.topHuman))
                {
                    curMove = 
                }
                else
                {
                    curMove = fileIO.readInMove(game);
                }

                if (curMove > -1 && outCheck) { played = game.playMove(curMove); }
                else                          { played = IO_ISSUE; }
            }

            if (played == GAME_WON)
            {
                // declare winner however it's done 
            } else if (played == MOVE_ISSUE)
            {
                // acknowledge invalid move 
            } else
            {
                // acknowledge I/O issue
            }
            */
        }
    }
}
