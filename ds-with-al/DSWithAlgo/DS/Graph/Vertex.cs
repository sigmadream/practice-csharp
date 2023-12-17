namespace DSWithAlgo.DS.Graph
{
  public class Vertex<T>
  {
    public T Data { get; }

    public int Index { get; }

    public DirectedWeightedGraph<T>? Graph { get; private set; }
    public Vertex(T data, int index, DirectedWeightedGraph<T>? graph)
    {
      Data = data;
      Index = index;
      Graph = graph;
    }

    public Vertex(T data, int index)
    {
      Data = data;
      Index = index;
    }

    public void SetGraphNull() => Graph = null;

    public override string ToString() => $"Data: {Data}, Index: {Index}";
  }
}