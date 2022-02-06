using System;
using System.Text;
using CacheLibrary.Interfaces;
using CacheLibrary.Utility;

namespace CacheLibrary.Core
{
    public class Operations: IOperations
    {
        private readonly Cache _cache;

        public Operations()
        {
            _cache = new Cache();
        }
        
        public (string, Exception) Get(string key)
        {
            byte[] keyBytes = Encoding.ASCII.GetBytes(key);
            var hash = new Hash();
            var hashedKey = hash.GenerateMd5HashFromKey(keyBytes);
            
            var pair = _cache.Access(hashedKey);
            string value = Encoding.ASCII.GetString(pair.Value);
            return (value, null);
        }

        public (bool, Exception) Upsert(string key, byte[] value, int ttl)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(key);
            var hash = new Hash();
            var hashedKey = hash.GenerateMd5HashFromKey(bytes);
            
            DateTime now = DateTime.Now;
            _cache.Add(hashedKey, new Pair(ttl, now, value));
            return (true, null);
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