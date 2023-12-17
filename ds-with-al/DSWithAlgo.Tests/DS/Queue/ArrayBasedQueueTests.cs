using System;
using System.Text;
using DSWithAlgo.DS.Queue;
using Xunit;

namespace DSWithAlgo.Tests.DS.Queue
{
    public class ArrayBasedQueueTests
    {
        [Fact]
        public void DequeueWorksCorrectly()
        {
            var q = new ArrayBasedQueue<char>(3);
            q.Enqueue('A');
            q.Enqueue('B');
            q.Enqueue('C');
            var result = new StringBuilder();

            for (var i = 0; i < 3; i++)
            {
                result.Append(q.Dequeue());
            }

            Assert.Equal("ABC", result.ToString());
            Assert.True(q.IsEmpty());
            Assert.False(q.IsFull());
        }

        [Fact]
        public void PeekWorksCorrectly()
        {
            var q = new ArrayBasedQueue<int>(2);
            q.Enqueue(1);
            q.Enqueue(2);
            var peeked = 0;

            for (var i = 0; i < 3; i++)
            {
                peeked = q.Peek();
            }

            Assert.Equal(1, peeked);
            Assert.False(q.IsEmpty());
            Assert.True(q.IsFull());
        }

        [Fact]
        public void DequeueEmptyQueueThrowsInvalidOperationException()
        {
            var q = new ArrayBasedQueue<int>(1);
            Exception? exception = null;

            try
            {
                q.Dequeue();
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            // Assert
            Assert.Equal(typeof(InvalidOperationException), exception?.GetType());
        }

        [Fact]
        public void EnqueueFullQueueThrowsInvalidOperationException()
        {
            var q = new ArrayBasedQueue<int>(1);
            q.Enqueue(0);
            Exception? exception = null;

            try
            {
                q.Enqueue(1);
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            // Assert
            Assert.Equal(typeof(InvalidOperationException), exception?.GetType());
        }

        [Fact]
        public void PeekEmptyQueueThrowsInvalidOperationException()
        {
            var q = new ArrayBasedQueue<int>(1);
            Exception? exception = null;

            try
            {
                q.Peek();
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.Equal(typeof(InvalidOperationException), exception?.GetType());
        }

        [Fact]
        public void ClearWorksCorrectly()
        {
            var q = new ArrayBasedQueue<int>(2);
            q.Enqueue(1);
            q.Enqueue(2);

            q.Clear();

            Assert.True(q.IsEmpty());
            Assert.False(q.IsFull());
        }
    }
}