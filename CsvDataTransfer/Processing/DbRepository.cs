using CsvDataTransfer.Interfaces;
using CsvDataTransfer.Models;

namespace CsvDataTransfer.Processing
{
    public class DbRepository : IStoreToDb
    {
        public void StoteCsvToDatabase(IEnumerable<OfferDbModel> data)
        {
            using var db = new CsvDbContext();

            foreach (var item in data)
            {
                db.Add(item);
            }
            db.SaveChanges();
        }
    }
}