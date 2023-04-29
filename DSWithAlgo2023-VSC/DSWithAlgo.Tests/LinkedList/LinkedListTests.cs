using Xunit;
using DSWithAlgo.DS.LinkedList.SingleLinkedList;

namespace DSWithAlgo.Tests.LinkedList
{
    public static class LinkedListTests
    {
        [Fact]
        public static void AddLast()
        {
            var ll = new SingleLinkedList<string>();
            ll.AddLast("X");
            ll.AddLast("Y");
            ll.AddLast("Z");
            Assert.Equal(3, ll.Length());

            var ll2 = new SingleLinkedList<int>();
            ll2.AddLast(1);
            ll2.AddLast(2);
            ll2.AddLast(3);
            ll2.AddLast(4);
            Assert.Equal(4, ll2.Length());
        }

        [Fact]
        public static void AddFirst()
        {
            var ll = new SingleLinkedList<int>();
            ll.AddFirst(1);
            ll.AddFirst(15);
            Assert.Equal(2, ll.Length());

            var ll2 = new SingleLinkedList<string>();
            ll2.AddLast("1");
            ll2.AddLast("2");
            ll2.AddLast("3");
            ll2.AddLast("4");
            Assert.Equal(4, ll2.Length());
        }

        [Fact]
        public static void GetData()
        {
            var ll = new SingleLinkedList<string>();
            ll.AddLast("X");
            ll.AddLast("Y");
            ll.AddLast("Z");

            Assert.Equal("Y", ll.Index(1));
        }

        [Fact]
        public static void Delete()
        {
            var ll = new SingleLinkedList<int>();
            ll.AddFirst(1);
            ll.AddFirst(2);
            ll.AddFirst(3);

            var result = ll.Delete(2);
            Assert.True(result);
        }
    }
}