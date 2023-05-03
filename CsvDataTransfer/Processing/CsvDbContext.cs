using CsvDataTransfer.Models;
using Microsoft.EntityFrameworkCore;

namespace CsvDataTransfer.Processing
{
    public class CsvDbContext : DbContext
    {
        public DbSet<OfferDbModel> Offers { get; set; }

        public string DbPath { get; }

        public CsvDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "offers.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}