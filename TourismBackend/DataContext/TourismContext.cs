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
            // Seed data for pfClient
            modelBuilder.Entity<pfClient>().HasData(
                new pfClient
                {
                    Id = 1,
                    FirstName = "Juan",
                    LastName = "Pérez",
                    Document = "12345678",
                    Email = "juan.perez@mail.com",
                    PhoneNumber = "123456789",
                    DateBirth = new DateTime(1985, 3, 15)
                },
                new pfClient
                {
                    Id = 2,
                    FirstName = "María",
                    LastName = "González",
                    Document = "87654321",
                    Email = "maria.gonzalez@mail.com",
                    PhoneNumber = "987654321",
                    DateBirth = new DateTime(1990, 7, 20)
                },
                new pfClient
                {
                    Id = 3,
                    FirstName = "Carlos",
                    LastName = "López",
                    Document = "11223344",
                    Email = "carlos.lopez@mail.com",
                    PhoneNumber = "456123789",
                    DateBirth = new DateTime(1988, 1, 10)
                }
            );

            // Seed data for pfDestination
            modelBuilder.Entity<pfDestination>().HasData(
                new pfDestination
                {
                    Id = 1,
                    Name = "Playa Paraíso",
                    Description = "Hermosa playa con arenas blancas",
                    URL_image = "https://imgs.search.brave.com/C5tkx-WUU6YIj0GGJZdF-TSyS_1X3UOs1eEbI6D-Xwc/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly93d3cu/Ym9va2F3YXkuY29t/L2Jsb2cvd3AtY29u/dGVudC91cGxvYWRz/LzIwMjMvMDEvUGxh/eWEtcGFyYWlzby0u/anBn",
                    CategoryName = "Playa",
                    Country = "México"
                },
                new pfDestination
                {
                    Id = 2,
                    Name = "Montaña Encantada",
                    Description = "Montaña con vistas espectaculares",
                    URL_image = "https://lh3.googleusercontent.com/proxy/qJ0tsxrv8qWp0gUPwGcvY4SROCGlCNHt7chgRwCnBIiTLuUQQWnW54L1uCkqp34-LfqzWKOtd0Dkru_PlN7o8kghewZi0Xecoyg5hna7B-AiwkFfLQ",
                    CategoryName = "Montaña",
                    Country = "Chile"
                },
                new pfDestination
                {
                    Id = 3,
                    Name = "Selva Amazónica",
                    Description = "Experiencia en la selva",
                    URL_image = "https://www.cronista.com/files/image/658/658401/64d235435ebc6.jpg",
                    CategoryName = "Aventura",
                    Country = "Brasil"

                    
                }
            );

            // Seed data for pfItinerary
            modelBuilder.Entity<pfItinerary>().HasData(
                new pfItinerary
                {
                    Id = 1,
                    Name = "Aventura en Playa",
                    DepartureDate = new DateTime(2024, 1, 10),
                    ReturnDate = new DateTime(2024, 1, 20),
                    Description = "10 días en la playa"
                },
                new pfItinerary
                {
                    Id = 2,
                    Name = "Exploración en Montaña",
                    DepartureDate = new DateTime(2024, 2, 5),
                    ReturnDate = new DateTime(2024, 2, 15),
                    Description = "Caminatas y exploración de montañas"
                },
                new pfItinerary
                {
                    Id = 3,
                    Name = "Selva Amazónica Tour",
                    DepartureDate = new DateTime(2024, 3, 1),
                    ReturnDate = new DateTime(2024, 3, 10),
                    Description = "Recorrido en la selva amazónica"
                }
            );

            // Seed data for pfActivity
            modelBuilder.Entity<pfActivity>().HasData(
                new pfActivity
                {
                    Id = 1,
                    ActivityName = "Buceo en Playa",
                    URLimage = "https://s3-us-west-2.amazonaws.com/wp-divingyucatan/wp-content/uploads/2020/03/30181654/diving-yucatan-ventajas-buceo.jpeg",
                    Duration = 2,
                    Cost = 50.00m,
                    Description = "Buceo en arrecifes de coral",
                    DestinationId = 1
                },
                new pfActivity
                {
                    Id = 2,
                    ActivityName = "Escalada en Montaña",
                    URLimage = "https://aamtuc.org/wp-content/uploads/2020/08/Presentaci%C3%B3n.jpg",
                    Duration = 4,
                    Cost = 75.00m,
                    Description = "Escalada guiada en roca",
                    DestinationId = 2
                },
                new pfActivity
                {
                    Id = 3,
                    ActivityName = "Safari en la Selva",
                    URLimage = "https://admin.panrotas.com.br/media/thumb/cropper/permalink/fix/1200,675/?source=media-files-original/2016/02/15/2c5c6ad76509fc0e15b9faefc7c72cdb-dorobosafaristanzania150216.jpg",
                    Duration = 3,
                    Cost = 100.00m,
                    Description = "Exploración en la selva amazónica",
                    DestinationId = 3
                }
            );

            // Seed data for pfReservation
            modelBuilder.Entity<pfReservation>().HasData(
                new pfReservation
                {
                    Id = 1,
                    ItineraryId = 1,
                    ClientId = 1,
                    DestinationId = 1,
                    ReservationDate = DateTime.Now,
                    ReservationStatus = ReservationStatusEnum.Confirmed
                },
                new pfReservation
                {
                    Id = 2,
                    ItineraryId = 2,
                    ClientId = 2,
                    DestinationId = 2,
                    ReservationDate = DateTime.Now,
                    ReservationStatus = ReservationStatusEnum.Pending
                },
                new pfReservation
                {
                    Id = 3,
                    ItineraryId = 3,
                    ClientId = 3,
                    DestinationId = 3,
                    ReservationDate = DateTime.Now,
                    ReservationStatus = ReservationStatusEnum.Cancelled
                }
            );

            // Seed data for pfTransaction
            modelBuilder.Entity<pfTransaction>().HasData(
                new pfTransaction
                {
                    Id = 1,
                    ClientId = 1,
                    Amount = 150.00m,
                    TransactionDate = DateTime.Now,
                    PaymentMethod = PaymentMethodEnum.CreditCard,
                    PaymentConfirmation = PaymentConfirmationEnum.Confirmed
                },
                new pfTransaction
                {
                    Id = 2,
                    ClientId = 2,
                    Amount = 200.00m,
                    TransactionDate = DateTime.Now,
                    PaymentMethod = PaymentMethodEnum.PayPal,
                    PaymentConfirmation = PaymentConfirmationEnum.Pending
                },
                new pfTransaction
                {
                    Id = 3,
                    ClientId = 3,
                    Amount = 120.00m,
                    TransactionDate = DateTime.Now,
                    PaymentMethod = PaymentMethodEnum.BankTransfer,
                    PaymentConfirmation = PaymentConfirmationEnum.Rejected
                }
            );

        }
    }
}
