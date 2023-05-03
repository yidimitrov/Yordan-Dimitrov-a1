using CsvDataTransfer.Interfaces;

namespace CsvDataTransfer.Processing
{
    public class DbRepository : IStoreToDb
    {
        public void StoteToDatabase<T>(IEnumerable<T> data)
        {
            throw new NotImplementedException();
        }
    }
}