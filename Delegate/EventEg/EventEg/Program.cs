using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventEg
{
    public delegate void DCalculateAlert(int x, int y, int answer);
   
    class Program
    {
        
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.AditionCompleted += PrintDetails;
            c.Add(10, 20,1);
            Console.Read();


        }
        public static void PrintDetails(int x,int y,int result)
        {
            Console.WriteLine("Addition of {0} and {1}:",x,y);
            Console.WriteLine("{0}", result);
        }

    }
}
