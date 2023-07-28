namespace DSWithAlgo.DS.LinkedList
{
    public class DoubleLinkedList<T>
    {
        public DoubleLinkedList(T data)
        {
            Head = new DoubleLinkedListNode<T>(data);
            Tail = Head;
            Count = 1;
        }

        public int Count { get; private set; }
        private DoubleLinkedListNode<T>? Head { get; set; }
        private DoubleLinkedListNode<T>? Tail { get; set; }

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
    }
}
