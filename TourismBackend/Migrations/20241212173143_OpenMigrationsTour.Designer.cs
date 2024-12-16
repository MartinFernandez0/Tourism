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
    [Migration("20241212173143_OpenMigrationsTour")]
    partial class OpenMigrationsTour
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .HasColumnType("longtext");

                    b.Property<int?>("DestinationId")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("URLimage")
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
                            ActivityName = "Visita a la Casa Rosada",
                            Cost = 50.00m,
                            Description = "Visita a la Casa Rosada de Buenos Aires.",
                            DestinationId = 2,
                            Duration = 120,
                            IsDeleted = false,
                            URLimage = "https://media.tacdn.com/media/attractions-splice-spp-674x446/06/70/5f/c2.jpg"
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

                    b.Property<int>("AccommodationPreference")
                        .HasColumnType("int");

                    b.Property<int?>("ActivityId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CustomerGender")
                        .HasColumnType("int");

                    b.Property<int?>("DestinationId")
                        .HasColumnType("int");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("FoodPreference")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("ItineraryId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("NumberOfPeople")
                        .HasColumnType("int");

                    b.Property<int>("PaymentConfirmation")
                        .HasColumnType("int");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PreferenceTransport")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ReservationStatus")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("DestinationId");

                    b.HasIndex("ItineraryId");

                    b.ToTable("pfClients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccommodationPreference = 0,
                            ActivityId = 1,
                            Address = "Calle Falsa 123",
                            Birthdate = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Springfield",
                            Country = "Estados Unidos",
                            CustomerGender = 1,
                            DestinationId = 1,
                            Document = "12345678",
                            Email = "ana.gomez@example.com",
                            FirstName = "Ana",
                            FoodPreference = 0,
                            IsDeleted = false,
                            ItineraryId = 1,
                            LastName = "Gómez",
                            NumberOfPeople = 2,
                            PaymentConfirmation = 1,
                            PaymentMethod = 0,
                            PhoneNumber = "987654321",
                            PostalCode = "12345",
                            PreferenceTransport = 0,
                            ReservationDate = new DateTime(2024, 12, 12, 14, 31, 39, 397, DateTimeKind.Local).AddTicks(5214),
                            ReservationStatus = 0,
                            TotalAmount = 150000.00m,
                            TransactionDate = new DateTime(2024, 12, 12, 14, 31, 39, 397, DateTimeKind.Local).AddTicks(5230)
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("URL_image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

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
                        });
                });

            modelBuilder.Entity("TourismServices.Models.pfItinerary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<int?>("DestinationId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("DestinationId");

                    b.ToTable("pfItineraries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartureDate = new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Viaje a las Cataratas del Iguazú con actividades de aventura.",
                            DestinationId = 1,
                            IsDeleted = false,
                            Name = "Aventura en las Cataratas",
                            ReturnDate = new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            DepartureDate = new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Viaje a Buenos Aires con actividades culturales.",
                            DestinationId = 2,
                            IsDeleted = false,
                            Name = "Cultura en Buenos Aires",
                            ReturnDate = new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("TourismServices.Models.pfActivity", b =>
                {
                    b.HasOne("TourismServices.Models.pfDestination", "Destination")
                        .WithMany("Activities")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Destination");
                });

            modelBuilder.Entity("TourismServices.Models.pfClient", b =>
                {
                    b.HasOne("TourismServices.Models.pfActivity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId");

                    b.HasOne("TourismServices.Models.pfDestination", "Destination")
                        .WithMany()
                        .HasForeignKey("DestinationId");

                    b.HasOne("TourismServices.Models.pfItinerary", "Itinerary")
                        .WithMany()
                        .HasForeignKey("ItineraryId");

                    b.Navigation("Activity");

                    b.Navigation("Destination");

                    b.Navigation("Itinerary");
                });

            modelBuilder.Entity("TourismServices.Models.pfItinerary", b =>
                {
                    b.HasOne("TourismServices.Models.pfDestination", "Destination")
                        .WithMany("Itineraries")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Destination");
                });

            modelBuilder.Entity("TourismServices.Models.pfDestination", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("Itineraries");
                });
#pragma warning restore 612, 618
        }
    }
}