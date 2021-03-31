using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionBetweenMerchantAndCustomer
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operation1 = new Operations();
            printCustomerAndMerchantInfo();
            Transaction();
            printCustomerAndMerchantInfo();
           
            Console.Read();
        }

        public static void printCustomerAndMerchantInfo()
        {
            Operations o1 = new Operations();
            List<Merchant> list1 = o1.getTable();
            Console.WriteLine("\nMerchant list:");
            foreach (Merchant i in list1)
            {
                Console.WriteLine(i.fullInfo);
            }
            List<Customer> custlist = o1.getCustomers();
            Console.WriteLine("\nCustomer list:");
            foreach (Customer i in custlist)
            {
                Console.WriteLine(i.fullInfo);
            }
        }

        public static void Transaction()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Operations o1 = new Operations();
            Console.Write("Enter Your id:");
            int custid = int.Parse(Console.ReadLine());
            Console.Write("Enter Merchant Id:");
            int merchantid = int.Parse(Console.ReadLine());
            Console.Write("Enter Amt:");
            double amt = double.Parse(Console.ReadLine());
            bool issuccessfull = o1.transaction(custid, merchantid, amt);
            if (issuccessfull)
            {
                Console.WriteLine("---Transaction Successfull!---");
            }
            else
            {
                Console.WriteLine("---Operation Declined");
            }
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
