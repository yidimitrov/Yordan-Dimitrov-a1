namespace CsvDataTransfer.Interfaces
{
    public interface ICsvLoadable
    {
        IEnumerable<string> LoadCsv(string filename);
    }
}
