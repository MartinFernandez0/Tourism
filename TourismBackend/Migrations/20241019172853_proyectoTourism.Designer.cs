﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TourismBackend.DataContext;

#nullable disable

namespace TourismBackend.Migrations
{
    [DbContext(typeof(TourismContext))]
    [Migration("20241019172853_proyectoTourism")]
    partial class proyectoTourism
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("TourismServices.Models.pfActivity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("ActivityName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("URLimage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("pfActivities");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ActivityName = "Eiffel Tower Visit",
                            Cost = 30.00m,
                            Description = "Guided tour of the Eiffel Tower",
                            Duration = 3,
                            URLimage = "https://imgs.search.brave.com/ifM8jJudxdlseBcPdMm8ql0MWz9JgP3R1sugQ7Q2WzA/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9jZG4u/Y3VsdHVyYWdlbmlh/bC5jb20vZXMvaW1h/Z2VuZXMvdG9ycmUt/ZWlmZmVsLWNrZS5q/cGc_Y2xhc3M9YXJ0/aWNsZQ"
                        },
                        new
                        {
                            ID = 2,
                            ActivityName = "Hudson River Cruise",
                            Cost = 50.00m,
                            Description = "Boat tour along the Hudson River",
                            Duration = 2,
                            URLimage = "https://imgs.search.brave.com/zuhiGpSpdxrdQSGxmpnztHWQX-jfCQUae6Xa0mzj9Q8/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9hY2xt/ZWRpYS5henVyZWVk/Z2UubmV0L2Ntc21l/ZGlhL2xpYnJhcmll/cy9hY2wvaW1hZ2Vz/L2NydWlzZXMvaHVk/c29uLXJpdmVyLWNy/dWlzZXMvYWNsX3dl/YnNpdGVfNzAweDUw/MF9odWRzb25fY3J1/aXNpbmdfb3ZlcnZp/ZXcyLmpwZz9leHQ9/LmpwZw"
                        });
                });

            modelBuilder.Entity("TourismServices.Models.pfAdministrator", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

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

                    b.HasKey("ID");

                    b.ToTable("pfAdministrators");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Email = "martin_fernandez@example.com",
                            LastName = "Fernandez",
                            Name = "Martin",
                            Phone = "3498479331",
                            RegistrationDate = new DateTime(2024, 10, 19, 14, 28, 51, 352, DateTimeKind.Local).AddTicks(6212)
                        });
                });

            modelBuilder.Entity("TourismServices.Models.pfClient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DateRecorded")
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

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("pfClients");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DateRecorded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Document = "123456789",
                            Email = "client1@example.com",
                            FirstName = "Client1",
                            LastName = "LastName1",
                            PhoneNumber = "1234567890"
                        },
                        new
                        {
                            ID = 2,
                            DateRecorded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Document = "987654321",
                            Email = "client2@example.com",
                            FirstName = "Client2",
                            LastName = "LastName2",
                            PhoneNumber = "0987654321"
                        },
                        new
                        {
                            ID = 3,
                            DateRecorded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Document = "456789123",
                            Email = "client3@example.com",
                            FirstName = "Client3",
                            LastName = "LastName3",
                            PhoneNumber = "4567891230"
                        },
                        new
                        {
                            ID = 4,
                            DateRecorded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Document = "321654987",
                            Email = "client4@example.com",
                            FirstName = "Client4",
                            LastName = "LastName4",
                            PhoneNumber = "3216549870"
                        },
                        new
                        {
                            ID = 5,
                            DateRecorded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Document = "789123456",
                            Email = "client5@example.com",
                            FirstName = "Client5",
                            LastName = "LastName5",
                            PhoneNumber = "7891234560"
                        });
                });

            modelBuilder.Entity("TourismServices.Models.pfDestination", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("URL_image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("pfDestinations");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryName = "City",
                            Country = "France",
                            Description = "The City of Lights",
                            Name = "Paris",
                            URL_image = "https://imgs.search.brave.com/ifM8jJudxdlseBcPdMm8ql0MWz9JgP3R1sugQ7Q2WzA/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9jZG4u/Y3VsdHVyYWdlbmlh/bC5jb20vZXMvaW1h/Z2VuZXMvdG9ycmUt/ZWlmZmVsLWNrZS5q/cGc_Y2xhc3M9YXJ0/aWNsZQ"
                        },
                        new
                        {
                            ID = 2,
                            CategoryName = "City",
                            Country = "USA",
                            Description = "The Big Apple",
                            Name = "New York",
                            URL_image = "https://www.travel-guide.es/media/new-york.jpeg"
                        });
                });

            modelBuilder.Entity("TourismServices.Models.pfItinerary", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("DestinationID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ID");

                    b.ToTable("pfItineraries");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DepartureDate = new DateTime(2024, 10, 26, 14, 28, 51, 352, DateTimeKind.Local).AddTicks(6515),
                            Description = "Trip to Paris",
                            DestinationID = 1,
                            Name = "Paris",
                            ReturnDate = new DateTime(2024, 11, 2, 14, 28, 51, 352, DateTimeKind.Local).AddTicks(6521)
                        },
                        new
                        {
                            ID = 2,
                            DepartureDate = new DateTime(2024, 11, 9, 14, 28, 51, 352, DateTimeKind.Local).AddTicks(6523),
                            Description = "Trip to New York",
                            DestinationID = 2,
                            Name = "New York",
                            ReturnDate = new DateTime(2024, 11, 16, 14, 28, 51, 352, DateTimeKind.Local).AddTicks(6524)
                        });
                });

            modelBuilder.Entity("TourismServices.Models.pfReservation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<int>("ItineraryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ReservationStatus")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("pfReservations");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ClientID = 1,
                            ItineraryID = 1,
                            ReservationDate = new DateTime(2024, 10, 19, 14, 28, 51, 352, DateTimeKind.Local).AddTicks(6546),
                            ReservationStatus = 0
                        },
                        new
                        {
                            ID = 2,
                            ClientID = 2,
                            ItineraryID = 2,
                            ReservationDate = new DateTime(2024, 10, 19, 14, 28, 51, 352, DateTimeKind.Local).AddTicks(6548),
                            ReservationStatus = 1
                        });
                });

            modelBuilder.Entity("TourismServices.Models.pfTransaction", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<int>("PaymentConfirmation")
                        .HasColumnType("int");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ID");

                    b.ToTable("pfTransactions");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Amount = 1500.00m,
                            ClientID = 1,
                            PaymentConfirmation = 1,
                            PaymentMethod = 1,
                            TransactionDate = new DateTime(2024, 10, 19, 14, 28, 51, 352, DateTimeKind.Local).AddTicks(6571)
                        },
                        new
                        {
                            ID = 2,
                            Amount = 2000.00m,
                            ClientID = 2,
                            PaymentConfirmation = 2,
                            PaymentMethod = 1,
                            TransactionDate = new DateTime(2024, 10, 19, 14, 28, 51, 352, DateTimeKind.Local).AddTicks(6574)
                        },
                        new
                        {
                            ID = 3,
                            Amount = 500.00m,
                            ClientID = 1,
                            PaymentConfirmation = 3,
                            PaymentMethod = 4,
                            TransactionDate = new DateTime(2024, 10, 19, 14, 28, 51, 352, DateTimeKind.Local).AddTicks(6575)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
