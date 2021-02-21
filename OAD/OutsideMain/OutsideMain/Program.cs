using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutsideMain
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            while (x > 1)
            {
                x = x - 1;
                if (x < 3)
                {
                    Console.WriteLine("small X" + x);
                }
            }
            Console.ReadLine();
        }
    }
}
