using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamTrial
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arr =new object[]{ "Rama", 'a', 23, 34.5, 645.00005 };
            ObjectShow(arr);
            Show("Rama", 'a', 23, 34.5,645.00005);
            Console.ReadLine();
        }
        static void ObjectShow(object[] show)
        {
            for(int i = 0; i < show.Length; i++)
            {
                Console.WriteLine(show[i]);
            }
        }
        static void Show(params object[] RandomData)
        {
            foreach(var i in RandomData)
            {
                Console.WriteLine(i);
            }
        }
    }
}
