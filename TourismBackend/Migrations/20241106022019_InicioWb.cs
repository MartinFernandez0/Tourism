using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TourismBackend.Migrations
{
    /// <inheritdoc />
    public partial class InicioWb : Migration
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
                    RegistrationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfAdministrators", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pfTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    PaymentConfirmation = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfTransactions", x => x.Id);
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
                    URLimage = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DestinationId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfActivities", x => x.Id);
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
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ActivityId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfItineraries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pfItineraries_pfActivities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "pfActivities",
                        principalColumn: "Id");
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
                    ItineraryId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfDestinations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pfDestinations_pfItineraries_ItineraryId",
                        column: x => x.ItineraryId,
                        principalTable: "pfItineraries",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pfReservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ReservationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ReservationStatus = table.Column<int>(type: "int", nullable: false),
                    ItineraryId = table.Column<int>(type: "int", nullable: true),
                    DestinationId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pfReservations_pfDestinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "pfDestinations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_pfReservations_pfItineraries_ItineraryId",
                        column: x => x.ItineraryId,
                        principalTable: "pfItineraries",
                        principalColumn: "Id");
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
                    DateBirth = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ReservationId = table.Column<int>(type: "int", nullable: true),
                    TransactionId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfClients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pfClients_pfReservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "pfReservations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_pfClients_pfTransactions_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "pfTransactions",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "pfAdministrators",
                columns: new[] { "Id", "Email", "LastName", "Name", "Phone", "RegistrationDate" },
                values: new object[] { 1, "martinexefe@example.com", "Fernandez", "Martin", "123456789", new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "pfDestinations",
                columns: new[] { "Id", "CategoryName", "Country", "Description", "IsDeleted", "ItineraryId", "Name", "URL_image" },
                values: new object[,]
                {
                    { 1, "Cultural", "Perú", "Antigua ciudad inca.", false, null, "Machu Picchu", "https://images.adsttc.com/media/images/5d85/0ef9/284d/d153/e100/0165/newsletter/San_Ignacio_Min%C3%AD_mission_ruins.jpg?1569001197" },
                    { 2, "Cultural", "Perú", "Antigua ciudad inca.", false, null, "Machu Picchu", "https://images.adsttc.com/media/images/5d85/0ef9/284d/d153/e100/0165/newsletter/San_Ignacio_Min%C3%AD_mission_ruins.jpg?1569001197" },
                    { 3, "Landmark", "Francia", "Icono arquitectónico de París, Francia.", false, null, "Eiffel Tower", "https://upload.wikimedia.org/wikipedia/commons/a/a8/Eiffel_Tower_Paris_2011.jpg" },
                    { 4, "Historic", "China", "Murallas que se extienden por miles de kilómetros.", false, null, "Great Wall of China", "https://upload.wikimedia.org/wikipedia/commons/4/43/Great_Wall_of_China_Mutianyu_Section.jpg" },
                    { 5, "Cultural", "Australia", "Famoso centro de artes escénicas en Australia.", false, null, "Sydney Opera House", "https://upload.wikimedia.org/wikipedia/commons/4/4e/Sydney_Opera_House_Sails.jpg" },
                    { 6, "Historic", "Italia", "Antiguo anfiteatro romano en el centro de Roma.", false, null, "Colosseum", "https://upload.wikimedia.org/wikipedia/commons/7/7f/Colosseo_2020.jpg" }
                });

            migrationBuilder.InsertData(
                table: "pfTransactions",
                columns: new[] { "Id", "Amount", "IsDeleted", "PaymentConfirmation", "PaymentMethod", "TransactionDate" },
                values: new object[,]
                {
                    { 1, 100.00m, false, 1, 1, new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 100.00m, false, 1, 1, new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "pfActivities",
                columns: new[] { "Id", "ActivityName", "Cost", "Description", "DestinationId", "Duration", "IsDeleted", "URLimage" },
                values: new object[,]
                {
                    { 1, "Visita a las Ruinas", 50.00m, "Recorrido por las ruinas antiguas.", 1, 120, false, "https://images.adsttc.com/media/images/5d85/0ef9/284d/d153/e100/0165/newsletter/San_Ignacio_Min%C3%AD_mission_ruins.jpg?1569001197" },
                    { 2, "Visita a la Ciudad", 50.00m, "Recorrido por la ciudad antigua.", 2, 120, false, "https://images.adsttc.com/media/images/5d85/0ef9/284d/d153/e100/0165/newsletter/San_Ignacio_Min%C3%AD_mission_ruins.jpg?1569001197" },
                    { 3, "Visita a la Montaña", 50.00m, "Recorrido por la montaña antigua.", 3, 120, false, "https://images.adsttc.com/media/images/5d85/0ef9/284d/d153/e100/0165/newsletter/San_Ignacio_Min%C3%AD_mission_ruins.jpg?1569001197" },
                    { 4, "Visita a la Playa", 50.00m, "Recorrido por la playa antigua.", 4, 120, false, "https://images.adsttc.com/media/images/5d85/0ef9/284d/d153/e100/0165/newsletter/San_Ignacio_Min%C3%AD_mission_ruins.jpg?1569001197" },
                    { 5, "Visita a la Ciudad", 50.00m, "Recorrido por la ciudad antigua.", 5, 120, false, "https://images.adsttc.com/media/images/5d85/0ef9/284d/d153/e100/0165/newsletter/San_Ignacio_Min%C3%AD_mission_ruins.jpg?1569001197" },
                    { 6, "Visita a la Ciudad", 50.00m, "Recorrido por la ciudad antigua.", 6, 120, false, "https://images.adsttc.com/media/images/5d85/0ef9/284d/d153/e100/0165/newsletter/San_Ignacio_Min%C3%AD_mission_ruins.jpg?1569001197" }
                });

            migrationBuilder.InsertData(
                table: "pfItineraries",
                columns: new[] { "Id", "ActivityId", "DepartureDate", "Description", "IsDeleted", "Name", "ReturnDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Viaje a Perú con actividades de aventura.", false, "Itinerario de Aventura", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Viaje a Perú con actividades de aventura.", false, "Itinerario de Aventura", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Recorrido cultural por los monumentos más emblemáticos de París.", false, "Tour Cultural por París", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, new DateTime(2024, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exploración de la Gran Muralla y sitios históricos de China.", false, "Ruta Histórica en China", new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visita a los paisajes naturales y culturales de Australia.", false, "Aventura Australiana", new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 6, new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Viaje guiado a través de los monumentos de la Roma Imperial.", false, "Recorrido por la Roma Antigua", new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "pfReservations",
                columns: new[] { "Id", "DestinationId", "IsDeleted", "ItineraryId", "ReservationDate", "ReservationStatus" },
                values: new object[,]
                {
                    { 1, 1, false, 1, new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, 2, false, 2, new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "pfClients",
                columns: new[] { "Id", "DateBirth", "Document", "Email", "FirstName", "IsDeleted", "LastName", "PhoneNumber", "ReservationId", "TransactionId" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12345678", "ana.gomez@example.com", "Ana", false, "Gómez", "987654321", 1, 1 },
                    { 2, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "87654321", "juanperez@example.com", "Juan", false, "Pérez", "123456789", 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_pfActivities_DestinationId",
                table: "pfActivities",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_pfClients_ReservationId",
                table: "pfClients",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_pfClients_TransactionId",
                table: "pfClients",
                column: "TransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_pfDestinations_ItineraryId",
                table: "pfDestinations",
                column: "ItineraryId");

            migrationBuilder.CreateIndex(
                name: "IX_pfItineraries_ActivityId",
                table: "pfItineraries",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_pfReservations_DestinationId",
                table: "pfReservations",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_pfReservations_ItineraryId",
                table: "pfReservations",
                column: "ItineraryId");

            migrationBuilder.AddForeignKey(
                name: "FK_pfActivities_pfDestinations_DestinationId",
                table: "pfActivities",
                column: "DestinationId",
                principalTable: "pfDestinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pfActivities_pfDestinations_DestinationId",
                table: "pfActivities");

            migrationBuilder.DropTable(
                name: "pfAdministrators");

            migrationBuilder.DropTable(
                name: "pfClients");

            migrationBuilder.DropTable(
                name: "pfReservations");

            migrationBuilder.DropTable(
                name: "pfTransactions");

            migrationBuilder.DropTable(
                name: "pfDestinations");

            migrationBuilder.DropTable(
                name: "pfItineraries");

            migrationBuilder.DropTable(
                name: "pfActivities");
        }
    }
}
