using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game();
            displayRules();
            PlayGame(g);
            Console.Read();



        }
        public static void displayRules()
        {
            Console.WriteLine("Rules:");
            Console.WriteLine("# See How turns t Takes you to get to 20");
            Console.WriteLine("# Turn end if you hold or roll a 1");
            Console.WriteLine("# if you roll a 1,you loose all points for the turn");
            Console.WriteLine("# If you hold, you save all points for the turn");
        }

        static int getTurn(Game game)
        {
            return game.getTurn();
        }
        public static void PlayGame(Game game)
        {
            while (!game.isgameover)
            {
                Console.WriteLine("Turn " + getTurn(game));
                game.switchThisTurn(game.getTurn() + 1);
                game.isTurnOver = false;
                while (!game.isTurnOver)
                {
                    Console.Write("Roll or Hold:");
                    string choice = Console.ReadLine();
                    if (choice.ToLower().Equals("r"))
                    {
                        game.isTurnOver = roll(game);
                    }
                    else if (choice.ToLower().Equals("h"))
                    {
                        game.isTurnOver = hold(game);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice");
                    }
                }
                Console.WriteLine("Score:" + game.score());
                if (game.score() >= 20)
                {
                    game.isgameover = true;
                }
            }
            Console.WriteLine("Congrulation! You have won the Game in {0} turns", game.getTurn());
            Console.WriteLine("Score: " + game.score());
        }

        public static bool roll(Game game)
        {
            
             int a=game.getValue();
            Console.WriteLine("Die:" + a);

            if (a == 1)
            {
                game.setScore();
                return true;
            }
            return false;
        }
        public static bool hold(Game game)
        {
            return true;
        }
    }
}
