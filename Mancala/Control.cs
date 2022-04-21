﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mancala
{
    public static class Control
    {
        const int GAME_WON = 0;
        const int MOVE_ISSUE = -1;
        const int IO_ISSUE = -5;
        public static void runCompVCompGame()
        {
            FileIO fileIO = new FileIO("topInput.txt", "botInput.txt", "output.txt");

            int curMove, played = 1;
            bool outCheck;

            while (played > 0)
            {
                outCheck = fileIO.outputBoard();
                curMove = fileIO.readInMove();

                if (curMove > -1 && outCheck) { played = Game.playMove(curMove); }
                else { played = IO_ISSUE; }
            }

            if (played == GAME_WON)
            {
                /* declare winner however it's done */
            }
            else if (played == MOVE_ISSUE)
            {
                /* acknowledge invalid move */
            }
            else
            {
                /* acknowledge I/O issue */
            }
        }
    }
}
