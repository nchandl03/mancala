using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mancala
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());

            Game game = new Game(6, 4);
            game.printBoardToConsole();

            Console.WriteLine("Pick: 3rd pit, bottom row.");
            game.playMove(2);
            game.printBoardToConsole();

            Console.WriteLine("Pick: 2nd pit, bottom row.");
            game.playMove(1);
            game.printBoardToConsole();

            Console.WriteLine("Pick: 5th pit, top row.");
            game.playMove(4);
            game.printBoardToConsole();

            Console.WriteLine("Pick: 1st pit, bottom row.");
            game.playMove(0);
            game.printBoardToConsole();

            Console.WriteLine("Pick: 5th pit, top row. (should ignore)");
            game.playMove(4);
            game.printBoardToConsole();

            Console.WriteLine("Pick: 6th pit, top row. -----");
            game.playMove(5);
            game.printBoardToConsole();

            Console.WriteLine("Pick: 3rd pit, bottom row.");
            game.playMove(2);
            game.printBoardToConsole();

            Console.WriteLine("Pick: 4th pit, top row.");
            game.playMove(3);
            game.printBoardToConsole();

            Console.WriteLine("Pick: 6th pit, bottom row.");
            game.playMove(5);
            game.printBoardToConsole();


            Console.Read();
        }
    }
}
