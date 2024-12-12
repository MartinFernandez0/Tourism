using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TourismBackend.Migrations
{
    /// <inheritdoc />
    public partial class OpenMigrationsTour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
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
                    RegistrationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfAdministrators", x => x.Id);
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
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfDestinations", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pfActivities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ActivityName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    URLimage = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DestinationId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pfActivities_pfDestinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "pfDestinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    DepartureDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DestinationId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfItineraries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pfItineraries_pfDestinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "pfDestinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Birthdate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CustomerGender = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PostalCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AccommodationPreference = table.Column<int>(type: "int", nullable: false),
                    FoodPreference = table.Column<int>(type: "int", nullable: false),
                    PreferenceTransport = table.Column<int>(type: "int", nullable: false),
                    DestinationId = table.Column<int>(type: "int", nullable: true),
                    ActivityId = table.Column<int>(type: "int", nullable: true),
                    NumberOfPeople = table.Column<int>(type: "int", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ReservationStatus = table.Column<int>(type: "int", nullable: false),
                    ItineraryId = table.Column<int>(type: "int", nullable: true),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    PaymentConfirmation = table.Column<int>(type: "int", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfClients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pfClients_pfActivities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "pfActivities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_pfClients_pfDestinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "pfDestinations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_pfClients_pfItineraries_ItineraryId",
                        column: x => x.ItineraryId,
                        principalTable: "pfItineraries",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "pfAdministrators",
                columns: new[] { "Id", "Email", "IsDeleted", "LastName", "Name", "Phone", "RegistrationDate" },
                values: new object[] { 1, "martinexefe@example.com", false, "Fernandez", "Martin", "123456789", new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "pfDestinations",
                columns: new[] { "Id", "CategoryName", "Country", "Description", "IsDeleted", "Name", "URL_image" },
                values: new object[,]
                {
                    { 1, "Natural", "Argentina", "Maravilla natural en la provincia de Misiones.", false, "Cataratas del Iguazú", "https://www.iguazujungle.com/esp/web2/images/Web%20192016.jpg" },
                    { 2, "Cultural", "Argentina", "Capital cosmopolita de Argentina con rica vida cultural.", false, "Buenos Aires", "https://s3.amazonaws.com/arc-wordpress-client-uploads/infobae-wp/wp-content/uploads/2019/07/03201757/Ciudades-mas-caras-de-America-Latina-Buenos-Aires.jpg" }
                });

            migrationBuilder.InsertData(
                table: "pfActivities",
                columns: new[] { "Id", "ActivityName", "Cost", "Description", "DestinationId", "Duration", "IsDeleted", "URLimage" },
                values: new object[,]
                {
                    { 1, "Caminata por las Cataratas del Iguazú", 75.00m, "Exploración a pie por los senderos de las Cataratas del Iguazú.", 1, 180, false, "https://media.tacdn.com/media/attractions-splice-spp-360x240/0a/dd/10/25.jpg" },
                    { 2, "Visita a la Casa Rosada", 50.00m, "Visita a la Casa Rosada de Buenos Aires.", 2, 120, false, "https://media.tacdn.com/media/attractions-splice-spp-674x446/06/70/5f/c2.jpg" }
                });

            migrationBuilder.InsertData(
                table: "pfItineraries",
                columns: new[] { "Id", "DepartureDate", "Description", "DestinationId", "IsDeleted", "Name", "ReturnDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Viaje a las Cataratas del Iguazú con actividades de aventura.", 1, false, "Aventura en las Cataratas", new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Viaje a Buenos Aires con actividades culturales.", 2, false, "Cultura en Buenos Aires", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "pfClients",
                columns: new[] { "Id", "AccommodationPreference", "ActivityId", "Address", "Birthdate", "City", "Country", "CustomerGender", "DestinationId", "Document", "Email", "FirstName", "FoodPreference", "IsDeleted", "ItineraryId", "LastName", "NumberOfPeople", "PaymentConfirmation", "PaymentMethod", "PhoneNumber", "PostalCode", "PreferenceTransport", "ReservationDate", "ReservationStatus", "TotalAmount", "TransactionDate" },
                values: new object[] { 1, 0, 1, "Calle Falsa 123", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Springfield", "Estados Unidos", 1, 1, "12345678", "ana.gomez@example.com", "Ana", 0, false, 1, "Gómez", 2, 1, 0, "987654321", "12345", 0, new DateTime(2024, 12, 12, 14, 31, 39, 397, DateTimeKind.Local).AddTicks(5214), 0, 150000.00m, new DateTime(2024, 12, 12, 14, 31, 39, 397, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.CreateIndex(
                name: "IX_pfActivities_DestinationId",
                table: "pfActivities",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_pfClients_ActivityId",
                table: "pfClients",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_pfClients_DestinationId",
                table: "pfClients",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_pfClients_ItineraryId",
                table: "pfClients",
                column: "ItineraryId");

            migrationBuilder.CreateIndex(
                name: "IX_pfItineraries_DestinationId",
                table: "pfItineraries",
                column: "DestinationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pfAdministrators");

            migrationBuilder.DropTable(
                name: "pfClients");

            migrationBuilder.DropTable(
                name: "pfActivities");

            migrationBuilder.DropTable(
                name: "pfItineraries");

            migrationBuilder.DropTable(
                name: "pfDestinations");
        }
    }
}
