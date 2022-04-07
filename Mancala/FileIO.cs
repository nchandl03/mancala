using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mancala
{
    public class FileIO
    {
        string fileInTop;
        string fileInBottom;
        string fileOut;

        public FileIO(string finTop, string finBottom, string fout)
        {
            fileInTop = finTop;
            fileInBottom = finBottom;
            fileOut = fout;
        }

        // always outputs board the same way - is that okay?
        public bool outputBoard(Game game)
        {
            if (game.board.Length < 1)
                return false;

            try
            {
                using (StreamWriter sw = new StreamWriter(fileOut))
                {
                    sw.Write("   ");
                    for (int i = game.topStoreIndex - 1; i > game.bottomStoreIndex; i--)
                    {
                        sw.Write(game.board[i].ToString() + "  ");
                    }

                    // middle row
                    sw.Write("\n" + game.board[game.topStoreIndex].ToString() + "  ");
                    for (int i = game.topStoreIndex - 1; i > game.bottomStoreIndex; i--)
                    {
                        sw.Write("   ");
                    }
                    sw.Write(game.board[game.bottomStoreIndex].ToString() + "\n");

                    // bottom row
                    sw.Write("   ");
                    for (int i = 0; i < game.bottomStoreIndex; i++)
                    {
                        sw.Write(game.board[i].ToString() + "  ");
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

        public int readInMove(Game game)
        {
            string line;
            string path = game.bottomTurn ? fileInBottom : fileInTop;
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

            if (!Int32.TryParse(line, out moveIndex))
            {
                Console.WriteLine("Invalid input - need move to be an integer.");
                return -2;
            }
            return moveIndex;
        }
    }
}
