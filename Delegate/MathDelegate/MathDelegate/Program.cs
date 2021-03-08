using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDelegate
{
    public delegate void DelegateApp(int a, int b);
    class Program
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Add:" + (a + b));
        }

        public static void Subtract(int a, int b)
        {
            Console.WriteLine("Subtract:" + (a - b));
        }

        public static void Division(int a, int b)
        {
            Console.WriteLine("Division:" + (a - b));
        }

       
        static void Main(string[] args)
        {
            DelegateApp d = Add;
            d(10, 20);
            d= Subtract;
            d(20, 10);
            d = Division;
            d(20, 10);
            Delegatearray();
           
            
            Console.Read();
            
        }
        public static void Case2(DelegateApp f)
        {
            Console.WriteLine("Case 2");
            f(20, 10);
        }
        public static void Delegatearray()
        {
            DelegateApp[] d = new DelegateApp[3];
            d[0] = Add;
            d[1] = Subtract;
            d[2] = Division;
            for(int i = 0; i < 3; i++)
            {
                Case2((d[i]));
            }
        }
        
    }
}
