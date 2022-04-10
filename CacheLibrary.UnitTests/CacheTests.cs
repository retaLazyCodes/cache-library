using System;
using System.Text;
using CacheLibrary.Core;
using Xunit;

namespace CacheLibrary.UnitTests
{
    public class CacheTests
    {
        [Fact]
        public void UpsertShouldInsertAProperValue()
        {
            string source = "Chad";
            byte[] bytes = Encoding.ASCII.GetBytes(source);

            var ops = new Operations();
            int quantityElements = ops.Count();

            Assert.Equal(quantityElements, 0);
            ops.Upsert("123", bytes, 10);

            Assert.Equal(quantityElements + 1, ops.Count());
        }
    }
}
