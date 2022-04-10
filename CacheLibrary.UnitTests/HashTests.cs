using System;
using System.Text;
using CacheLibrary.Utility;
using Xunit;

namespace CacheLibrary.UnitTests
{
    public class HashTests
    {
        [Fact]
        public void GenerateProperMD5Hashing()
        {
            string source = "Hello World!";
            byte[] bytes = Encoding.ASCII.GetBytes(source);
            var hash = new Hash().GenerateMd5HashFromKey(bytes);

            var md5SourceHashed = "ED076287532E86365E841E92BFC50D8C";
            Assert.Equal(md5SourceHashed, hash);
        }
    }
}
