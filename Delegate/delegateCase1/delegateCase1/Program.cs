using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateCase1
{
    public delegate void DelegateGesture(string name);
    class Program
    {
        private static void SayHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        public static void SayGoodBye(string name)
        {
            Console.WriteLine("GoodBye! " + name);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Case1:");
            DelegateGesture d = SayHello;
            d("Rahul");
            d = SayGoodBye;
            d("Rahul");
            Case3();
            Case4();
            Case5();


            Console.Read();

        }
        public static void MessageWizard(DelegateGesture fn)
        {
            Console.WriteLine("Inside Message Wizard");
            fn("champ");
        }
        public static void Case3()
        {
            Console.WriteLine("\ncase3:");
            MessageWizard(SayHello);
            MessageWizard(SayGoodBye);
        }
        public static void Case4()
        {
            Console.WriteLine("\nCas4:");
            MessageWizard(delegate(string name){
                Console.WriteLine("Anonymous delegate Function");
                Console.WriteLine("hello....{0}", name);
            });
        }
        public static void Case5()
        {
            Console.WriteLine("\nCase 5");
            MessageWizard((n) =>
            {
                Console.WriteLine("Lambda");
                Console.WriteLine("hello...{0}", n);
            });
        }
    }
}
