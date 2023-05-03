using CsvDataTransfer.Attributes;

namespace CsvDataTransfer.Models
{
    [CsvData]
    public class OfferCsvModel
    {
        [CsvField(0)]
        public int OfferId{ get; set; }

        [CsvField(1)]
        public decimal MonthlyFee{ get; set; }

        [CsvField(2)]
        public int NewContractsForMonth{ get; set; }

        [CsvField(3)]
        public int SameContractsForMonth{ get; set; }

        [CsvField(4)]
        public int CancelledContractsForMonth{ get; set; }

    }
}
