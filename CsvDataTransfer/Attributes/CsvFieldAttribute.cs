namespace CsvDataTransfer.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CsvFieldAttribute : Attribute
    {
        public CsvFieldAttribute(int position)
        {
            Position = position;
        }

        public int Position { get; set; }
    }
}
