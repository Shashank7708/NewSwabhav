using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AdapterTestQueue
{
   class QueueAdapter<T> : IQueue<T>, IEnumerator<T> 
    {
        LinkedList<T> _queue;
        public QueueAdapter()
        {
            this._queue = new LinkedList<T>();
        }

        void IQueue<T>.Enqueue(T item)
        {
            _queue.AddLast(item);
        }

        
        T IQueue<T>.Dequeue()
        {
            T a= _queue.Last.Value;
            _queue.RemoveLast();
            return a;
        }

       int IQueue<T>.Count { get { return _queue.Count; } }

        public T Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        IEnumerable<T> GetItem()
        {
           IEnumerable<T> itemlist = (IEnumerable<T>)_queue;
            return itemlist;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
          return  _queue.GetEnumerator() ;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

       
    }
}
