using System.Collections.Generic;

namespace CacheLibrary.Core
{
    public class Cache
    {
        private Dictionary<string, Pair> _pairs;

        public Cache()
        {
            _pairs = new Dictionary<string, Pair>();
        }

        public bool Add(string keyHashed, Pair pair)
        {
            _pairs[keyHashed] = pair;
            return true;
        }

        public Pair Access(string keyHashed)
        {
            return _pairs[keyHashed];
        }

        public bool Delete(string keyHashed)
        {
            var pairSize = _pairs.Count;
            _pairs.Remove(keyHashed);
            return _pairs.Count < pairSize;
        }

        public bool Contains(string keyHashed)
        {
            return _pairs.ContainsKey(keyHashed);
        }
    }
}