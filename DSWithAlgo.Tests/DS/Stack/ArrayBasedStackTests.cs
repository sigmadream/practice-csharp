using System;
using System.Linq;
using DSWithAlgo.DS.Stack;
using Xunit;

namespace DSWithAlgo.Tests.DS.Stack
{
    public class ArrayBasedStackTests
    {
        private const string StackEmptyErrorMessage = "Stack is empty";

        [Fact]
        public void CountTest()
        {
            var stack = new ArrayBasedStack<int>(new[] { 0, 1, 2, 3, 4 });
            Assert.Equal(4, stack.Top);
        }

        [Fact]
        public void ClearTest()
        {
            var stack = new ArrayBasedStack<int>(new[] { 0, 1, 2, 3, 4 });

            stack.Clear();

            Assert.Equal(-1, stack.Top);
        }

        [Fact]
        public void ContainsTest()
        {
            var stack = new ArrayBasedStack<int>(new[] { 0, 1, 2, 3, 4 });


            Assert.Multiple(() =>
            {
                Assert.True(stack.Contains(0));
                Assert.True(stack.Contains(1));
                Assert.True(stack.Contains(2));
                Assert.True(stack.Contains(3));
                Assert.True(stack.Contains(4));
                Assert.False(stack.Contains(5));
            });
        }

        [Fact]
        public void PeekTest()
        {
            var stack = new ArrayBasedStack<int>(new[] { 0, 1, 2, 3, 4 });

            Assert.Equal(4, stack.Peek());
        }

        [Fact]
        public void PopTest()
        {
            var stack = new ArrayBasedStack<int>(new[] { 0, 1, 2, 3, 4 });

            Assert.Equal(4, stack.Pop());
            Assert.Equal(3, stack.Pop());
        }

        [Fact]
        public void PushTest()
        {
            var stack = new ArrayBasedStack<int>();

            Assert.Multiple(() =>
                Enumerable.Range(0, 5)
                    .ToList()
                    .ForEach(number =>
                    {
                        stack.Push(number);
                        Assert.Equal(number, stack.Peek());
                    }));
        }

        [Fact]
        public void AutomaticResizesTest()
        {
            const int initialCapacity = 2;
            var stack = new ArrayBasedStack<int>
            {
                Capacity = initialCapacity,
            };

            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Assert.True(stack.Capacity > initialCapacity);
        }

        [Fact]
        public void ShouldThrowStackEmptyExceptionOnEmptyPopTest()
        {
            var stack = new ArrayBasedStack<int>();

            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Fact]
        public void ShouldThrowStackEmptyExceptionOnEmptyPeekTest()
        {
            var stack = new ArrayBasedStack<int>();
            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }
    }
}
