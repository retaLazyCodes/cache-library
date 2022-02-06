using System;
using CacheLibrary.Utility;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = "Example";
            var hash = new Hash().GenerateMd5HashFromKey(source);

            Console.WriteLine($"The MD5 hash of '{source}' is: {hash}");
        }
    }
}