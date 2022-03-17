using System;
using System.Text;
using CacheLibrary.Interfaces;
using CacheLibrary.Responses;
using CacheLibrary.Utility;

namespace CacheLibrary.Core
{
    public class Operations : IOperations
    {
        private readonly Cache _cache;

        public Operations()
        {
            _cache = new Cache();
        }

        public OperationResult<string> Get(string key)
        {
            var hash = new Hash();
            var hashedKey = hash.GenerateMd5HashFromKey(key.GetBytes());
            if (!this.Exists(hashedKey))
            {
                return OperationResult<string>.CreateFailure("The given key doesn't exist");
            }

            var pair = _cache.Access(hashedKey);
            string value = Encoding.ASCII.GetString(pair.Value);
            return OperationResult<string>.CreateSuccessResult(value);
        }

        public OperationResult<bool> Upsert(string key, byte[] value, int ttl)
        {
            var hash = new Hash();
            var hashedKey = hash.GenerateMd5HashFromKey(key.GetBytes());
            DateTime now = DateTime.Now;
            if (!this.Exists(hashedKey))
            {
                _cache.Add(hashedKey, new Pair(ttl, now, value));
                return OperationResult<bool>.CreateSuccessResult(true);
            }

            _cache.Add(hashedKey, new Pair(ttl, now, value));
            return OperationResult<bool>.CreateSuccessResult(false);
        }

        public OperationResult<bool> Delete(string key)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string key)
        {
            return _cache.Contains(key);
        }
    }
}