using Xunit;
using DSWithAlgo.DS.LinkedList;
using System.Linq;
using System;

namespace DSWithAlgo.Tests.LinkedList
{
    public class DoubleLinkedListTests
    {
        private DoubleLinkedList<int> dll = new DoubleLinkedList<int>(new[] { 0, 1, 2, 3, 4 });

        [Fact]
        public void TestAdd()
        {
            var dllSingle = new DoubleLinkedList<int>(0);
            var one = dllSingle.Add(1);
            dllSingle.Add(3);
            dllSingle.Add(4);
            dllSingle.AddAfter(2, one);

            var arr = dllSingle.GetData().ToArray();
            var rArr = dllSingle.GetDataReversed().ToArray();

            Assert.Equal(5, dllSingle.Count);
            Assert.Equal(new[] { 0, 1, 2, 3, 4 }, arr);
            Assert.Equal(new[] { 4, 3, 2, 1, 0 }, rArr);
        }

        [Fact]
        public void TestFind()
        {
            var one = dll.Find(1);
            var four = dll.Find(4);

            Assert.Equal(1, one.Data);
            Assert.Equal(4, four.Data);
        }

        [Fact]
        public void TestIndexOf()
        {
            var one = dll.IndexOf(1);
            var four = dll.IndexOf(4);

            Assert.Equal(1, one);
            Assert.Equal(4, four);
        }

        [Fact]
        public void TestContains()
        {
            var one = dll.Contains(1);
            var five = dll.Contains(5);

            Assert.True(one);
            Assert.False(five);

        }

        [Fact]
        public void TestGetAt()
        {
            var one = dll.GetAt(1);
            var four = dll.GetAt(4);

            Assert.Equal(1, one.Data);
            Assert.Equal(4, four.Data);

            Assert.Throws<ArgumentOutOfRangeException>(() => dll.GetAt(-1));
            Assert.Throws<ArgumentOutOfRangeException>(() => dll.GetAt(5));
        }

        [Fact]
        public void TestRemove()
        {
            dll.RemoveHead();
            dll.Remove();
            dll.RemoveNode(dll.Find(2));

            var arr = dll.GetData().ToArray();
            var rArr = dll.GetDataReversed().ToArray();

            Assert.Equal(2, dll.Count);
            Assert.Equal(new[] { 1, 3 }, arr);
            Assert.Equal(new[] { 3, 1 }, rArr);

        }

    }
}