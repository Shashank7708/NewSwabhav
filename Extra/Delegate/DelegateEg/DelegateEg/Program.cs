using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEg
{
    class Program
    {
        public delegate void RectDelegate(double h, double w);
        static void Main(string[] args)
        {
            Console.WriteLine("MultiCast Delegate");
            Rectangle rect = new Rectangle();
            RectDelegate obj = new RectDelegate(rect.Area);
            obj += rect.Perimeter;
            obj.Invoke(20, 10);
            Console.Read();

        }
    }
}
