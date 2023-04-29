namespace DSWithAlgo.DS.LinkedList.SingleLinkedList
{
    public class SingleLinkedListNode
    {
        public SingleLinkedListNode(int data)
        {
            Data = data;
            Next = null;
        }

        public int Data { get; }
        public SingleLinkedListNode? Next { get; set; }
    }
}