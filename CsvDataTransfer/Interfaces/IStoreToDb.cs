using CsvDataTransfer.Models;

namespace CsvDataTransfer.Interfaces
{
    public interface IStoreToDb
    {
        void StoteCsvToDatabase(IEnumerable<OfferDbModel> data);
    }
}
