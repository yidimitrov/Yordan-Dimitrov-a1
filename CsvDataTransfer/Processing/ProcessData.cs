using AutoMapper;
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
            _mapper = MapperConfig.InitializeAutoMapper();
        }

        private readonly ICsvLoadable _loadable;
        private readonly ICsvParsable _csvParsable;
        private readonly IStoreToDb _storeToDb;
        private readonly Mapper _mapper;

        public void TransferCsvFileToDb(string csvfile)
        {
            try
            {
                var csvrows = _loadable.LoadCsv(csvfile).ToArray();

                var offers = _csvParsable.ParseCsvRows<OfferCsvModel>(csvrows);

                var dbOffers = _mapper.Map<IEnumerable<OfferCsvModel>, IEnumerable<OfferDbModel>>(offers);

                _storeToDb.StoteCsvToDatabase(dbOffers);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
