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
            // string source = "Chad";
            // byte[] bytes = Encoding.ASCII.GetBytes(source);
            // var hash = new Hash().GenerateMd5HashFromKey(bytes);

            // Console.WriteLine($"The MD5 hash of '{source}' is: {hash}");
            TestInsert();
            TestUpsert();
            TestDelete();
        }

        private static void TestInsert()
        {
            string source = "Chad";
            byte[] bytes = Encoding.ASCII.GetBytes(source);

            var ops = new Operations();
            ops.Upsert("123", bytes, 10);

            var value = ops.Get("123");
            var result = value.Success ? value.Data
            : value.NonSuccessMessage;

            Console.WriteLine(result);

        }

        private static void TestUpsert()
        {
            string source = "Boa noite";
            byte[] bytes = Encoding.ASCII.GetBytes(source);

            var ops = new Operations();
            ops.Upsert("123", bytes, 10);

            var value = ops.Get("123");
            var result = value.Success ? value.Data
            : value.NonSuccessMessage;

            Console.WriteLine(result);

        }

        private static void TestDelete()
        {
            var ops = new Operations();
            var value = ops.Delete("123");
            if (value.Success)
            {
                Console.WriteLine(value.Data);
            }
            else
            {
                Console.WriteLine(value.NonSuccessMessage);
            }
        }
    }
}