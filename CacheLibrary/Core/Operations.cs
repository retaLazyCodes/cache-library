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
            var hash = new Hash();
            var hashedKey = hash.GenerateMd5HashFromKey(key.GetBytes());
            if (!_cache.Contains(hashedKey))
            {
                return ("Error", new Exception("The key doesn't exist"));
            }
            
            var pair = _cache.Access(hashedKey);
            string value = Encoding.ASCII.GetString(pair.Value);
            return (value, null);
        }

        public (bool, Exception) Upsert(string key, byte[] value, int ttl)
        {
            var hash = new Hash();
            var hashedKey = hash.GenerateMd5HashFromKey(key.GetBytes());
            if (!_cache.Contains(hashedKey))
            {
                DateTime now = DateTime.Now;
                _cache.Add(hashedKey, new Pair(ttl, now, value));
                return (true, null);
            }
            return (false, null);
        }

        public (bool, Exception) Delete(string key)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string key)
        {
            return _cache.Contains(key);
        }
    }
}