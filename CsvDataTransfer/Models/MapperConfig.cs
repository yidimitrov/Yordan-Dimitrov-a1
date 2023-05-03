using AutoMapper;

namespace CsvDataTransfer.Models
{
    public class MapperConfig
    {
        public static Mapper InitializeAutoMapper()
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<OfferCsvModel, OfferDbModel>();
            });

            var mapper = new Mapper(config);

            return mapper;
        }
    }
}
