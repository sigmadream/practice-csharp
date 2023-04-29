namespace DSWithAlgo.DS.LinkedList.SingleLinkedList
{
    public class SingleLinkedList
    {
        private SingleLinkedListNode? Head { get; set; }
        public SingleLinkedListNode AddLast(int data)
        {
            var newNode = new SingleLinkedListNode(data);
            if (Head is null)
            {
                Head = newNode;
                return newNode;
            }

            var tempNode = Head;

            while (tempNode.Next is not null)
            {
                tempNode = tempNode.Next;
            }

            tempNode.Next = newNode;
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
    }

}