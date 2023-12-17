using DSWithAlgo.DS.Exceptions;

namespace DSWithAlgo.DS.LinkedList
{
    public class DoubleLinkedList<T>
    {
        public int Count { get; private set; }
        private DoubleLinkedListNode<T>? Head { get; set; }
        private DoubleLinkedListNode<T>? Tail { get; set; }
        public bool Contains(T data) => IndexOf(data) != -1;

        public DoubleLinkedList(T data)
        {
            Head = new DoubleLinkedListNode<T>(data);
            Tail = Head;
            Count = 1;
        }

        public DoubleLinkedList(IEnumerable<T> data)
        {
            foreach (var d in data)
            {
                Add(d);
            }
        }

        public DoubleLinkedListNode<T> AddHead(T data)
        {
            var node = new DoubleLinkedListNode<T>(data);

            if (Head is null)
            {
                Head = node;
                Tail = node;
                Count = 1;
                return node;
            }

            Head.Previous = node;
            node.Next = Head;
            Head = node;
            Count++;
            return node;
        }

        public DoubleLinkedListNode<T> Add(T data)
        {
            var node = new DoubleLinkedListNode<T>(data);

            if (Head is null)
            {
                return AddHead(data);
            }

            Tail!.Next = node;
            node.Previous = Tail;
            Tail = node;
            Count++;
            return node;
        }

        public DoubleLinkedListNode<T> AddAfter(T data, DoubleLinkedListNode<T> existingNode)
        {
            if (existingNode == Tail)
            {
                return Add(data);
            }

            var node = new DoubleLinkedListNode<T>(data);
            node.Next = existingNode.Next;
            node.Previous = existingNode;
            existingNode.Next = node;

            if (node.Next is not null)
            {
                node.Next.Previous = node;
            }

            Count++;
            return node;
        }

        public IEnumerable<T> GetData()
        {
            var current = Head;
            while (current is not null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public IEnumerable<T> GetDataReversed()
        {
            var current = Tail;
            while (current is not null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }

        public DoubleLinkedListNode<T> Find(T data)
        {
            var current = Head;
            while (current is not null)
            {
                if (current.Data is null && data is null || current.Data is not null && current.Data.Equals(data))
                {
                    return current;
                }

                current = current.Next;
            }
            throw new ItemNotFoundException();
        }

        public DoubleLinkedListNode<T> GetAt(int position)
        {
            if (position < 0 || position >= Count)
            {
                throw new ArgumentOutOfRangeException($"Max count is {Count}");
            }

            var current = Head;
            for (var i = 0; i < position; i++)
            {
                current = current!.Next;
            }

            return current ?? throw new ArgumentOutOfRangeException($"{nameof(position)} is not found");
        }

        public int IndexOf(T data)
        {
            var current = Head;
            var index = 0;
            while (current is not null)
            {
                if (current.Data is null && data is null || current.Data is not null && current.Data.Equals(data))
                {
                    return index;
                }

                index++;
                current = current.Next;

            }
            return -1;
        }


        public void RemoveHead()
        {
            if (Head is null)
            {
                throw new InvalidOperationException();
            }

            Head = Head.Next;

            if (Head is null)
            {
                Tail = null;
                Count = 0;
                return;
            }

            Head.Previous = null;
            Count--;
        }

        public void Remove()
        {
            if (Tail is null)
            {
                throw new InvalidOperationException();
            }

            Tail = Tail.Previous;
            if (Tail is null)
            {
                Head = null;
                Count = 0;
                return;
            }

            Tail.Next = null;
            Count--;
        }


        public void RemoveNode(DoubleLinkedListNode<T> node)
        {
            if (node == Head)
            {
                RemoveHead();
                return;
            }

            if (node == Tail)
            {
                Remove();
                return;
            }

            if (node.Previous is null || node.Next is null)
            {
                throw new ArgumentException();
            }

            node.Previous.Next = node.Next;
            node.Next.Previous = node.Previous;
            Count--;
        }
    }
}
