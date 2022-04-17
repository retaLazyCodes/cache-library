using System;
using CacheLibrary.Responses;

namespace CacheLibrary.Interfaces
{
    // Operations contains all the basic operations for all the interactions with the data structure (cache).
    public interface IOperations
    {
        // Get returns a value and an optional error given a key.
        OperationResult<string> Get(string key);

        // Upsert is for create/update operation in the cache.
        // ttl is expressed in seconds. If ttl 0, the entry will not expire.
        // Returns whether the entry was created with this operation [TRUE] or not (when was updated) [FALSE]
        OperationResult<bool> Upsert(string key, byte[] value, int ttl);

        // Delete removes a value given a key.
        // Returns whether the entry was deleted or not and an optional error
        OperationResult<bool> Delete(string key);

        // Exists checks if a key is registered.
        // Returns true if it exists, false if not, and a optional error.
        bool Exists(string key);

        // Returns the total number of pairs in the cache
        int Count();
    }
}