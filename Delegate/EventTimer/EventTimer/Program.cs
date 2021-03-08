using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace EventTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer mytimer = new Timer(2000);
            mytimer.Elapsed += ElepsedEvent;
            mytimer.Elapsed += ElepsedEvent1;
            mytimer.Start();
           
            Console.WriteLine("Enter any key to remove a event");
            Console.ReadLine();
            mytimer.Elapsed -= ElepsedEvent;
            
            Console.ReadLine();
        }

        private static void ElepsedEvent1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Event2:Event 2 has Occured");
        }

        private static void ElepsedEvent(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Event1:{0:hh:mm:ss:ff}", e.SignalTime);
        }

    }
}
