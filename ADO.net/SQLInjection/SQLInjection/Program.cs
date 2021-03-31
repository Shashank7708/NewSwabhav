using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operation = new Operations();
            char c = 'a';



            while (c == 'a')
            {
                try
                {
                    Console.WriteLine("Enter id:");

                    var id = int.Parse(Console.ReadLine());
                    //  Console.Write("Enter username:");
                    // string username = Console.ReadLine();
                    //Console.Write("Enter Password");
                    //string password = Console.ReadLine();
                    List<Department> deptlist = operation.GetData(id);
                    foreach (Department i in deptlist)
                    {
                        Console.WriteLine(i.FULLINFO);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Input");
                    
                }

                
                Console.WriteLine("\nEnter 'a' to continue");
                c = char.Parse(Console.ReadLine());
            }    
               
            Console.ReadLine();

        }
    }
}
