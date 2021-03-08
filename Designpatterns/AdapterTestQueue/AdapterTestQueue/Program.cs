using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterTestQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueue<int> q = new QueueAdapter<int>();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(50);
            q.Enqueue(70);
            Console.WriteLine("Count:"+q.Count);
            Console.WriteLine("Dequeue:"+q.Dequeue());
            Console.WriteLine("Dequeue:" + q.Dequeue());
            Console.WriteLine("Count:"+q.Count);
            Console.WriteLine("Elements:");
            foreach(int i in q)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
