using CsvDataTransfer.Interfaces;
using CsvDataTransfer.Models;

namespace CsvDataTransfer.Processing
{
    public class ProcessData : IService
    {
        public ProcessData(ICsvLoadable loadable, ICsvParsable csvParsable, IStoreToDb storeToDb)
        {

            _loadable = loadable;
            _csvParsable = csvParsable;
            _storeToDb = storeToDb;
        }

        private readonly ICsvLoadable _loadable;
        private readonly ICsvParsable _csvParsable;
        private readonly IStoreToDb _storeToDb;

        public void TransferCsvFileToDb(string csvfile)
        {
            try
            {
                string[] csvrows = _loadable.LoadCsv(csvfile).ToArray();

                IEnumerable<OfferCsvModel> offers = _csvParsable.ParseCsvRows<OfferCsvModel>(csvrows);

                _storeToDb.StoteToDatabase(offers);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
