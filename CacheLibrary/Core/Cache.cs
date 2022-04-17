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
            var pairSize = _pairs.Count;
            _pairs[keyHashed] = pair;
            return _pairs.Count > pairSize;
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

        public int Count()
        {
            return _pairs.Count;
        }
    }
}