using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourismBackend.Migrations
{
    /// <inheritdoc />
    public partial class AcceptNullDestinationId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DestinationId",
                table: "pfItineraries",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "pfClients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ReservationDate", "TransactionDate" },
                values: new object[] { new DateTime(2024, 12, 12, 1, 16, 23, 509, DateTimeKind.Local).AddTicks(6343), new DateTime(2024, 12, 12, 1, 16, 23, 509, DateTimeKind.Local).AddTicks(6358) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DestinationId",
                table: "pfItineraries",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "pfClients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ReservationDate", "TransactionDate" },
                values: new object[] { new DateTime(2024, 12, 11, 23, 44, 21, 362, DateTimeKind.Local).AddTicks(542), new DateTime(2024, 12, 11, 23, 44, 21, 362, DateTimeKind.Local).AddTicks(555) });
        }
    }
}
