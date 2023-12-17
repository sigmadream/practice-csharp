using System.Text;
using DSWithAlgo.DS.Queue;
using Xunit;

namespace DSWithAlgo.Tests.DS.Queue
{
    public class CustomLinkedListQueueTests
    {
        [Fact]
        public void TestDequeue()
        {
            var q = new CustomLinkedListQueue<char>();
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
        }

        [Fact]
        public void TestPeek()
        {
            var q = new CustomLinkedListQueue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            var peek = 0;

            // Act
            for (var i = 0; i < 3; i++)
            {
                peek = q.Peek();
            }

            // Assert
            Assert.Equal(1, peek);
            Assert.False(q.IsEmpty());
        }
    }
}