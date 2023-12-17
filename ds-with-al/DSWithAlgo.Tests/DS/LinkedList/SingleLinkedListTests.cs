using Xunit;
using DSWithAlgo.DS.LinkedList;
using System.Linq;


namespace DSWithAlgo.Tests.LinkedList
{
    public class LinkedListTests
    {
        private SingleLinkedList<string> ll = new SingleLinkedList<string>();
        private SingleLinkedList<int> ll2 = new SingleLinkedList<int>();

        [Fact]
        public void TestAddLast()
        {

            ll.AddLast("X");
            ll.AddLast("Y");
            ll.AddLast("Z");
            Assert.Equal(3, ll.Length());

            ll2.AddLast(1);
            ll2.AddLast(2);
            ll2.AddLast(3);
            ll2.AddLast(4);
            Assert.Equal(4, ll2.Length());
        }

        [Fact]
        public void TestAddFirst()
        {

            ll.AddLast("1");
            ll.AddLast("2");
            ll.AddLast("3");
            ll.AddLast("4");
            Assert.Equal(4, ll.Length());

            ll2.AddFirst(1);
            ll2.AddFirst(15);
            Assert.Equal(2, ll2.Length());
        }

        [Fact]
        public void TestGetListData()
        {
            ll.AddLast("X");
            ll.AddLast("Y");
            ll.AddLast("Z");

            var items = ll.GetListData();

            Assert.Equal(3, items.Count());
            Assert.Equal("Y", ll.Index(1));
        }

        [Fact]
        public void Delete()
        {
            ll2.AddFirst(1);
            ll2.AddFirst(2);
            ll2.AddFirst(3);

            var result = ll2.Delete(2);

            Assert.True(result);
        }
    }
}