namespace FundementalsOfCSharp;

public class HashTables
{
    public interface IHashTable<TKey, TValue>
    {
        void Add(TKey key, TValue value);
        bool Remove(TKey key);
        bool Contains(TKey key);
        TValue? Get(TKey key);
    }


    public static void mainHashTable()
    {
        
    }
}