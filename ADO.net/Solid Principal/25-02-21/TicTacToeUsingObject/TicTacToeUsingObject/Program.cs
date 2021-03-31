using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeUsingObject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isGameOver = false;
            Game game = new Game();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Player 1:Enter your name");
            string name1 = Console.ReadLine();
            

            Player p1 = new Player() { name = name1, symbol = MarkType.x.ToString() };
            Console.WriteLine("Symbol:{0}",p1.symbol);
            Console.WriteLine("Player 2:Enter your name");
            string name2 = Console.ReadLine();
            Player p2 = new Player { name = name2, symbol = MarkType.o.ToString() };
            Console.WriteLine("Symbol:{0}",p2.symbol);
            game.initializeBoard();
            game.initializePlayer(p1, p2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n# Let's Start the Game #");
            Console.ForegroundColor = ConsoleColor.Green;
            while (!isGameOver)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(p1.name + " Enter your Position:");
                int i = int.Parse(Console.ReadLine());
                int j = int.Parse(Console.ReadLine());
                bool addedornot = game.addtomatrix(i, j, p1.symbol);
                Console.ForegroundColor = ConsoleColor.Blue;
                if (addedornot) { Console.WriteLine("Added Successfully"); }
                else { Console.WriteLine("Error:Position is NotEmpty"); }
                isGameOver = game.isgameover();
                 showMatric(game);
                if (isGameOver == true) { break; }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(p2.name + " Enter your Position:");
                int l = int.Parse(Console.ReadLine());
                int k = int.Parse(Console.ReadLine());
                bool addOrNot1 = game.addtomatrix(l, k, p2.symbol);
                Console.ForegroundColor = ConsoleColor.Blue;
                if (addOrNot1) { Console.WriteLine("Added Successfully"); }
                else { Console.WriteLine("Error:Position is NotEmpty"); }
                isGameOver = game.isgameover();
              
                showMatric(game);

            }
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(game.WinOrDraw());
            if (game.WinOrDraw().ToString().Equals("win"))
            {
                Console.WriteLine("Congrulation! "+game.GetWinner().name+"is the Winnner ");
            }
            Console.ReadLine();
        }
        public static void showMatric(Game t1)
        {
            string[,] matrix = t1.showMatrix;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);

                }
                Console.WriteLine();

            }
        }
    }
}
