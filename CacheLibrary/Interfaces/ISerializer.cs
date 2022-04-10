using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CacheLibrary.Interfaces
{
    public interface ISerializer
    {
        byte[] StringToByteArray(string value);

        String ByteArrayToString(byte[] bytes);

        byte[] ObjectToByteArray(Object obj);

        Object ByteArrayToObject(byte[] bytes);
    }
}