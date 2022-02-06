using System;
using CacheLibrary.Interfaces;

namespace CacheLibrary.Utility
{
    public class Hash : IHash
    {
        //GenerateMd5HashFromKey is a hash generator function according to input(source)
        //using md5 algorithm
        public string GenerateMd5HashFromKey(byte[] sourceKey)
        {
            // Creates an instance of the default implementation of the MD5 hash algorithm.
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                // Generate hash value(Byte Array) for input data
                byte[] hashBytes = md5.ComputeHash(sourceKey);

                // Convert hash byte array to string
                string hash = BitConverter.ToString(hashBytes)
                    .Replace("-", string.Empty);

                return hash;
            }
        }
    }
}