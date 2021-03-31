using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPigGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pig Game:");
            Random rnd = new Random();
            bool nextTurn = true;
            int noOfTurn = 1;
            int noOfHnR = 1;
            int randomNofromDice;
            int total = 20;
            int usertotal = 0;
            while (nextTurn)
            {
                Console.WriteLine("TUrn :" + noOfTurn);
                noOfHnR = 1;
                noOfTurn++;
                while (true)
                {
                    Console.Write("Roll/Hold:");
                    string input = (Console.ReadLine());
                    if (input.ToLower().Equals("r"))
                    {
                        noOfHnR++;
                        randomNofromDice = GenerateRandomno(rnd);
                        Console.WriteLine("Dice: " + randomNofromDice);
                        usertotal = usertotal + randomNofromDice;
                        if (randomNofromDice == 1)
                        {
                            usertotal = 0;
                            break;
                        }

                    }
                    else if (input.ToLower().Equals("h"))
                    {

                        if (usertotal >= total)
                        {
                            nextTurn = false;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                        noOfHnR--;
                    }
                }
                Console.WriteLine("no of Hold & Read:" + noOfHnR);
                Console.WriteLine("Total=" + usertotal);

            }
            Console.WriteLine("Congrulation! You have won the Game in {0} turns", noOfTurn);
            Console.ReadLine();
        }
        public static int GenerateRandomno(Random rnd)
        {
            return rnd.Next(1, 6);

        }
    }
}





