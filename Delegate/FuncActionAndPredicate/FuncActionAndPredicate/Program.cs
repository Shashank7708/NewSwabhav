using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncActionAndPredicate
{   
    class Program
    {
        public static int[] array(int a,int b,int c)
        {
            int[] temparray = new int[4];
            temparray[0] = a;
            temparray[1] = c;
                temparray[2] = b;
            return temparray;
        }

        public static void PrintIno(string str)
        {
            Console.WriteLine("Hello!My name is " + str);
        }
        public static bool AreGreaterthan20(int b)
        {
            if (b > 20)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Func<int, int, int, int[]> obj1 = array;
          int[] arr=  obj1(10, 20, 30);
            Console.WriteLine("Func returning array element:");
            foreach(int i in arr)
            {
                Console.Write(i + "\t");
            }

            Console.WriteLine();
            Console.WriteLine("Eg of Action");
            Action<string> obj2 = PrintIno;
            obj2("Rahul");

            Console.WriteLine("Eg of predicate");
            Predicate<int> obj3 = AreGreaterthan20;
            bool isGreater = obj3(20);
            Console.WriteLine(isGreater);
            Console.Read();

        }
    }
}
