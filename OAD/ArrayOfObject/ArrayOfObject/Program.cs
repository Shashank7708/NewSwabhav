using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangel1[] r = new Rectangel1[3];
            for(int i = 0; i < 3; ++i)
            {
                r[i] = new Rectangel1();
            }
            try
            {
                r[0].getValue(2, 3);

                r[1].getValue(4, 5);
                r[2].getValue(10, 20);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            for(int i = 0; i < 3; i++)
            {
                PrintInfo(r[i]);
            }
            Console.ReadLine();
        }

        static void PrintInfo(Rectangel1 r)
        {
            Console.WriteLine("Height= " + r.height + "\tWidth= " + r.width);

        }
    }
}
