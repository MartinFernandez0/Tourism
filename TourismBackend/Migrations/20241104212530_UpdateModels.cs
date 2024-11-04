using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TourismBackend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels : Migration
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
                name: "pfTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    PaymentConfirmation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pfTransactions_pfClients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "pfClients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    pfDestinationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfItineraries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pfItineraries_pfDestinations_pfDestinationId",
                        column: x => x.pfDestinationId,
                        principalTable: "pfDestinations",
                        principalColumn: "Id");
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
                    pfItineraryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pfActivities_pfDestinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "pfDestinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pfActivities_pfItineraries_pfItineraryId",
                        column: x => x.pfItineraryId,
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
                    ItineraryId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    DestinationId = table.Column<int>(type: "int", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ReservationStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pfReservations_pfClients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "pfClients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pfReservations_pfDestinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "pfDestinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pfReservations_pfItineraries_ItineraryId",
                        column: x => x.ItineraryId,
                        principalTable: "pfItineraries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "pfClients",
                columns: new[] { "Id", "DateBirth", "Document", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(1985, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "12345678", "juan.perez@mail.com", "Juan", "Pérez", "123456789" },
                    { 2, new DateTime(1990, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "87654321", "maria.gonzalez@mail.com", "María", "González", "987654321" },
                    { 3, new DateTime(1988, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "11223344", "carlos.lopez@mail.com", "Carlos", "López", "456123789" }
                });

            migrationBuilder.InsertData(
                table: "pfDestinations",
                columns: new[] { "Id", "CategoryName", "Country", "Description", "Name", "URL_image" },
                values: new object[,]
                {
                    { 1, "Playa", "México", "Hermosa playa con arenas blancas", "Playa Paraíso", "https://imgs.search.brave.com/C5tkx-WUU6YIj0GGJZdF-TSyS_1X3UOs1eEbI6D-Xwc/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly93d3cu/Ym9va2F3YXkuY29t/L2Jsb2cvd3AtY29u/dGVudC91cGxvYWRz/LzIwMjMvMDEvUGxh/eWEtcGFyYWlzby0u/anBn" },
                    { 2, "Montaña", "Chile", "Montaña con vistas espectaculares", "Montaña Encantada", "https://lh3.googleusercontent.com/proxy/qJ0tsxrv8qWp0gUPwGcvY4SROCGlCNHt7chgRwCnBIiTLuUQQWnW54L1uCkqp34-LfqzWKOtd0Dkru_PlN7o8kghewZi0Xecoyg5hna7B-AiwkFfLQ" },
                    { 3, "Aventura", "Brasil", "Experiencia en la selva", "Selva Amazónica", "https://www.cronista.com/files/image/658/658401/64d235435ebc6.jpg" }
                });

            migrationBuilder.InsertData(
                table: "pfItineraries",
                columns: new[] { "Id", "DepartureDate", "Description", "Name", "ReturnDate", "pfDestinationId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "10 días en la playa", "Aventura en Playa", new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caminatas y exploración de montañas", "Exploración en Montaña", new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Recorrido en la selva amazónica", "Selva Amazónica Tour", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "pfActivities",
                columns: new[] { "Id", "ActivityName", "Cost", "Description", "DestinationId", "Duration", "URLimage", "pfItineraryId" },
                values: new object[,]
                {
                    { 1, "Buceo en Playa", 50.00m, "Buceo en arrecifes de coral", 1, 2, "https://s3-us-west-2.amazonaws.com/wp-divingyucatan/wp-content/uploads/2020/03/30181654/diving-yucatan-ventajas-buceo.jpeg", null },
                    { 2, "Escalada en Montaña", 75.00m, "Escalada guiada en roca", 2, 4, "https://aamtuc.org/wp-content/uploads/2020/08/Presentaci%C3%B3n.jpg", null },
                    { 3, "Safari en la Selva", 100.00m, "Exploración en la selva amazónica", 3, 3, "https://admin.panrotas.com.br/media/thumb/cropper/permalink/fix/1200,675/?source=media-files-original/2016/02/15/2c5c6ad76509fc0e15b9faefc7c72cdb-dorobosafaristanzania150216.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "pfReservations",
                columns: new[] { "Id", "ClientId", "DestinationId", "ItineraryId", "ReservationDate", "ReservationStatus" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, new DateTime(2024, 11, 4, 18, 25, 24, 320, DateTimeKind.Local).AddTicks(7757), 0 },
                    { 2, 2, 2, 2, new DateTime(2024, 11, 4, 18, 25, 24, 320, DateTimeKind.Local).AddTicks(7772), 1 },
                    { 3, 3, 3, 3, new DateTime(2024, 11, 4, 18, 25, 24, 320, DateTimeKind.Local).AddTicks(7773), 2 }
                });

            migrationBuilder.InsertData(
                table: "pfTransactions",
                columns: new[] { "Id", "Amount", "ClientId", "PaymentConfirmation", "PaymentMethod", "TransactionDate" },
                values: new object[,]
                {
                    { 1, 150.00m, 1, 1, 1, new DateTime(2024, 11, 4, 18, 25, 24, 320, DateTimeKind.Local).AddTicks(7806) },
                    { 2, 200.00m, 2, 0, 4, new DateTime(2024, 11, 4, 18, 25, 24, 320, DateTimeKind.Local).AddTicks(7809) },
                    { 3, 120.00m, 3, 2, 3, new DateTime(2024, 11, 4, 18, 25, 24, 320, DateTimeKind.Local).AddTicks(7810) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_pfActivities_DestinationId",
                table: "pfActivities",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_pfActivities_pfItineraryId",
                table: "pfActivities",
                column: "pfItineraryId");

            migrationBuilder.CreateIndex(
                name: "IX_pfItineraries_pfDestinationId",
                table: "pfItineraries",
                column: "pfDestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_pfReservations_ClientId",
                table: "pfReservations",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_pfReservations_DestinationId",
                table: "pfReservations",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_pfReservations_ItineraryId",
                table: "pfReservations",
                column: "ItineraryId");

            migrationBuilder.CreateIndex(
                name: "IX_pfTransactions_ClientId",
                table: "pfTransactions",
                column: "ClientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pfActivities");

            migrationBuilder.DropTable(
                name: "pfAdministrators");

            migrationBuilder.DropTable(
                name: "pfReservations");

            migrationBuilder.DropTable(
                name: "pfTransactions");

            migrationBuilder.DropTable(
                name: "pfItineraries");

            migrationBuilder.DropTable(
                name: "pfClients");

            migrationBuilder.DropTable(
                name: "pfDestinations");
        }
    }
}
