using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Data.Migrations
{
    public partial class AddReservInfoPropertyToUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservationInfos_AspNetUsers_UserId",
                table: "ReservationInfos");

            migrationBuilder.DropIndex(
                name: "IX_ReservationInfos_UserId",
                table: "ReservationInfos");

            migrationBuilder.AddColumn<int>(
                name: "ReservationInfoId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ReservationInfos_UserId",
                table: "ReservationInfos",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationInfos_AspNetUsers_UserId",
                table: "ReservationInfos",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservationInfos_AspNetUsers_UserId",
                table: "ReservationInfos");

            migrationBuilder.DropIndex(
                name: "IX_ReservationInfos_UserId",
                table: "ReservationInfos");

            migrationBuilder.DropColumn(
                name: "ReservationInfoId",
                table: "AspNetUsers");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationInfos_UserId",
                table: "ReservationInfos",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationInfos_AspNetUsers_UserId",
                table: "ReservationInfos",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
