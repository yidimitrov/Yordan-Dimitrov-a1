namespace CsvDataTransfer.Interfaces
{
    public interface IStoreToDb
    {
        void StoteToDatabase<T>(IEnumerable<T> data);
    }
}
