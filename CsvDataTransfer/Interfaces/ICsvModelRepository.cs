using CsvDataTransfer.Reflection;

namespace CsvDataTransfer.Interfaces
{
    public interface ICsvModelRepository
    {
        CsvProperty[] GetModelProperties<TCsv>();
    }
}
