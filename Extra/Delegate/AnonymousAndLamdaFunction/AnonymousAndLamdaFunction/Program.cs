using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousAndLamdaFunction
{
    public delegate void DSaysAnything(string name);
    class Program
    {
        static void Main(string[] args)
        {
            Case1();
            Case2();
            Case3();
            Console.Read();
        }

        public static void Case1()
        {
            DSaysAnything x = Function;
            x("Rahul");
            
        }
        public static void Function(string name)
        {
            Console.WriteLine("Named Function " + name);
        }

        public static void MessageWizard(DSaysAnything fn)
        {
            
            fn("Rahul");
        }
        public static void Case2()
        {
            
            MessageWizard(delegate (string name) {
                Console.WriteLine("Anonymous delegate Function");
                Console.WriteLine("Name:{0}", name);
            });
        }
        public static void Case3()
        {
            Console.WriteLine("Lamda Function");
            MessageWizard((n) =>
            {
                Console.WriteLine("1 Name:" + n);

            });
        }
    }
}
