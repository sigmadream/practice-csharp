namespace DSWithAlgo.DS.Stack
{
  public class LinkedListBasedStack<T>
  {
    private readonly LinkedList<T> stack;

    public LinkedListBasedStack() => stack = new LinkedList<T>();

    public LinkedListBasedStack(T item) : this() => Push(item);

    public void Push(T item) => stack.AddFirst(item);

    public int Count => stack.Count;

    public void Clear() => stack.Clear();

    public bool Contains(T item) => stack.Contains(item);

    public LinkedListBasedStack(IEnumerable<T> items) : this()
    {
      foreach (var item in items)
      {
        Push(item);
      }
    }

    public T Peek()
    {
      if (stack.First is null)
      {
        throw new InvalidOperationException("Stack is empty");
      }
      return stack.First.Value;
    }

    public T Pop()
    {
      if (stack.First is null)
      {
        throw new InvalidOperationException("Stack is empty");
      }
      var item = stack.First.Value;
      stack.RemoveFirst();
      return item;
    }
  }
}