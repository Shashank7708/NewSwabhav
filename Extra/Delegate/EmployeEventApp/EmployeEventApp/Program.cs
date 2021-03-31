using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace EmployeEventApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FetchDataFromWebsite webpage1 = new FetchDataFromWebsite();
            webpage1.FetchDataEvent += EvetOccured;
            webpage1.FetchDataFromWebPage("https://swabhav-tech.firebaseapp.com/emp.txt");


            Console.ReadLine();
        }

       public static void EvetOccured(string text)
        {   
            Console.WriteLine("Congrulation! You have fetch the Data from Website\n");

            Console.WriteLine(text);
        }
    }
}
