namespace DSWithAlgo.DS.LinkedList
{
    public class SingleLinkedListNode<T>
    {
        public SingleLinkedListNode(T data)
        {
            Data = data;
            Next = null;
        }

        public T Data { get; }
        public SingleLinkedListNode<T>? Next { get; set; }
    }
}