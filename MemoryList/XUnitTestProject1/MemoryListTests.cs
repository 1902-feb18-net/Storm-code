using MemoryList;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class MemoryListTests
    {


        [Theory]
        [InlineData(-5)]
        [InlineData(0)]
        [InlineData(10000)]
        public void ItemsShouldBeContained(int value)
        {
            var list = new MemoryList<int>();

            list.Add(value);

            Assert.True(list.Contains(value));
        }

        [Fact]
        public void ContainIsTrue()
        {
            var list = new MemoryList<int>();

            list.Add(7);

            Assert.True(list.Contains(7));
        }

        [Fact]
        public void ContainIsFalse()
        {
            var list = new MemoryList<int>();

            list.Add(7);

            Assert.False(list.Contains(9));
        }

        [Fact]
        public void ListCanRemove()
        {
            var list = new MemoryList<int>();

            list.Add(7);
            list.Remove(7);


            Assert.False(list.Contains(7));
        }
    }
}
