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
                    ActivityName = "Tour por la Ciudad de Buenos Aires",
                    URLimage = "https://media.tacdn.com/media/attractions-splice-spp-674x446/06/70/5f/c2.jpg",
                    Duration = 240,
                    Cost = 30.00m,
                    Description = "Visita guiada por los principales puntos turísticos de la capital.",
                    DestinationId = 2,
                    IsDeleted = false
                },
                new pfActivity
                {
                    Id = 3,
                    ActivityName = "Avistamiento de Ballenas en Puerto Madryn",
                    URLimage = "https://allpeninsulavaldes.com/sistema/img/excursiones/grandes/263-3.jpg",
                    Duration = 150,
                    Cost = 90.00m,
                    Description = "Excursión en barco para avistar ballenas y otros animales marinos.",
                    DestinationId = 3,
                    IsDeleted = false
                },
                new pfActivity
                {
                    Id = 4,
                    ActivityName = "Trekking en El Chaltén",
                    URLimage = "https://www.plataforma10.com.ar/viajes/wp-content/uploads/2023/06/trekking.webp",
                    Duration = 240,
                    Cost = 50.00m,
                    Description = "Caminata de montaña en el Parque Nacional Los Glaciares.",
                    DestinationId = 4,
                    IsDeleted = false
                },
                new pfActivity
                {
                    Id = 5,
                    ActivityName = "Visita a la Ruta del Vino en Mendoza",
                    URLimage = "https://media.ambito.com/p/e8fc9ddae9ad73bb1106428b5ecc8df0/adjuntos/239/imagenes/040/285/0040285478/1200x675/smart/ruta-del-vinojpg.jpg",
                    Duration = 180,
                    Cost = 100.00m,
                    Description = "Tour por las bodegas y viñedos de Mendoza con degustación incluida.",
                    DestinationId = 5,
                    IsDeleted = false
                },
                new pfActivity
                {
                    Id = 6,
                    ActivityName = "Navegación por el Delta del Tigre",
                    URLimage = "https://www.patagoniatraveler.com/images/modulos/turismo/excursiones/40/galeria/693_02Banner.jpg",
                    Duration = 120,
                    Cost = 40.00m,
                    Description = "Paseo en lancha por los canales del Delta del Tigre.",
                    DestinationId = 6,
                    IsDeleted = false
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
                    ItineraryId = null,
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
                    ItineraryId = null,
                    IsDeleted = false
                },
                new pfDestination
                {
                    Id = 3,
                    Name = "Puerto Madryn",
                    Description = "Destino destacado para el avistamiento de fauna marina.",
                    URL_image = "https://contrapunto.digital/madryn/wp-content/uploads/2024/03/puerto-madryn.webp",
                    CategoryName = "Natural",
                    Country = "Argentina",
                    ItineraryId = null,
                    IsDeleted = false
                },
                new pfDestination
                {
                    Id = 4,
                    Name = "El Chaltén",
                    Description = "Capital nacional del trekking, ubicada en el Parque Nacional Los Glaciares.",
                    URL_image = "https://imgs1000.s3.sa-east-1.amazonaws.com/arroyo-del-salto2.jpg",
                    CategoryName = "Natural",
                    Country = "Argentina",
                    ItineraryId = null,
                    IsDeleted = false
                },
                new pfDestination
                {
                    Id = 5,
                    Name = "Mendoza",
                    Description = "Región vinícola famosa por sus bodegas y paisajes andinos.",
                    URL_image = "https://fotos.perfil.com/2023/07/13/bodega-catena-zapata-1609412.jpg",
                    CategoryName = "Gastronomical",
                    Country = "Argentina",
                    ItineraryId = null,
                    IsDeleted = false
                },
                new pfDestination
                {
                    Id = 6,
                    Name = "Delta del Tigre",
                    Description = "Hermoso delta con numerosos canales e islas cerca de Buenos Aires.",
                    URL_image = "https://universes.art/fileadmin/user_upload/Art-Destinations/Argentina/Buenos-Aires/Tigre-Delta/00-IMG_6089-2000-750.jpg",
                    CategoryName = "Natural",
                    Country = "Argentina",
                    ItineraryId = null,
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
                    ActivityId = 1,
                    IsDeleted = false
                },
                new pfItinerary
                {
                    Id = 2,
                    Name = "Tour Cultural por Buenos Aires",
                    DepartureDate = new DateTime(2024, 12, 7),
                    ReturnDate = new DateTime(2024, 12, 10),
                    Description = "Recorrido por los principales puntos turísticos de Buenos Aires.",
                    ActivityId = 2,
                    IsDeleted = false
                },
                new pfItinerary
                {
                    Id = 3,
                    Name = "Exploración Marina en Puerto Madryn",
                    DepartureDate = new DateTime(2024, 12, 12),
                    ReturnDate = new DateTime(2024, 12, 15),
                    Description = "Excursión para avistar ballenas y explorar la fauna marina.",
                    ActivityId = 3,
                    IsDeleted = false
                },
                new pfItinerary
                {
                    Id = 4,
                    Name = "Trekking en El Chaltén",
                    DepartureDate = new DateTime(2024, 12, 17),
                    ReturnDate = new DateTime(2024, 12, 20),
                    Description = "Caminata de montaña en el Parque Nacional Los Glaciares.",
                    ActivityId = 4,
                    IsDeleted = false
                },
                new pfItinerary
                {
                    Id = 5,
                    Name = "Ruta del Vino en Mendoza",
                    DepartureDate = new DateTime(2024, 12, 22),
                    ReturnDate = new DateTime(2024, 12, 25),
                    Description = "Tour por las bodegas y viñedos de Mendoza con degustación incluida.",
                    ActivityId = 5,
                    IsDeleted = false
                },
                new pfItinerary
                {
                    Id = 6,
                    Name = "Navegación por el Delta del Tigre",
                    DepartureDate = new DateTime(2024, 12, 27),
                    ReturnDate = new DateTime(2024, 12, 30),
                    Description = "Paseo en lancha por los canales del Delta del Tigre.",
                    ActivityId = 6,
                    IsDeleted = false
                }
            );
        }
    }
}
