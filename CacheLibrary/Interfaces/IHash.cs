namespace CacheLibrary.Interfaces
{
    public interface IHash
    {
        string GenerateMd5HashFromKey(string source);
    }
}