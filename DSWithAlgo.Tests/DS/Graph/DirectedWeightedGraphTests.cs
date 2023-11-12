using DSWithAlgo.DS.Graph;
using Xunit;
using System.Linq;


namespace DSWithAlgo.Tests.Graph
{
  public class DirectedWeightedGraphTests
  {
    [Fact]
    public void GraphAddVertexTest()
    {
      var graph = new DirectedWeightedGraph<char>(10);

      graph.AddVertex('A');
      graph.AddVertex('B');
      graph.AddVertex('C');

      Assert.Equal(3, graph.Count);
    }

    [Fact]
    public void GraphAddEdge()
    {
      var graph = new DirectedWeightedGraph<char>(10);
      var vertexA = graph.AddVertex('A');
      var vertexB = graph.AddVertex('B');
      var vertexC = graph.AddVertex('C');

      graph.AddEdge(vertexA, vertexB, 5);

      Assert.True(graph.IsAdjacent(vertexA, vertexB));
      Assert.False(graph.IsAdjacent(vertexA, vertexC));
    }

    [Fact]
    public void GraphRemoveVertex()
    {
      var graph = new DirectedWeightedGraph<char>(10);
      var vertexA = graph.AddVertex('A');
      var vertexB = graph.AddVertex('B');
      var vertexC = graph.AddVertex('C');
      graph.AddEdge(vertexB, vertexA, 5);
      graph.AddEdge(vertexC, vertexA, 5);
      var neighborsB = graph.GetNeighbors(vertexB).ToList();
      var neighborsC = graph.GetNeighbors(vertexC).ToList();

      graph.RemoveVertex(vertexA);

      Assert.Single(neighborsB);
      Assert.Single(neighborsC);
    }

    [Fact]
    public void GraphGetNeighborsTest()
    {
      var graph = new DirectedWeightedGraph<char>(10);
      var vertexA = graph.AddVertex('A');
      var vertexB = graph.AddVertex('B');
      var vertexC = graph.AddVertex('C');
      var vertexD = graph.AddVertex('D');
      graph.AddEdge(vertexA, vertexB, 5);
      graph.AddEdge(vertexA, vertexC, 5);
      graph.AddEdge(vertexA, vertexD, 5);

      var neighborsA = graph.GetNeighbors(vertexA).ToList();

      Assert.Equal(3, neighborsA.Count);
      Assert.Equal(vertexB, neighborsA[0]);
      Assert.Equal(vertexC, neighborsA[1]);
      Assert.Equal(vertexD, neighborsA[2]);
    }

    [Fact]
    public void GraphRemoveEdge()
    {
      var graph = new DirectedWeightedGraph<char>(10);

      var vertexA = graph.AddVertex('A');
      var vertexB = graph.AddVertex('B');

      graph.AddEdge(vertexB, vertexA, 5);
      Assert.True(graph.IsAdjacent(vertexB, vertexA));
      Assert.False(graph.IsAdjacent(vertexA, vertexB));

      graph.RemoveEdge(vertexB, vertexA);
      Assert.False(graph.IsAdjacent(vertexB, vertexA));
      Assert.False(graph.IsAdjacent(vertexA, vertexB));
    }
  }
}