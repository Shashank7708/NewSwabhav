using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedDeposit
{
    class Program
    {
        static void Main(string[] args)
        {
            IFixedDeposit holifixed1 = new HoliFixedDeposit(101, "Rahul", 5000, 2, FestivalType.holi);
            IFixedDeposit diwalifixed2 = new DiwaliFixedDeposit(102, "Romy", 5000, 2, FestivalType.diwali);
            IFixedDeposit normalfixed = new NormalFixedDeposit(103, "Sumit", 5000, 2, FestivalType.normal);

           
            
            PrintInfo(normalfixed);
            PrintInfo(diwalifixed2);
            PrintInfo(holifixed1);
            Console.Read();
        }

        

        static void PrintInfo(IFixedDeposit fd)
        {
            Console.WriteLine("AccountNo: " + fd.getAccno + "\nName: " + fd.getName + "\nPrincipal: " + fd.getPrincipa);
           Console.WriteLine("RateOfInterest: "+(int) fd.getFestival+"\nInterest Amount: " + fd.CalculateFixedDeposit());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Final Amount: " + fd.GetFinalAmount+"\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    enum FestivalType
    {
        normal=4,
        diwali=9,
        holi=6


    }
}
