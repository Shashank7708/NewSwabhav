using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonEg2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService d1 = new DataService();
            DataService d2 = new DataService();
            Console.WriteLine();
            Console.WriteLine("d1 hash code:" + d1.GetHashCode());
            Console.WriteLine("d2 hash Code :" + d2.GetHashCode());
            Console.WriteLine();
            d1.processData();
            d2.processData();
            Console.ReadLine();

        }
    }
}
