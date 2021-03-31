using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> names = args;
            var sortname = names.OrderBy(x => x);
            foreach(string i in sortname)
            {
                Console.WriteLine(i);
            }
            var top3 = names.OrderBy(x =>x).Take(3);
            Console.WriteLine("TOp 3:");
            foreach (string i in top3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Containing a");
            var arr = names.Where(n => n.Contains("a"));
            foreach (string i in arr)
            {
                Console.WriteLine(i);
            }
            var maleng = names.Max(x =>x);
            Console.WriteLine(maleng+" ----");

            Console.ReadLine();
        }
    }
}
