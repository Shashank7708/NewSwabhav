using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdapterTestQueue
{
    interface IQueue <T> : IEnumerable<T>
    {
        void Enqueue(T item);
        T Dequeue();
        int Count { get; }

    }
}
