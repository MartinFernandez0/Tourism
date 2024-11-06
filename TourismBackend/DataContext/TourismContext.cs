using Microsoft.EntityFrameworkCore;
using TourismServices.Models;
using TourismServices.Enums;


namespace TourismBackend.DataContext
{
    public partial class TourismContext : DbContext
    {
        public TourismContext()
        {
        }
        public TourismContext(DbContextOptions<TourismContext> options) : base(options)
        {
        }

        // DbSets for your models in the specified order
        public DbSet<pfAdministrator> pfAdministrators { get; set; }
        public DbSet<pfClient> pfClients { get; set; }
        public DbSet<pfActivity> pfActivities { get; set; }
        public DbSet<pfDestination> pfDestinations { get; set; }
        public DbSet<pfItinerary> pfItineraries { get; set; }
        public DbSet<pfReservation> pfReservations { get; set; }
        public DbSet<pfTransaction> pfTransactions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();
            string? cadenaConexion = configuration.GetConnectionString("mysqlRemoto");

            optionsBuilder.UseMySql(cadenaConexion, ServerVersion.AutoDetect(cadenaConexion));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Datos semilla para pfActivity
            modelBuilder.Entity<pfActivity>().HasData(
                new pfActivity
                {
                    Id = 1,
                    ActivityName = "Visita a las Ruinas",
                    URLimage = "https://images.adsttc.com/media/images/5d85/0ef9/284d/d153/e100/0165/newsletter/San_Ignacio_Min%C3%AD_mission_ruins.jpg?1569001197",
                    Duration = 120,
                    Cost = 50.00m,
                    Description = "Recorrido por las ruinas antiguas.",
                    DestinationId = 1,
                    IsDeleted = false
                },
                new pfActivity
                {
                    Id = 2,
                    ActivityName = "Visita a la Ciudad",
                    URLimage = "https://images.adsttc.com/media/images/5d85/0ef9/284d/d153/e100/0165/newsletter/San_Ignacio_Min%C3%AD_mission_ruins.jpg?1569001197",
                    Duration = 120,
                    Cost = 50.00m,
                    Description = "Recorrido por la ciudad antigua.",
                    DestinationId = 2,
                    IsDeleted = false
                },
                new pfActivity
                {
                    Id = 3,
                    ActivityName = "Visita a la Montaña",
                    URLimage = "https://images.adsttc.com/media/images/5d85/0ef9/284d/d153/e100/0165/newsletter/San_Ignacio_Min%C3%AD_mission_ruins.jpg?1569001197",
                    Duration = 120,
                    Cost = 50.00m,
                    Description = "Recorrido por la montaña antigua.",
                    DestinationId = 3,
                    IsDeleted = false
                },
                new pfActivity
                {
                    Id = 4,
                    ActivityName = "Visita a la Playa",
                    URLimage = "https://images.adsttc.com/media/images/5d85/0ef9/284d/d153/e100/0165/newsletter/San_Ignacio_Min%C3%AD_mission_ruins.jpg?1569001197",
                    Duration = 120,
                    Cost = 50.00m,
                    Description = "Recorrido por la playa antigua.",
                    DestinationId = 4,
                    IsDeleted = false
                },
                new pfActivity
                {
                    Id = 5,
                    ActivityName = "Visita a la Ciudad",
                    URLimage = "https://images.adsttc.com/media/images/5d85/0ef9/284d/d153/e100/0165/newsletter/San_Ignacio_Min%C3%AD_mission_ruins.jpg?1569001197",
                    Duration = 120,
                    Cost = 50.00m,
                    Description = "Recorrido por la ciudad antigua.",
                    DestinationId = 5,
                    IsDeleted = false
                },
                new pfActivity
                {
                    Id = 6,
                    ActivityName = "Visita a la Ciudad",
                    URLimage = "https://images.adsttc.com/media/images/5d85/0ef9/284d/d153/e100/0165/newsletter/San_Ignacio_Min%C3%AD_mission_ruins.jpg?1569001197",
                    Duration = 120,
                    Cost = 50.00m,
                    Description = "Recorrido por la ciudad antigua.",
                    DestinationId = 6,
                    IsDeleted = false
                }
            );

