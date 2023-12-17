namespace DSWithAlgo.DS.Graph
{
    public class DirectedWeightedGraph<T>
    {
        private readonly int capacity;
        private readonly double[,] adjacencyMatrix;
        public Vertex<T>?[] Vertices { get; private set; }
        public int Count { get; private set; }
        public DirectedWeightedGraph(int capacity)
        {
            this.capacity = capacity;
            Vertices = new Vertex<T>[capacity];
            adjacencyMatrix = new double[capacity, capacity];
            Count = 0;
        }
        public Vertex<T> AddVertex(T data)
        {
            var vertex = new Vertex<T>(data, Count, this);
            Vertices[Count] = vertex;
            Count++;
            return vertex;
        }

        public void AddEdge(Vertex<T> startVertex, Vertex<T> endVertex, double weight)
        {
            var currentEdgeWeight = adjacencyMatrix[startVertex.Index, endVertex.Index];
            adjacencyMatrix[startVertex.Index, endVertex.Index] = weight;
        }

        public void RemoveVertex(Vertex<T> vertex)
        {
            Vertices[vertex.Index] = null;
            vertex.SetGraphNull();

            for (var i = 0; i < Count; i++)
            {
                adjacencyMatrix[i, vertex.Index] = 0;
                adjacencyMatrix[vertex.Index, i] = 0;
            }

            Count--;
        }

        public IEnumerable<Vertex<T>?> GetNeighbors(Vertex<T> vertex)
        {
            for (var i = 0; i < Count; i++)
            {
                if (adjacencyMatrix[vertex.Index, i] != 0)
                {
                    yield return Vertices[i];
                }
            }
        }
        public bool IsAdjacent(Vertex<T> startVertex, Vertex<T> endVertex)
        {
            return adjacencyMatrix[startVertex.Index, endVertex.Index] != 0;
        }

        public void RemoveEdge(Vertex<T> startVertex, Vertex<T> endVertex)
        {
            adjacencyMatrix[startVertex.Index, endVertex.Index] = 0;
        }
    }
}