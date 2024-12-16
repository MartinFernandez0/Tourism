using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourismBackend.Migrations
{
    /// <inheritdoc />
    public partial class EnumsMostrar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "pfClients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ReservationDate", "TransactionDate" },
                values: new object[] { new DateTime(2024, 12, 16, 13, 25, 5, 392, DateTimeKind.Local).AddTicks(4964), new DateTime(2024, 12, 16, 13, 25, 5, 392, DateTimeKind.Local).AddTicks(4991) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "pfClients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ReservationDate", "TransactionDate" },
                values: new object[] { new DateTime(2024, 12, 12, 14, 31, 39, 397, DateTimeKind.Local).AddTicks(5214), new DateTime(2024, 12, 12, 14, 31, 39, 397, DateTimeKind.Local).AddTicks(5230) });
        }
    }
}
