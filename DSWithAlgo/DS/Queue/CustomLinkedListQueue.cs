using DSWithAlgo.DS.LinkedList;

namespace DSWithAlgo.DS.Queue
{
    public class CustomLinkedListQueue<T>
    {
        private readonly SingleLinkedList<T> queue;
        public CustomLinkedListQueue() => queue = new SingleLinkedList<T>();

        public void Enqueue(T item)
        {
            queue.AddLast(item);
        }

        public T Dequeue()
        {

            if (queue.GetListData() is null)
            {
                throw new InvalidOperationException("There are no item in the queue.");
            }

            var item = queue.GetListData().First();
            queue.Delete(item);
            return item;
        }

        public T Peek()
        {
            if (queue.GetListData() is null)
            {
                throw new InvalidOperationException("There are no items in the queue.");
            }

            return queue.GetListData().First();
        }

        public bool IsEmpty() => !queue.GetListData().Any();
    }
}
