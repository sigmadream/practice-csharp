namespace DSWithAlgo.DS.Queue
{
    public class StackQueue<T>
    {
        private readonly Stack<T> input;
        private readonly Stack<T> output;

        public StackQueue()
        {
            input = new Stack<T>();
            output = new Stack<T>();
        }

        public void Enqueue(T item) => input.Push(item);

        public T Dequeue()
        {
            if (input.Count == 0 && output.Count == 0)
            {
                throw new InvalidOperationException("The queue contains no item");
            }

            if (output.Count == 0)
            {
                while (input.Count > 0)
                {
                    var item = input.Pop();
                    output.Push(item);
                }
            }

            return output.Pop();
        }

        public bool IsEmpty() => input.Count == 0 && output.Count == 0;

        public T Peek()
        {
            if (input.Count == 0 && output.Count == 0)
            {
                throw new InvalidOperationException("The queue contains no item");
            }

            if (output.Count == 0)
            {
                while (input.Count > 0)
                {
                    var item = input.Pop();
                    output.Push(item);
                }
            }

            return output.Peek();
        }

        public void Clear()
        {
            input.Clear();
            output.Clear();
        }

    }
}