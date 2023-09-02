using System.Linq;
using DSWithAlgo.DS.Stack;
using Xunit;

namespace DSWithAlgo.Tests.DS.Stack
{
    public class ListBasedStackTests
    {
        [Fact]
        public void CountTest()
        {
            var stack = new LinkedListBasedStack<int>(new[] { 0, 1, 2, 3, 4 });
            Assert.Equal(5, stack.Count);
        }

        [Fact]
        public void ClearTest()
        {
            var stack = new LinkedListBasedStack<int>(new[] { 0, 1, 2, 3, 4 });
            stack.Clear();
            Assert.Equal(0, stack.Count);
        }

        [Fact]
        public void ContainsTest()
        {
            var stack = new LinkedListBasedStack<int>(new[] { 0, 1, 2, 3, 4 });

            Assert.Multiple(() =>
            {
                Assert.True(stack.Contains(0));
                Assert.True(stack.Contains(1));
                Assert.True(stack.Contains(2));
                Assert.True(stack.Contains(3));
                Assert.True(stack.Contains(4));
            });
        }

        [Fact]
        public void PeekTest()
        {
            var stack = new LinkedListBasedStack<int>(new[] { 0, 1, 2, 3, 4 });

            Assert.Equal(4, stack.Peek());
        }

        [Fact]
        public void PopTest()
        {
            var stack = new LinkedListBasedStack<int>(new[] { 0, 1, 2, 3, 4 });

            Assert.Equal(4, stack.Pop());
            Assert.Equal(3, stack.Pop());
            Assert.Equal(2, stack.Pop());
        }

        [Fact]
        public void PushTest()
        {
            var stack = new LinkedListBasedStack<int>();

            Assert.Multiple(() =>
                Enumerable.Range(0, 5)
                    .ToList()
                    .ForEach(number =>
                    {
                        stack.Push(number);
                        Assert.Equal(number, stack.Peek());
                    }));
        }
    }
}