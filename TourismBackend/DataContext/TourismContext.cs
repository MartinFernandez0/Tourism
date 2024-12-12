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
            //Configuracion de modelos

            //Configurar la relación uno a muchos entre pfDestination y pfItinerary
            modelBuilder.Entity<pfItinerary>()
                .HasOne(i => i.Destination)
                .WithMany(d => d.Itineraries)
                .HasForeignKey(i => i.DestinationId)
                .OnDelete(DeleteBehavior.Restrict);
            
            // Configurar la relación uno a muchos entre pfDestination y pfActivity
            modelBuilder.Entity<pfActivity>()
                .HasOne(a => a.Destination)
                .WithMany(d => d.Activities)
                .HasForeignKey(a => a.DestinationId)
                .OnDelete(DeleteBehavior.Restrict);

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


            // Datos semilla para pfDestination
            modelBuilder.Entity<pfDestination>().HasData(
                new pfDestination
                {
                    Id = 1,
                    Name = "Cataratas del Iguazú",
                    Description = "Maravilla natural en la provincia de Misiones.",
                    URL_image = "https://www.iguazujungle.com/esp/web2/images/Web%20192016.jpg",
                    CategoryName = "Natural",
                    Country = "Argentina",
                    IsDeleted = false
                },
                new pfDestination
                {
                    Id = 2,
                    Name = "Buenos Aires",
                    Description = "Capital cosmopolita de Argentina con rica vida cultural.",
                    URL_image = "https://s3.amazonaws.com/arc-wordpress-client-uploads/infobae-wp/wp-content/uploads/2019/07/03201757/Ciudades-mas-caras-de-America-Latina-Buenos-Aires.jpg",
                    CategoryName = "Cultural",
                    Country = "Argentina",
                    IsDeleted = false
                }
            );

            // Datos semilla para pfItinerary
            modelBuilder.Entity<pfItinerary>().HasData(
                new pfItinerary
                {
                    Id = 1,
                    Name = "Aventura en las Cataratas",
                    DepartureDate = new DateTime(2024, 12, 1),
                    ReturnDate = new DateTime(2024, 12, 5),
                    Description = "Viaje a las Cataratas del Iguazú con actividades de aventura.",
                    DestinationId = 1,
                    IsDeleted = false
                },

                new pfItinerary
                {
                    Id = 2,
                    Name = "Cultura en Buenos Aires",
                    DepartureDate = new DateTime(2024, 12, 10),
                    ReturnDate = new DateTime(2024, 12, 15),
                    Description = "Viaje a Buenos Aires con actividades culturales.",
                    DestinationId = 2,
                    IsDeleted = false
                }
            );


            // Datos semilla para pfActivity
            modelBuilder.Entity<pfActivity>().HasData(
                new pfActivity
                {
                    Id = 1,
                    ActivityName = "Caminata por las Cataratas del Iguazú",
                    URLimage = "https://media.tacdn.com/media/attractions-splice-spp-360x240/0a/dd/10/25.jpg",
                    Duration = 180,
                    Cost = 75.00m,
                    Description = "Exploración a pie por los senderos de las Cataratas del Iguazú.",
                    DestinationId = 1,
                    IsDeleted = false
                },

                new pfActivity
                {
                    Id = 2,
                    ActivityName = "Visita a la Casa Rosada",
                    URLimage = "https://media.tacdn.com/media/attractions-splice-spp-674x446/06/70/5f/c2.jpg",
                    Duration = 120,
                    Cost = 50.00m,
                    Description = "Visita a la Casa Rosada de Buenos Aires.",
                    DestinationId = 2,
                    IsDeleted = false
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
                    Birthdate = new DateTime(1990, 1, 1),
                    CustomerGender = CustomerGenderEnum.Femenino,

                    Email = "ana.gomez@example.com",
                    PhoneNumber = "987654321",
                    Address = "Calle Falsa 123",
                    City = "Springfield",
                    Country = "Estados Unidos",
                    PostalCode = "12345",

                    AccommodationPreference = AccommodationPreferenceEnum.Hotel,
                    FoodPreference = FoodPreferenceEnum.Vegetariano,
                    DestinationId = 1,
                    ActivityId = 1,

                    NumberOfPeople = 2,
                    ReservationDate = DateTime.Now,
                    ReservationStatus = ReservationStatusEnum.Confirmado,
                    ItineraryId = 1,

                    PaymentMethod = PaymentMethodEnum.Efectivo,
                    PaymentConfirmation = PaymentConfirmationEnum.Confirmado,
                    TransactionDate = DateTime.Now,
                    TotalAmount = 150000.00m,

                    IsDeleted = false
                }
            );
        }
    }
}
