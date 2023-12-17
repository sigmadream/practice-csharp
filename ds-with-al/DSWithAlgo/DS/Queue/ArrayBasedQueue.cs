namespace DSWithAlgo.DS.Queue
{
  public class ArrayBasedQueue<T>
  {
    private readonly T[] queue;
    private int endIndex;
    private bool isEmpty;
    private bool isFull;
    private int startIndex;

    public ArrayBasedQueue(int capacity)
    {
      queue = new T[capacity];
      Clear();
    }

    public void Clear()
    {
      startIndex = 0;
      endIndex = 0;
      isEmpty = true;
      isFull = false;
    }

    public T Dequeue()
    {
      if (IsEmpty())
      {
        throw new InvalidOperationException("There are no items in the queue.");
      }

      var dequeueIndex = endIndex;
      endIndex++;
      if (endIndex >= queue.Length)
      {
        endIndex = 0;
      }

      isFull = false;
      isEmpty = startIndex == endIndex;

      return queue[dequeueIndex];
    }

    public bool IsEmpty() => isEmpty;

    public bool IsFull() => isFull;

    public T Peek()
    {
      if (IsEmpty())
      {
        throw new InvalidOperationException("There are no items in the queue.");
      }

      return queue[endIndex];
    }

    public void Enqueue(T item)
    {
      if (IsFull())
      {
        throw new InvalidOperationException("The queue has reached its capacity.");
      }

      queue[startIndex] = item;

      startIndex++;
      if (startIndex >= queue.Length)
      {
        startIndex = 0;
      }

      isEmpty = false;
      isFull = startIndex == endIndex;
    }
  }

}