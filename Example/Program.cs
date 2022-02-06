using System;
using System.Text;
using CacheLibrary.Core;
using CacheLibrary.Utility;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = "Chad";
            byte[] bytes = Encoding.ASCII.GetBytes(source); 
            var hash = new Hash().GenerateMd5HashFromKey(bytes);

            Console.WriteLine($"The MD5 hash of '{source}' is: {hash}");
            TestUpsert();
        }

        private static void TestUpsert()
        {
            string source = "Chad";
            byte[] bytes = Encoding.ASCII.GetBytes(source);

            var ops = new Operations();
            ops.Upsert("123", bytes, 10);

            var value = ops.Get("123");
            Console.WriteLine($"The values of the key are: {value.Item1}");
        }
    }
}