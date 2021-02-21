using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByValueString
{
    class Program
    {
        static void Main(string[] args)
        { string str1 = "World";
  
            SplitStr(str1);
            Console.WriteLine(str1);
            Console.ReadLine();

        }

        static void SplitStr(string str1)
        {
            
            str1 = "India";

        }

    }
}
