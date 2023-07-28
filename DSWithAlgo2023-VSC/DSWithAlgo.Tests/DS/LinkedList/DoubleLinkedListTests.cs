using Xunit;
using DSWithAlgo.DS.LinkedList;
using System.Linq;

namespace DSWithAlgo.Tests.LinkedList
{
    public static class DoubleLinkedListTests
    {
        [Fact]
        public static void TestAdd()
        {
            var dll = new DoubleLinkedList<int>(0);
            var one = dll.Add(1);
            dll.Add(3);
            dll.Add(4);
            dll.AddAfter(2, one);

            var arr = dll.GetData().ToArray();

            Assert.Equal(5, dll.Count);
            Assert.Equal(new[] { 0, 1, 2, 3, 4 }, arr);
        }
    }
}