using System;
using System.Text;
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
        }
    }
}