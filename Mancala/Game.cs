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
            else { return bottomStoreIndex + 1 + pit; }
        }

        int getAcrossIndex(int boardIndex)
        {
            int acrossIndex;

            if (bottomTurn) { acrossIndex = topStoreIndex - 1 - boardIndex; } 
            else {  acrossIndex = bottomStoreIndex - (boardIndex % bottomStoreIndex); }

            return acrossIndex;
        }

        bool isEmpty(int pit)
        {
            if (board[pit] == 0) { return true; }
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

            if (!bottomTurn && landingSpot > bottomStoreIndex && landingSpot < topStoreIndex)
            {
                if (isEmpty(landingSpot)) { return true; }
            }

            return false;
        }

        bool gameOver()
        {
            int sumMarbles = 0;
            for (int i = bottomStoreIndex + 1; i < topStoreIndex; i++)
            {
                sumMarbles += board[i];
            }
            if (sumMarbles <= 0) { return true; }

            sumMarbles = 0;
            for (int i = 0; i < bottomStoreIndex; i++)
            {
                sumMarbles += board[i];
            }
            if (sumMarbles <= 0) { return true; }

            return false;
        }

        int playMove(int chosenIndex)
        {
            if (!isValidMove(chosenIndex)) { return -1; }

            int pit = getBoardIndex(chosenIndex);
            int numMarbles = board[pit];

            int dropIndex = (pit) % boardSize;

            // add marbles into next pits, - landing spot and opp's store
            for (int i = 0; i < numMarbles - 1; i++)
            {
                dropIndex = (dropIndex + 1) % boardSize;

                if (bottomTurn && dropIndex == topStoreIndex) { dropIndex = (dropIndex + 1) % boardSize; }
                else if (!bottomTurn && dropIndex == bottomStoreIndex) { dropIndex = (dropIndex + 1) % boardSize; }

                board[dropIndex]++;
            }
            dropIndex = (dropIndex + 1) % boardSize;

            // take another turn
            if (lastSeedInStore(dropIndex))
            {
                board[dropIndex]++;

            } 
            // get opponent's seeds across from drop
            else if (lastSeedInEmpty(dropIndex))
            {
                board[dropIndex]++;

                int acrossIndex = getAcrossIndex(dropIndex);
                int marblesToStore = board[dropIndex] + board[acrossIndex];

                board[dropIndex] = 0;
                board[acrossIndex] = 0;

                if (bottomTurn) { board[bottomStoreIndex] += marblesToStore; }
                else { board[topStoreIndex] += marblesToStore; }

                bottomTurn = !bottomTurn;

            } else
            {
                board[dropIndex]++;
                bottomTurn = !bottomTurn;
            }

            if (gameOver())
            {
                // run game over protocol, check who wins
                return 0;
            }

            return 1;
        }

    }
}
