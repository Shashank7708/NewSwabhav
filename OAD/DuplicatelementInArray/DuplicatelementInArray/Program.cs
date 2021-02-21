using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicatelementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] FindDuplicate = { 1, 2, 3, 4, 5, 1, 3 };
            for (int i= 0; i < FindDuplicate.Length - 1;i++)
            {
                for(int j = i + 1; j< FindDuplicate.Length; j++)
                {
                    try
                    {
                        if (FindDuplicate[i] == FindDuplicate[j])
                        {
                            Console.WriteLine(FindDuplicate[j]);
                        }
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
