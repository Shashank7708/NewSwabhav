using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.height = 10;
            r1.width = 20;
            r1.color = "red";
            r1.display();
            Console.ReadLine();
        }
    }
}
