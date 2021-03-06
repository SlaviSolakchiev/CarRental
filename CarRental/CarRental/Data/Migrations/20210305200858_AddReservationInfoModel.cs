using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Data.Migrations
{
    public partial class AddReservationInfoModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReservationInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    CarId = table.Column<int>(nullable: false),
                    PickUpDate = table.Column<DateTime>(nullable: false),
                    ReturnDate = table.Column<DateTime>(nullable: false),
                    PickUpLocationId = table.Column<int>(nullable: false),
                    ReturnLocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservationInfos_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationInfos_Locations_PickUpLocationId",
                        column: x => x.PickUpLocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReservationInfos_Locations_ReturnLocationId",
                        column: x => x.ReturnLocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReservationInfos_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservationInfos_CarId",
                table: "ReservationInfos",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationInfos_PickUpLocationId",
                table: "ReservationInfos",
                column: "PickUpLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationInfos_ReturnLocationId",
                table: "ReservationInfos",
                column: "ReturnLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationInfos_UserId",
                table: "ReservationInfos",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservationInfos");
        }
    }
}
