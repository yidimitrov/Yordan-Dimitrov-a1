using System.ComponentModel.DataAnnotations;

namespace CsvDataTransfer.Models
{
    public class OfferDbModel
    {
        [Key]
        public int OfferId{ get; set; }

        public decimal MonthlyFee{ get; set; }

        public int NewContractsForMonth{ get; set; }

        public int SameContractsForMonth{ get; set; }

        public int CancelledContractsForMonth{ get; set; }

    }
}
