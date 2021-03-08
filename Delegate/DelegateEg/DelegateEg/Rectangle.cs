using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEg
{
    class Rectangle
    {
        public void Area(double height,double width)
        {
            Console.WriteLine("Area:" + height * width);
        }
        public void Perimeter(double height, double width)
        {
            Console.Write("Perimeter:" + 2*(height + width));
        }
    }
}
