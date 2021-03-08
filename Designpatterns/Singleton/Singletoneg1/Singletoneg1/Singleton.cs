using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletoneg1
{
    class Singleton
    {
        static Singleton inst = null;
        public Singleton() { }
        public static Singleton instanceOfSingleton { get 
            {
                if (inst == null)
                {
                    inst = new Singleton();
                }
                return inst; } }
        public void Dosomething()
        {
            Console.WriteLine("Singleton class inst is called");
        }
    }
}
