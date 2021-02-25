
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculateArea r1 = new Rectangl(30, 20);
            Console.WriteLine("Area Of Rectangle: " + r1.calculateArea());

            ICalculateArea s1 = new Square(30);
            Console.WriteLine("Area Of Square: " + s1.calculateArea());

            Console.ReadLine();


        }
        
    }
}
