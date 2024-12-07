﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TourismBackend.DataContext;

#nullable disable

namespace TourismBackend.Migrations
{
    [DbContext(typeof(TourismContext))]
    partial class TourismContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("TourismServices.Models.pfActivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ActivityName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("URLimage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DestinationId");

                    b.ToTable("pfActivities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActivityName = "Caminata por las Cataratas del Iguazú",
                            Cost = 75.00m,
                            Description = "Exploración a pie por los senderos de las Cataratas del Iguazú.",
                            DestinationId = 1,
                            Duration = 180,
                            IsDeleted = false,
                            URLimage = "https://media.tacdn.com/media/attractions-splice-spp-360x240/0a/dd/10/25.jpg"
                        },
                        new
                        {
                            Id = 2,
                            ActivityName = "Tour por la Ciudad de Buenos Aires",
                            Cost = 30.00m,
                            Description = "Visita guiada por los principales puntos turísticos de la capital.",
                            DestinationId = 2,
                            Duration = 240,
                            IsDeleted = false,
                            URLimage = "https://media.tacdn.com/media/attractions-splice-spp-674x446/06/70/5f/c2.jpg"
                        },
                        new
                        {
                            Id = 3,
                            ActivityName = "Avistamiento de Ballenas en Puerto Madryn",
                            Cost = 90.00m,
                            Description = "Excursión en barco para avistar ballenas y otros animales marinos.",
                            DestinationId = 3,
                            Duration = 150,
                            IsDeleted = false,
                            URLimage = "https://allpeninsulavaldes.com/sistema/img/excursiones/grandes/263-3.jpg"
                        },
                        new
                        {
                            Id = 4,
                            ActivityName = "Trekking en El Chaltén",
                            Cost = 50.00m,
                            Description = "Caminata de montaña en el Parque Nacional Los Glaciares.",
                            DestinationId = 4,
                            Duration = 240,
                            IsDeleted = false,
                            URLimage = "https://www.plataforma10.com.ar/viajes/wp-content/uploads/2023/06/trekking.webp"
                        },
                        new
                        {
                            Id = 5,
                            ActivityName = "Visita a la Ruta del Vino en Mendoza",
                            Cost = 100.00m,
                            Description = "Tour por las bodegas y viñedos de Mendoza con degustación incluida.",
                            DestinationId = 5,
                            Duration = 180,
                            IsDeleted = false,
                            URLimage = "https://media.ambito.com/p/e8fc9ddae9ad73bb1106428b5ecc8df0/adjuntos/239/imagenes/040/285/0040285478/1200x675/smart/ruta-del-vinojpg.jpg"
                        },
                        new
                        {
                            Id = 6,
                            ActivityName = "Navegación por el Delta del Tigre",
                            Cost = 40.00m,
                            Description = "Paseo en lancha por los canales del Delta del Tigre.",
                            DestinationId = 6,
                            Duration = 120,
                            IsDeleted = false,
                            URLimage = "https://www.patagoniatraveler.com/images/modulos/turismo/excursiones/40/galeria/693_02Banner.jpg"
                        });
                });

            modelBuilder.Entity("TourismServices.Models.pfAdministrator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("pfAdministrators");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "martinexefe@example.com",
                            IsDeleted = false,
                            LastName = "Fernandez",
                            Name = "Martin",
                            Phone = "123456789",
                            RegistrationDate = new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("TourismServices.Models.pfClient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("pfClients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateBirth = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Document = "12345678",
                            Email = "ana.gomez@example.com",
                            FirstName = "Ana",
                            IsDeleted = false,
                            LastName = "Gómez",
                            PhoneNumber = "987654321"
                        },
                        new
                        {
                            Id = 2,
                            DateBirth = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Document = "87654321",
                            Email = "juanperez@example.com",
                            FirstName = "Juan",
                            IsDeleted = false,
                            LastName = "Pérez",
                            PhoneNumber = "123456789"
                        });
                });

            modelBuilder.Entity("TourismServices.Models.pfDestination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("ItineraryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("URL_image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ItineraryId");

                    b.ToTable("pfDestinations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Natural",
                            Country = "Argentina",
                            Description = "Maravilla natural en la provincia de Misiones.",
                            IsDeleted = false,
                            Name = "Cataratas del Iguazú",
                            URL_image = "https://www.iguazujungle.com/esp/web2/images/Web%20192016.jpg"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Cultural",
                            Country = "Argentina",
                            Description = "Capital cosmopolita de Argentina con rica vida cultural.",
                            IsDeleted = false,
                            Name = "Buenos Aires",
                            URL_image = "https://s3.amazonaws.com/arc-wordpress-client-uploads/infobae-wp/wp-content/uploads/2019/07/03201757/Ciudades-mas-caras-de-America-Latina-Buenos-Aires.jpg"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Natural",
                            Country = "Argentina",
                            Description = "Destino destacado para el avistamiento de fauna marina.",
                            IsDeleted = false,
                            Name = "Puerto Madryn",
                            URL_image = "https://contrapunto.digital/madryn/wp-content/uploads/2024/03/puerto-madryn.webp"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Natural",
                            Country = "Argentina",
                            Description = "Capital nacional del trekking, ubicada en el Parque Nacional Los Glaciares.",
                            IsDeleted = false,
                            Name = "El Chaltén",
                            URL_image = "https://imgs1000.s3.sa-east-1.amazonaws.com/arroyo-del-salto2.jpg"
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Gastronomical",
                            Country = "Argentina",
                            Description = "Región vinícola famosa por sus bodegas y paisajes andinos.",
                            IsDeleted = false,
                            Name = "Mendoza",
                            URL_image = "https://fotos.perfil.com/2023/07/13/bodega-catena-zapata-1609412.jpg"
                        },
                        new
                        {
                            Id = 6,
                            CategoryName = "Natural",
                            Country = "Argentina",
                            Description = "Hermoso delta con numerosos canales e islas cerca de Buenos Aires.",
                            IsDeleted = false,
                            Name = "Delta del Tigre",
                            URL_image = "https://universes.art/fileadmin/user_upload/Art-Destinations/Argentina/Buenos-Aires/Tigre-Delta/00-IMG_6089-2000-750.jpg"
                        });
                });

            modelBuilder.Entity("TourismServices.Models.pfItinerary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ActivityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.ToTable("pfItineraries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActivityId = 1,
                            DepartureDate = new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Viaje a las Cataratas del Iguazú con actividades de aventura.",
                            IsDeleted = false,
                            Name = "Aventura en las Cataratas",
                            ReturnDate = new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            ActivityId = 2,
                            DepartureDate = new DateTime(2024, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Recorrido por los principales puntos turísticos de Buenos Aires.",
                            IsDeleted = false,
                            Name = "Tour Cultural por Buenos Aires",
                            ReturnDate = new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            ActivityId = 3,
                            DepartureDate = new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Excursión para avistar ballenas y explorar la fauna marina.",
                            IsDeleted = false,
                            Name = "Exploración Marina en Puerto Madryn",
                            ReturnDate = new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            ActivityId = 4,
                            DepartureDate = new DateTime(2024, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Caminata de montaña en el Parque Nacional Los Glaciares.",
                            IsDeleted = false,
                            Name = "Trekking en El Chaltén",
                            ReturnDate = new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            ActivityId = 5,
                            DepartureDate = new DateTime(2024, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Tour por las bodegas y viñedos de Mendoza con degustación incluida.",
                            IsDeleted = false,
                            Name = "Ruta del Vino en Mendoza",
                            ReturnDate = new DateTime(2024, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            ActivityId = 6,
                            DepartureDate = new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Paseo en lancha por los canales del Delta del Tigre.",
                            IsDeleted = false,
                            Name = "Navegación por el Delta del Tigre",
                            ReturnDate = new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("TourismServices.Models.pfReservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DestinationId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("ItineraryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ReservationStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DestinationId");

                    b.HasIndex("ItineraryId");

                    b.ToTable("pfReservations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DestinationId = 1,
                            IsDeleted = false,
                            ItineraryId = 1,
                            ReservationDate = new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReservationStatus = 0
                        },
                        new
                        {
                            Id = 2,
                            DestinationId = 2,
                            IsDeleted = false,
                            ItineraryId = 2,
                            ReservationDate = new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReservationStatus = 0
                        });
                });

            modelBuilder.Entity("TourismServices.Models.pfTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("PaymentConfirmation")
                        .HasColumnType("int");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("pfTransactions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 100.00m,
                            IsDeleted = false,
                            PaymentConfirmation = 1,
                            PaymentMethod = 1,
                            TransactionDate = new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amount = 100.00m,
                            IsDeleted = false,
                            PaymentConfirmation = 1,
                            PaymentMethod = 1,
                            TransactionDate = new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("TourismServices.Models.pfActivity", b =>
                {
                    b.HasOne("TourismServices.Models.pfDestination", "Destination")
                        .WithMany()
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Destination");
                });

            modelBuilder.Entity("TourismServices.Models.pfDestination", b =>
                {
                    b.HasOne("TourismServices.Models.pfItinerary", "Itinerary")
                        .WithMany()
                        .HasForeignKey("ItineraryId");

                    b.Navigation("Itinerary");
                });

            modelBuilder.Entity("TourismServices.Models.pfItinerary", b =>
                {
                    b.HasOne("TourismServices.Models.pfActivity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId");

                    b.Navigation("Activity");
                });

            modelBuilder.Entity("TourismServices.Models.pfReservation", b =>
                {
                    b.HasOne("TourismServices.Models.pfDestination", "Destination")
                        .WithMany()
                        .HasForeignKey("DestinationId");

                    b.HasOne("TourismServices.Models.pfItinerary", "Itinerary")
                        .WithMany()
                        .HasForeignKey("ItineraryId");

                    b.Navigation("Destination");

                    b.Navigation("Itinerary");
                });
#pragma warning restore 612, 618
        }
    }
}
