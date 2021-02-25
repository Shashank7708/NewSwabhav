using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe1 t1 = new TicTacToe1();
           
            t1.initializerMatrix();
                showMatric(t1);
                for (int tictactoesize = 0; tictactoesize < 3; tictactoesize++)
                {
                    Console.WriteLine("Player 1:Enter position:");
                    int i = int.Parse(Console.ReadLine());
                    int j = int.Parse(Console.ReadLine());
                    bool add = t1.addtomatrix(i, j, "x");
                    Console.WriteLine();
                    showMatric(t1);

                    Console.WriteLine("Player 2:Enter position:");
                    int l = int.Parse(Console.ReadLine());
                    int k = int.Parse(Console.ReadLine());
                    bool add1 = t1.addtomatrix(l, k, "o");
                    Console.WriteLine(add1);
                    Console.WriteLine();
                    showMatric(t1);


                }
                Console.ForegroundColor = ConsoleColor.Green;
                if (t1.ReturnWinner().Equals("x"))
                {
                    Console.WriteLine("Winner:Player1");
                }
                else if (t1.ReturnWinner().Equals("o"))
                {
                    Console.WriteLine("Winner:Player2");
                }
                else
                    Console.WriteLine("Better Luck Next Time");
                
            Console.ReadLine();


        }
        public static void showMatric(TicTacToe1 t1)
        {
            string[,] matrix = t1.showMatrix;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write("{0} " , matrix[i, j]);

                }
                Console.WriteLine();
                
            }

        }

    }
}
