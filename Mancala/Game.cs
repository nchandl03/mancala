using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mancala
{
    internal class Game
    {
        /*
         * Board Setup rn:
         *      12  11  10  9   8   7  
         *  13                          6
         *      0   1   2   3   4   5
         */

        int[] board;
        int boardSize;

        int topStoreIndex, bottomStoreIndex;
        bool bottomTurn;

        Game(int bottomSize, int numMarbles)
        {
            int totalpits = bottomSize * 2 + 2;

            board = new int[totalpits];
            boardSize = totalpits;

            bottomStoreIndex = bottomSize;
            topStoreIndex = totalpits - 1;

            for (int i = 0; i < boardSize; i++)
            {
                board[i] = numMarbles; // starts w/ 4 marbles in each usually 
            }

            board[topStoreIndex] = 0;
            board[bottomStoreIndex] = 0;
            
            bottomTurn = true;
        }

        int getBoardIndex(int pit)
        {
            if (bottomTurn) { return pit; }
            else { return bottomStoreIndex + 1 + pit;  }
        }

        bool isEmpty (int pit)
        {
            if (board[pit] == 0) {  return true; }
            return false;
        }

        bool isValidMove(int pit)
        {
            // chosen pit is too big/small for board
            if (pit < 0 || pit >= bottomStoreIndex)
            {
                return false;
            }

            int boardIndex = getBoardIndex(pit);

            // chosen pit is empty
            if (isEmpty(boardIndex)) { return false; }

            return true;
        }

        // special move #1
        bool lastSeedInStore(int landingSpot)
        {
            if (bottomTurn && landingSpot == bottomStoreIndex)
            {
                    return true;
            }
            else if (!bottomTurn && landingSpot == topStoreIndex)
            {
                    return true;
            }

            return false;
        }

        // special move #2
        bool lastSeedInEmpty(int landingSpot)
        {
            if (bottomTurn && landingSpot >= 0 && landingSpot < bottomStoreIndex) 
            {
                if (isEmpty(landingSpot)) { return true; }
            }
            
            if (!bottomTurn && landingSpot > bottomStoreIndex && landingSpot < topStoreIndex) {
                if (isEmpty(landingSpot)) { return true; }
            }

            return false;
        }

    }
}
