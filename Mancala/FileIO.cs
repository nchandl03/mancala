using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mancala
{
    public static class FileIO
    {
        // always outputs board the same way - is that okay?
        public static bool outputBoard(string fileOut)
        {
            if (Game.board.Length < 1)
                return false;

            try
            {
                using (StreamWriter sw = new StreamWriter(fileOut))
                {
                    sw.Write("   ");
                    for (int i = Game.topStoreIndex - 1; i > Game.bottomStoreIndex; i--)
                    {
                        sw.Write(Game.board[i].ToString() + "  ");
                    }

                    // middle row
                    sw.Write("\n" + Game.board[Game.topStoreIndex].ToString() + "  ");
                    for (int i = Game.topStoreIndex - 1; i > Game.bottomStoreIndex; i--)
                    {
                        sw.Write("   ");
                    }
                    sw.Write(Game.board[Game.bottomStoreIndex].ToString() + "\n");

                    // bottom row
                    sw.Write("   ");
                    for (int i = 0; i < Game.bottomStoreIndex; i++)
                    {
                        sw.Write(Game.board[i].ToString() + "  ");
                    }

                    sw.Flush();
                }
            } catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;

        }

        public static int readInMove(string fileInBottom, string fileInTop)
        {
            string line;
            string path = Game.bottomTurn ? fileInBottom : fileInTop;
            int moveIndex = -2;


            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    line = sr.ReadLine();
                    line = line.Trim();
                }
            } catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }

            Console.WriteLine(line);

            if (!Int32.TryParse(line, out moveIndex))
            {
                Console.WriteLine("Invalid input - need move to be an integer.");
                return -2;
            }
            return moveIndex;
        }
    }
}
