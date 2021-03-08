using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateAndThread
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass x = new SomeClass();
            x.sender = Receiver;
           
            Thread t = new Thread(new ThreadStart(x.HugeProcess));
            Console.WriteLine("Program.cs");
            Console.WriteLine("hello");
            Console.ReadLine();

        }
        static void Receiver(int i)
        {
            Console.WriteLine(i);
        }
    }
}
