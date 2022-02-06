using System;
using CacheLibrary.Interfaces;

namespace CacheLibrary.Utility
{
    public class Operations: IOperations
    {
        public (string, Exception) Get(string key)
        {
            throw new NotImplementedException();
        }

        public (bool, Exception) Upsert(string key, byte[] value, int ttl)
        {
            throw new NotImplementedException();
        }

        public (bool, Exception) Delete(string key)
        {
            throw new NotImplementedException();
        }

        public (bool, Exception) Exists(string key)
        {
            throw new NotImplementedException();
        }
    }
}