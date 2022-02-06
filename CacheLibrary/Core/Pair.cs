using System;

namespace CacheLibrary.Core
{
    public class Pair
    {
        public Pair(int ttl, DateTime createdAt, byte[] value)
        {
            Ttl = ttl;
            CreatedAt = createdAt;
            Value = value;
        }

        public int Ttl { get; }
        public DateTime CreatedAt { get; }
        public byte[] Value { get; }
    }
}