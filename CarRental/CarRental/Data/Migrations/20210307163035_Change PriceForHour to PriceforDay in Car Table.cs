using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Data.Migrations
{
    public partial class ChangePriceForHourtoPriceforDayinCarTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceForHour",
                table: "Cars");

            migrationBuilder.AddColumn<double>(
                name: "PriceForDay",
                table: "Cars",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceForDay",
                table: "Cars");

            migrationBuilder.AddColumn<double>(
                name: "PriceForHour",
                table: "Cars",
                type: "float",
                nullable: true);
        }
    }
}
