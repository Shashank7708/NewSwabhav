using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountProxy a = new AccountProxy("101", "Rahul", 400);
            a.Deposit(500);
            Console.Read();
        }
    }
}
