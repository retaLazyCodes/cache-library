using System;

namespace CacheLibrary.Interfaces
{
    // Operations contains all the basic operations for all the interactions with the data structure (cache).
    public interface IOperations
    {
        // Get returns a value and an optional error given a key.
        (string, Exception) Get(string key);

        // Upsert is for create/update operation in the cache.
        // ttl is expressed in seconds. If ttl 0, the entry will not expire.
        // Returns whether the entry was created with this operation or not (updated) and an optional error
        (bool, Exception) Upsert(string key, byte[] value, int ttl);

        // Delete removes a value given a key.
        // Returns whether the entry was deleted or not and an optional error
        (bool, Exception) Delete(string key);

        // Exists checks if a key is registered.
        // Returns true if it exists, false if not, and a optional error.
        (bool, Exception) Exists(string key);
    }
}