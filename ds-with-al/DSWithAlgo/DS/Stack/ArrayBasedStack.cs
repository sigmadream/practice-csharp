namespace DSWithAlgo.DS.Stack
{
  public class ArrayBasedStack<T>
  {
    private const int DefaultCapacity = 10;
    private const string StackEmptyErrorMessage = "Stack is empty";
    private T[] stack;
    private int top;
    public int Top => top;
    public bool Contains(T item) => Array.IndexOf(stack, item, 0, top + 1) > -1;

    public ArrayBasedStack()
    {
      stack = new T[DefaultCapacity];
      top = -1;
    }

    public ArrayBasedStack(T item)
        : this() => Push(item);

    public ArrayBasedStack(T[] items)
    {
      stack = items;
      top = items.Length - 1;
    }

    public int Capacity
    {
      get => stack.Length;
      set => Array.Resize(ref stack, value);
    }

    public void Clear()
    {
      top = -1;
      Capacity = DefaultCapacity;
    }

    public T Peek()
    {
      if (top == -1)
      {
        throw new InvalidOperationException(StackEmptyErrorMessage);
      }
      return stack[top];
    }

    public T Pop()
    {
      if (top == -1)
      {
        throw new InvalidOperationException(StackEmptyErrorMessage);
      }
      return stack[top--];
    }

    public void Push(T item)
    {
      if (top == Capacity - 1)
      {
        Capacity *= 2;
      }

      stack[++top] = item;
    }
  }
}