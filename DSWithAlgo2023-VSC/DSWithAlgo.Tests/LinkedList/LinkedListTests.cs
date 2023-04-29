using Xunit;
using DSWithAlgo.DS.LinkedList.SingleLinkedList;

namespace DSWithAlgo.Tests.LinkedList
{
    public static class LinkedListTests
    {
        [Fact]
        public static void Add()
        {
            var a = new SingleLinkedList();
            a.AddLast(1);
            a.AddLast(15);
            a.AddLast(30);
            Assert.Equal(3, a.Length());
        }
    }
}