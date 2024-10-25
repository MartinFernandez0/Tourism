using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TourismBackend.Migrations
{
    /// <inheritdoc />
    public partial class proyectoTourism : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pfActivities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ActivityName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    URLimage = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfActivities", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pfAdministrators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegistrationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfAdministrators", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pfClients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Document = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateBirth = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfClients", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pfDestinations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    URL_image = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CategoryName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfDestinations", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pfItineraries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DestinationID = table.Column<int>(type: "int", nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfItineraries", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pfReservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ItineraryID = table.Column<int>(type: "int", nullable: false),
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ReservationStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfReservations", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pfTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    PaymentConfirmation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfTransactions", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "pfActivities",
                columns: new[] { "Id", "ActivityName", "Cost", "Description", "Duration", "URLimage" },
                values: new object[,]
                {
                    { 1, "Eiffel Tower Visit", 30.00m, "Guided tour of the Eiffel Tower", 3, "https://imgs.search.brave.com/ifM8jJudxdlseBcPdMm8ql0MWz9JgP3R1sugQ7Q2WzA/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9jZG4u/Y3VsdHVyYWdlbmlh/bC5jb20vZXMvaW1h/Z2VuZXMvdG9ycmUt/ZWlmZmVsLWNrZS5q/cGc_Y2xhc3M9YXJ0/aWNsZQ" },
                    { 2, "Hudson River Cruise", 50.00m, "Boat tour along the Hudson River", 2, "https://imgs.search.brave.com/zuhiGpSpdxrdQSGxmpnztHWQX-jfCQUae6Xa0mzj9Q8/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9hY2xt/ZWRpYS5henVyZWVk/Z2UubmV0L2Ntc21l/ZGlhL2xpYnJhcmll/cy9hY2wvaW1hZ2Vz/L2NydWlzZXMvaHVk/c29uLXJpdmVyLWNy/dWlzZXMvYWNsX3dl/YnNpdGVfNzAweDUw/MF9odWRzb25fY3J1/aXNpbmdfb3ZlcnZp/ZXcyLmpwZz9leHQ9/LmpwZw" }
                });

            migrationBuilder.InsertData(
                table: "pfAdministrators",
                columns: new[] { "Id", "Email", "LastName", "Name", "Phone", "RegistrationDate" },
                values: new object[] { 1, "martin_fernandez@example.com", "Fernandez", "Martin", "3498479331", new DateTime(2024, 10, 23, 16, 13, 11, 214, DateTimeKind.Local).AddTicks(2229) });

            migrationBuilder.InsertData(
                table: "pfClients",
                columns: new[] { "Id", "DateBirth", "Document", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456789", "client1@example.com", "Client1", "LastName1", "1234567890" },
                    { 2, new DateTime(1994, 10, 23, 16, 13, 11, 214, DateTimeKind.Local).AddTicks(2400), "987654321", "client2@example.com", "Client2", "LastName2", "0987654321" },
                    { 3, new DateTime(1999, 10, 23, 16, 13, 11, 214, DateTimeKind.Local).AddTicks(2408), "456789123", "client3@example.com", "Client3", "LastName3", "4567891230" },
                    { 4, new DateTime(1984, 10, 23, 16, 13, 11, 214, DateTimeKind.Local).AddTicks(2410), "321654987", "client4@example.com", "Client4", "LastName4", "3216549870" },
                    { 5, new DateTime(1989, 10, 23, 16, 13, 11, 214, DateTimeKind.Local).AddTicks(2413), "789123456", "client5@example.com", "Client5", "LastName5", "7891234560" }
                });

            migrationBuilder.InsertData(
                table: "pfDestinations",
                columns: new[] { "Id", "CategoryName", "Country", "Description", "Name", "URL_image" },
                values: new object[,]
                {
                    { 1, "City", "France", "The City of Lights", "Paris", "https://imgs.search.brave.com/ifM8jJudxdlseBcPdMm8ql0MWz9JgP3R1sugQ7Q2WzA/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9jZG4u/Y3VsdHVyYWdlbmlh/bC5jb20vZXMvaW1h/Z2VuZXMvdG9ycmUt/ZWlmZmVsLWNrZS5q/cGc_Y2xhc3M9YXJ0/aWNsZQ" },
                    { 2, "City", "USA", "The Big Apple", "New York", "https://www.travel-guide.es/media/new-york.jpeg" }
                });

            migrationBuilder.InsertData(
                table: "pfItineraries",
                columns: new[] { "Id", "DepartureDate", "Description", "DestinationID", "Name", "ReturnDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 30, 16, 13, 11, 214, DateTimeKind.Local).AddTicks(2511), "Trip to Paris", 1, "Paris", new DateTime(2024, 11, 6, 16, 13, 11, 214, DateTimeKind.Local).AddTicks(2515) },
                    { 2, new DateTime(2024, 11, 13, 16, 13, 11, 214, DateTimeKind.Local).AddTicks(2518), "Trip to New York", 2, "New York", new DateTime(2024, 11, 20, 16, 13, 11, 214, DateTimeKind.Local).AddTicks(2518) }
                });

            migrationBuilder.InsertData(
                table: "pfReservations",
                columns: new[] { "Id", "ClientID", "ItineraryID", "ReservationDate", "ReservationStatus" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2024, 10, 23, 16, 13, 11, 214, DateTimeKind.Local).AddTicks(2542), 0 },
                    { 2, 2, 2, new DateTime(2024, 10, 23, 16, 13, 11, 214, DateTimeKind.Local).AddTicks(2544), 1 }
                });

            migrationBuilder.InsertData(
                table: "pfTransactions",
                columns: new[] { "Id", "Amount", "ClientID", "PaymentConfirmation", "PaymentMethod", "TransactionDate" },
                values: new object[,]
                {
                    { 1, 1500.00m, 1, 1, 1, new DateTime(2024, 10, 23, 16, 13, 11, 214, DateTimeKind.Local).AddTicks(2569) },
                    { 2, 2000.00m, 2, 2, 1, new DateTime(2024, 10, 23, 16, 13, 11, 214, DateTimeKind.Local).AddTicks(2573) },
                    { 3, 500.00m, 1, 3, 4, new DateTime(2024, 10, 23, 16, 13, 11, 214, DateTimeKind.Local).AddTicks(2575) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pfActivities");

            migrationBuilder.DropTable(
                name: "pfAdministrators");

            migrationBuilder.DropTable(
                name: "pfClients");

            migrationBuilder.DropTable(
                name: "pfDestinations");

            migrationBuilder.DropTable(
                name: "pfItineraries");

            migrationBuilder.DropTable(
                name: "pfReservations");

            migrationBuilder.DropTable(
                name: "pfTransactions");
        }
    }
}