            // Datos semilla para pfAdministrator
            modelBuilder.Entity<pfAdministrator>().HasData(
                new pfAdministrator
                {
                    Id = 1,
                    Name = "Martin",
                    LastName = "Fernandez",
                    Email = "martinexefe@example.com",
                    Phone = "123456789",
                    RegistrationDate = new DateTime(2024, 11, 1)
                }
            );

            // Datos semilla para pfClient
            modelBuilder.Entity<pfClient>().HasData(
                new pfClient
                {
                    Id = 1,
                    FirstName = "Ana",
                    LastName = "Gómez",
                    Document = "12345678",
                    Email = "ana.gomez@example.com",
                    PhoneNumber = "987654321",
                    DateBirth = new DateTime(1990, 1, 1),
                    ReservationId = 1,
                    TransactionId = 1,
                    IsDeleted = false
                },
                new pfClient
                {
                    Id = 2,
                    FirstName = "Juan",
                    LastName = "Pérez",
                    Document = "87654321",
                    Email = "juanperez@example.com",
                    PhoneNumber = "123456789",
                    DateBirth = new DateTime(1990, 1, 1),
                    ReservationId = 2,
                    TransactionId = 2,
                    IsDeleted = false
                }
            );

            // Datos semilla para pfDestination
            modelBuilder.Entity<pfDestination>().HasData(
                new pfDestination
                {
                    Id = 1,
                    Name = "Machu Picchu",
                    Description = "Antigua ciudad inca.",
                    URL_image = "https://images.adsttc.com/media/images/5d85/0ef9/284d/d153/e100/0165/newsletter/San_Ignacio_Min%C3%AD_mission_ruins.jpg?1569001197",
                    CategoryName = "Cultural",
                    Country = "Perú",
                    ItineraryId = null,
                    IsDeleted = false
                },
                new pfDestination
                {
                    Id = 2,
                    Name = "Machu Picchu",
                    Description = "Antigua ciudad inca.",
                    URL_image = "https://images.adsttc.com/media/images/5d85/0ef9/284d/d153/e100/0165/newsletter/San_Ignacio_Min%C3%AD_mission_ruins.jpg?1569001197",
                    CategoryName = "Cultural",
                    Country = "Perú",
                    ItineraryId = null,
                    IsDeleted = false
                },
                new pfDestination
                {
                    Id = 3,
                    Name = "Eiffel Tower",
                    Description = "Icono arquitectónico de París, Francia.",
                    URL_image = "https://upload.wikimedia.org/wikipedia/commons/a/a8/Eiffel_Tower_Paris_2011.jpg",
                    CategoryName = "Landmark",
                    Country = "Francia",
                    ItineraryId = null,
                    IsDeleted = false
                },
                new pfDestination
                {
                    Id = 4,
                    Name = "Great Wall of China",
                    Description = "Murallas que se extienden por miles de kilómetros.",
                    URL_image = "https://upload.wikimedia.org/wikipedia/commons/4/43/Great_Wall_of_China_Mutianyu_Section.jpg",
                    CategoryName = "Historic",
                    Country = "China",
                    ItineraryId = null,
                    IsDeleted = false
                },
                new pfDestination
                {
                    Id = 5,
                    Name = "Sydney Opera House",
                    Description = "Famoso centro de artes escénicas en Australia.",
                    URL_image = "https://upload.wikimedia.org/wikipedia/commons/4/4e/Sydney_Opera_House_Sails.jpg",
                    CategoryName = "Cultural",
                    Country = "Australia",
                    ItineraryId = null,
                    IsDeleted = false
                },
                new pfDestination
                {
                    Id = 6,
                    Name = "Colosseum",
                    Description = "Antiguo anfiteatro romano en el centro de Roma.",
                    URL_image = "https://upload.wikimedia.org/wikipedia/commons/7/7f/Colosseo_2020.jpg",
                    CategoryName = "Historic",
                    Country = "Italia",
                    ItineraryId = null,
                    IsDeleted = false
                }


            );

