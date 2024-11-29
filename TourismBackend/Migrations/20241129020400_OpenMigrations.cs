using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TourismBackend.Migrations
{
    /// <inheritdoc />
    public partial class OpenMigrations : Migration
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
                columns: new[] { "Id", "Email", "IsDeleted", "LastName", "Name", "Phone", "RegistrationDate" },
                values: new object[] { 1, "martinexefe@example.com", false, "Fernandez", "Martin", "123456789", new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "pfDestinations",
                columns: new[] { "Id", "CategoryName", "Country", "Description", "IsDeleted", "ItineraryId", "Name", "URL_image" },
                values: new object[,]
                {
                    { 1, "Natural", "Argentina", "Maravilla natural en la provincia de Misiones.", false, null, "Cataratas del Iguazú", "https://www.iguazujungle.com/esp/web2/images/Web%20192016.jpg" },
                    { 2, "Cultural", "Argentina", "Capital cosmopolita de Argentina con rica vida cultural.", false, null, "Buenos Aires", "https://s3.amazonaws.com/arc-wordpress-client-uploads/infobae-wp/wp-content/uploads/2019/07/03201757/Ciudades-mas-caras-de-America-Latina-Buenos-Aires.jpg" },
                    { 3, "Natural", "Argentina", "Destino destacado para el avistamiento de fauna marina.", false, null, "Puerto Madryn", "https://contrapunto.digital/madryn/wp-content/uploads/2024/03/puerto-madryn.webp" },
                    { 4, "Natural", "Argentina", "Capital nacional del trekking, ubicada en el Parque Nacional Los Glaciares.", false, null, "El Chaltén", "https://imgs1000.s3.sa-east-1.amazonaws.com/arroyo-del-salto2.jpg" },
                    { 5, "Gastronomical", "Argentina", "Región vinícola famosa por sus bodegas y paisajes andinos.", false, null, "Mendoza", "https://fotos.perfil.com/2023/07/13/bodega-catena-zapata-1609412.jpg" },
                    { 6, "Natural", "Argentina", "Hermoso delta con numerosos canales e islas cerca de Buenos Aires.", false, null, "Delta del Tigre", "https://universes.art/fileadmin/user_upload/Art-Destinations/Argentina/Buenos-Aires/Tigre-Delta/00-IMG_6089-2000-750.jpg" }
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
                    { 1, "Caminata por las Cataratas del Iguazú", 75.00m, "Exploración a pie por los senderos de las Cataratas del Iguazú.", 1, 180, false, "https://media.tacdn.com/media/attractions-splice-spp-360x240/0a/dd/10/25.jpg" },
                    { 2, "Tour por la Ciudad de Buenos Aires", 30.00m, "Visita guiada por los principales puntos turísticos de la capital.", 2, 240, false, "https://media.tacdn.com/media/attractions-splice-spp-674x446/06/70/5f/c2.jpg" },
                    { 3, "Avistamiento de Ballenas en Puerto Madryn", 90.00m, "Excursión en barco para avistar ballenas y otros animales marinos.", 3, 150, false, "https://allpeninsulavaldes.com/sistema/img/excursiones/grandes/263-3.jpg" },
                    { 4, "Trekking en El Chaltén", 50.00m, "Caminata de montaña en el Parque Nacional Los Glaciares.", 4, 240, false, "https://www.plataforma10.com.ar/viajes/wp-content/uploads/2023/06/trekking.webp" },
                    { 5, "Visita a la Ruta del Vino en Mendoza", 100.00m, "Tour por las bodegas y viñedos de Mendoza con degustación incluida.", 5, 180, false, "https://media.ambito.com/p/e8fc9ddae9ad73bb1106428b5ecc8df0/adjuntos/239/imagenes/040/285/0040285478/1200x675/smart/ruta-del-vinojpg.jpg" },
                    { 6, "Navegación por el Delta del Tigre", 40.00m, "Paseo en lancha por los canales del Delta del Tigre.", 6, 120, false, "https://www.patagoniatraveler.com/images/modulos/turismo/excursiones/40/galeria/693_02Banner.jpg" }
                });

            migrationBuilder.InsertData(
                table: "pfItineraries",
                columns: new[] { "Id", "ActivityId", "DepartureDate", "Description", "IsDeleted", "Name", "ReturnDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Viaje a las Cataratas del Iguazú con actividades de aventura.", false, "Aventura en las Cataratas", new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2024, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Recorrido por los principales puntos turísticos de Buenos Aires.", false, "Tour Cultural por Buenos Aires", new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Excursión para avistar ballenas y explorar la fauna marina.", false, "Exploración Marina en Puerto Madryn", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, new DateTime(2024, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caminata de montaña en el Parque Nacional Los Glaciares.", false, "Trekking en El Chaltén", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, new DateTime(2024, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tour por las bodegas y viñedos de Mendoza con degustación incluida.", false, "Ruta del Vino en Mendoza", new DateTime(2024, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 6, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paseo en lancha por los canales del Delta del Tigre.", false, "Navegación por el Delta del Tigre", new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
