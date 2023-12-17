using Xunit;
using DSWithAlgo.DS.LinkedList;
using System.Collections.Generic;
using System.Linq;

namespace DSWithAlgo.Tests.LinkedList
{
    public class SkipListTests
    {
        [Fact]
        public void TestAdd()
        {
            var list = new SkipList<int>();
            list.AddOrUpdate(1, 1);
            list[2] = 2;
            list[3] = 3;
            var result = list.GetValues().ToList();

            Assert.Equal(3, list.Count);
            Assert.Equal(1, result[0]);
        }

        [Fact]
        public void TestUpdate()
        {
            var list = new SkipList<string>();

            // Add some elements.
            list[1] = "v1";
            list[2] = "v2";
            list[5] = "v5";

            // Update
            list.AddOrUpdate(1, "v1-updated");
            list[2] = "v2-updated";

            var result = list.GetValues().ToList();

            Assert.Equal(3, list.Count);
            Assert.Equal("v1-updated", result[0]);
        }

        [Fact]
        public void TestContains()
        {
            var list = new SkipList<int>();
            list.AddOrUpdate(1, 1);
            list.AddOrUpdate(3, 3);
            list.AddOrUpdate(5, 5);

            var result = list.GetValues().ToList();

            Assert.Equal(1, result[0]);
            Assert.Equal(3, result[1]);
            Assert.Equal(5, result[2]);
        }

        [Fact]
        public void TestGetByKey_Success()
        {
            var list = new SkipList<string>();
            list[1] = "value1";

            Assert.Equal("value1", list[1]);
        }

        [Fact]
        public void TestGetByKey_KeyNotFoundException()
        {
            var list = new SkipList<string>();
            list[1] = "value1";

            Assert.Throws<KeyNotFoundException>(() => list[2]);
        }

        [Fact]
        public void TestRemove_ItemRemoved()
        {
            var list = new SkipList<int>();
            list.AddOrUpdate(1, 1);
            list.AddOrUpdate(2, 2);
            list.AddOrUpdate(3, 3);

            var result = list.GetValues().ToList();

            Assert.Equal(3, list.Count);
            Assert.True(list.Contains(2));

            var isRemoved = list.Remove(2);

            result = list.GetValues().ToList();

            Assert.Equal(2, list.Count);
            Assert.False(list.Contains(2));
        }

        [Fact]
        public void TestRemove_ItemNotFound()
        {
            var list = new SkipList<int>();
            list.AddOrUpdate(1, 1);
            list.AddOrUpdate(2, 2);
            list.AddOrUpdate(3, 3);

            var isRemoved = list.Remove(222);

            Assert.Equal(3, list.Count);
            Assert.True(list.Contains(3));
        }

        [Fact]
        public void TestGetValues()
        {
            var list = new SkipList<string>();
            list[4] = "four";
            list[2] = "two";
            list[3] = "three";
            list[1] = "one";

            var valuesSortedByKey = list.GetValues();

            Assert.Equal(4, list.Count);
        }
    }
}