using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateAndThread
{
    class SomeClass
    {
        public delegate void Sender(int i);
        public Sender sender = null;

        public void HugeProcess()
        {
            for(int i = 0; i < 500; i++)
            {
                Thread.Sleep(500);
                sender(i);
            }
        }
    }
}
