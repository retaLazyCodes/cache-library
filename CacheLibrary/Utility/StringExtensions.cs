using System.Text;

namespace CacheLibrary.Utility
{
    public static class ExtensionMethods
    {
        public static byte[] GetBytes(this string s)
        {
            return Encoding.ASCII.GetBytes(s);
        }
    }
}