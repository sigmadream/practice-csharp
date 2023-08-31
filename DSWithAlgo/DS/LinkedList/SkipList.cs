namespace DSWithAlgo.DS.LinkedList
{
  public class SkipList<T>
  {
    private const double Probability = 0.5;
    private readonly int maxLevels;
    private readonly SkipListNode<T> head;
    private readonly SkipListNode<T> tail;
    private readonly Random random = new Random();

    public SkipList(int capacity = 255)
    {
      maxLevels = (int)Math.Log2(capacity) + 1;

      head = new(int.MinValue, default(T), maxLevels);
      tail = new(int.MaxValue, default(T), maxLevels);

      for (int i = 0; i < maxLevels; i++)
      {
        head.Next[i] = tail;
      }
    }

    public int Count { get; private set; }

    public T this[int key]
    {
      get
      {
        var previousNode = GetSkipNodes(key).First();
        if (previousNode.Next[0].Key == key)
        {
          return previousNode.Next[0].Value!;
        }
        else
        {
          throw new KeyNotFoundException();
        }
      }

      set => AddOrUpdate(key, value);
    }

    public void AddOrUpdate(int key, T value)
    {
      var skipNodes = GetSkipNodes(key);

      var previousNode = skipNodes.First();
      if (previousNode.Next[0].Key == key)
      {
        previousNode.Next[0].Value = value;
        return;
      }

      var newNode = new SkipListNode<T>(key, value, GetRandomHeight());
      for (var level = 0; level < newNode.Height; level++)
      {
        newNode.Next[level] = skipNodes[level].Next[level];
        skipNodes[level].Next[level] = newNode;
      }

      Count++;
    }

    public bool Contains(int key)
    {
      var previousNode = GetSkipNodes(key).First();
      return previousNode.Next[0].Key == key;
    }

    public bool Remove(int key)
    {
      var skipNodes = GetSkipNodes(key);
      var previousNode = skipNodes.First();
      if (previousNode.Next[0].Key != key)
      {
        return false;
      }

      var nodeToRemove = previousNode.Next[0];
      for (var level = 0; level < nodeToRemove.Height; level++)
      {
        skipNodes[level].Next[level] = nodeToRemove.Next[level];
      }

      Count--;

      return true;
    }

    public IEnumerable<T> GetValues()
    {
      var current = head.Next[0];
      while (current.Key != tail.Key)
      {
        yield return current.Value!;
        current = current.Next[0];
      }
    }

    private SkipListNode<T>[] GetSkipNodes(int key)
    {
      var skipNodes = new SkipListNode<T>[maxLevels];
      var current = head;
      for (var level = head.Height - 1; level >= 0; level--)
      {
        while (current.Next[level].Key < key)
        {
          current = current.Next[level];
        }

        skipNodes[level] = current;
      }

      return skipNodes;
    }

    private int GetRandomHeight()
    {
      int height = 1;
      while (random.NextDouble() < Probability && height < maxLevels)
      {
        height++;
      }

      return height;
    }
  }

}