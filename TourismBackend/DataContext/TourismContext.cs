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
                }
            );

            // Datos semilla para pfAdministrator
            modelBuilder.Entity<pfAdministrator>().HasData(
                new pfAdministrator
                {
                    Id = 1,
                    Name = "Juan",
                    LastName = "Pérez",
                    Email = "juan.perez@example.com",
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
                    ReservationId = null,
                    TransactionId = null,
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
                }
            );
        }

    }
}
