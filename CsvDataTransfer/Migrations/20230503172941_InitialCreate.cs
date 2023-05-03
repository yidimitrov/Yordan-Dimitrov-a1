using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CsvDataTransfer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    OfferId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MonthlyFee = table.Column<decimal>(type: "TEXT", nullable: false),
                    NewContractsForMonth = table.Column<int>(type: "INTEGER", nullable: false),
                    SameContractsForMonth = table.Column<int>(type: "INTEGER", nullable: false),
                    CancelledContractsForMonth = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.OfferId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offers");
        }
    }
}
