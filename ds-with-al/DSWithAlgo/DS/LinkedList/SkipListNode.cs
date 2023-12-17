namespace DSWithAlgo.DS.LinkedList
{
  internal class SkipListNode<T>
  {
    public SkipListNode(int key, T? value, int height)
    {
      Key = key;
      Value = value;
      Height = height;
      Next = new SkipListNode<T>[height];
    }

    public int Key { get; }

    public T? Value { get; set; }

    public SkipListNode<T>[] Next { get; }

    public int Height { get; }
  }
}