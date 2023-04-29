using System.Collections;

namespace DSWithAlgo.DS.LinkedList.SingleLinkedList
{
    public class SingleLinkedList<T>
    {
        private SingleLinkedListNode<T>? Head { get; set; }
        private SingleLinkedListNode<T>? Tail { get; set; }
        public SingleLinkedListNode<T> AddLast(T data)
        {
            var newNode = new SingleLinkedListNode<T>(data);

            if (Head is null)
            {
                Head = newNode;
                Tail = newNode;
                return newNode;
            }

            Tail!.Next = newNode;
            Tail = newNode;
            return newNode;
        }
        public SingleLinkedListNode<T> AddFirst(T data)
        {
            var newNode = new SingleLinkedListNode<T>(data)
            {
                Next = Head
            };

            Head = newNode;
            return newNode;

        }
        public int Length()
        {
            if (Head is null)
            {
                return 0;
            }

            var tempNode = Head;
            var length = 1;

            while (tempNode.Next is not null)
            {
                tempNode = tempNode.Next;
                length = length + 1;
            }

            return length;
        }
        public IEnumerable<T> GetData()
        {
            var tempNode = Head;
            while (tempNode is not null)
            {
                yield return tempNode.Data;
                tempNode = tempNode.Next;
            }
        }
        public T Index(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            var tempNode = Head;

            for (var i = 0; tempNode is not null && i < index; i++)
            {
                tempNode = tempNode.Next;
            }

            if (tempNode is null)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            return tempNode.Data;
        }
        public bool Delete(T data)
        {
            var currentNode = Head;
            SingleLinkedListNode<T>? preNode = null;
            while (currentNode is not null)
            {
                if (currentNode.Data is null && data is null ||
                    currentNode.Data is not null && currentNode.Data.Equals(data))
                {
                    if (currentNode.Equals(Head))
                    {
                        Head = Head.Next;
                        return true;
                    }
                    if (preNode is not null)
                    {
                        preNode.Next = currentNode.Next;
                        return true;
                    }
                }

                preNode = currentNode;
                currentNode = currentNode.Next;
            }
            return false;
        }

    }

}