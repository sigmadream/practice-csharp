using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSWithAlgo.DS.Queue
{
    public class LinkedListQueue<T>
    {
        private readonly LinkedList<T> queue;
        public LinkedListQueue() => queue = new LinkedList<T>();

        public void Enqueue(T item)
        {
            queue.AddLast(item);
        }

        public T Dequeue()
        {
            if (queue.First == null)
            {
                throw new InvalidOperationException("There are no item in the queue.");
            }

            var item = queue.First;
            queue.RemoveFirst();
            return item.Value;
        }

        public T Peek()
        {
            if (queue.First is null)
            {
                throw new InvalidOperationException("There are no items in the queue.");
            }

            return queue.First.Value;
        }

        public bool IsEmpty() => !queue.Any();
    }
}
