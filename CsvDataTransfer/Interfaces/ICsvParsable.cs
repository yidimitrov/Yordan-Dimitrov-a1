namespace CsvDataTransfer.Interfaces
{
    public interface ICsvParsable
    {
        IEnumerable<T> ParseCsvRows<T>(IEnumerable<string> csvrows) where T : class, new();
    }
}
