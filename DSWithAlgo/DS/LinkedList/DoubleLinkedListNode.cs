namespace DSWithAlgo.DS.LinkedList
{
    public class DoubleLinkedListNode<T>
    {
        public DoubleLinkedListNode(T data) => Data = data;

        public T Data { get; }
        public DoubleLinkedListNode<T>? Next { get; set; }
        public DoubleLinkedListNode<T>? Previous { get; set; }
    }
}