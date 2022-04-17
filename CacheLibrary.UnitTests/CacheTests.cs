using System;
using System.Text;
using CacheLibrary.Core;
using Xunit;

namespace CacheLibrary.UnitTests
{
    public class CacheTests
    {
        [Fact]
        public void UpsertShouldInsertAProperNewValue()
        {
            string source = "Chad";
            byte[] bytes = Encoding.ASCII.GetBytes(source);

            var ops = new Operations();
            int quantityElements = ops.Count();

            Assert.Equal(quantityElements, 0);
            var opResult = ops.Upsert("123", bytes, 10);

            Assert.Equal(quantityElements + 1, ops.Count());
            Assert.True(opResult.Data);
        }

        [Fact]
        public void UpsertShouldUpdateAnExistingValue()
        {
            string source1 = "something";
            byte[] bytes1 = Encoding.ASCII.GetBytes(source1);

            var ops = new Operations();
            var opResult1 = ops.Upsert("123", bytes1, 10);
            Assert.True(opResult1.Data, "the pair should be inserted if the key doesn't exists");

            string source2 = "something else";
            byte[] bytes2 = Encoding.ASCII.GetBytes(source2);

            var opResult2 = ops.Upsert("123", bytes2, 10);
            Assert.False(opResult2.Data, "the pair should be updated if the key already exists");
        }
    }
}
