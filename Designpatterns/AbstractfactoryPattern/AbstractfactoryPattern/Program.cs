using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractfactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Factory Pattern");
            ShapeFactory shapeFactory = new ShapeFactory();
            ColorFactory colorFactory = new ColorFactory();
            Circle circle=shapeFactory.Getdata((int)ShapeType.Circle).DataItem as Circle;
            circle.GetInfo();
            Red red = colorFactory.Getdata((int)ColorType.red).DataItem as Red;
            red.GetInfo();
            Console.Read();

        }
    }

    enum ShapeType
    {
        Circle=1,
        Square=2,
        Rectangle=3
    }
    enum ColorType
    {
        red=1,
        green=2,
        blue=3
    }
}