            // Datos semilla para pfItinerary
            modelBuilder.Entity<pfItinerary>().HasData(
                new pfItinerary
                {
                    Id = 1,
                    Name = "Itinerario de Aventura",
                    DepartureDate = new DateTime(2024, 12, 1),
                    ReturnDate = new DateTime(2024, 12, 15),
                    Description = "Viaje a Perú con actividades de aventura.",
                    ActivityId = 1,
                    IsDeleted = false
                },
                new pfItinerary
                {
                    Id = 2,
                    Name = "Itinerario de Aventura",
                    DepartureDate = new DateTime(2024, 12, 1),
                    ReturnDate = new DateTime(2024, 12, 15),
                    Description = "Viaje a Perú con actividades de aventura.",
                    ActivityId = 2,
                    IsDeleted = false
                },
                new pfItinerary
                {
                    Id = 3,
                    Name = "Tour Cultural por París",
                    DepartureDate = new DateTime(2024, 12, 5),
                    ReturnDate = new DateTime(2024, 12, 12),
                    Description = "Recorrido cultural por los monumentos más emblemáticos de París.",
                    ActivityId = 3,
                    IsDeleted = false
                },
                new pfItinerary
                {
                    Id = 4,
                    Name = "Ruta Histórica en China",
                    DepartureDate = new DateTime(2024, 11, 20),
                    ReturnDate = new DateTime(2024, 12, 3),
                    Description = "Exploración de la Gran Muralla y sitios históricos de China.",
                    ActivityId = 4,
                    IsDeleted = false
                },
                new pfItinerary
                {
                    Id = 5,
                    Name = "Aventura Australiana",
                    DepartureDate = new DateTime(2024, 12, 10),
                    ReturnDate = new DateTime(2024, 12, 18),
                    Description = "Visita a los paisajes naturales y culturales de Australia.",
                    ActivityId = 5,
                    IsDeleted = false
                },
                new pfItinerary
                {
                    Id = 6,
                    Name = "Recorrido por la Roma Antigua",
                    DepartureDate = new DateTime(2024, 11, 25),
                    ReturnDate = new DateTime(2024, 12, 5),
                    Description = "Viaje guiado a través de los monumentos de la Roma Imperial.",
                    ActivityId = 6,
                    IsDeleted = false
                }

            );

            // Datos semilla para pfReservation
            modelBuilder.Entity<pfReservation>().HasData(
                new pfReservation
                {
                    Id = 1,
                    ReservationDate = new DateTime(2024, 11, 2),
                    ReservationStatus = ReservationStatusEnum.Confirmed,
                    ItineraryId = 1,
                    DestinationId = 1,
                    IsDeleted = false
                },
                new pfReservation
                {
                    Id = 2,
                    ReservationDate = new DateTime(2024, 11, 2),
                    ReservationStatus = ReservationStatusEnum.Confirmed,
                    ItineraryId = 2,
                    DestinationId = 2,
                    IsDeleted = false
                }
            );

            // Datos semilla para pfTransaction
            modelBuilder.Entity<pfTransaction>().HasData(
                new pfTransaction
                {
                    Id = 1,
                    Amount = 100.00m,
                    TransactionDate = new DateTime(2024, 11, 3),
                    PaymentMethod = PaymentMethodEnum.CreditCard,
                    PaymentConfirmation = PaymentConfirmationEnum.Confirmed,
                    IsDeleted = false
                },
                new pfTransaction
                {
                    Id = 2,
                    Amount = 100.00m,
                    TransactionDate = new DateTime(2024, 11, 3),
                    PaymentMethod = PaymentMethodEnum.CreditCard,
                    PaymentConfirmation = PaymentConfirmationEnum.Confirmed,
                    IsDeleted = false
                }
            );
        }

    }
}
