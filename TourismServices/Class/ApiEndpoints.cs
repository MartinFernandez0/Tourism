
namespace TourismServices.Class
{
    public static class ApiEndpoints
    {
        public static string pfActivity { get; set; } = "pfActivities";
        public static string pfAdministrator { get; set; } = "pfAdministrators";
        public static string pfDestination { get; set; } = "pfDestinations";
        public static string pfItinerary { get; set; } = "pfItineraries";
        public static string pfReservation { get; set; } = "pfReservations";
        public static string pfTransaction { get; set; } = "pfTransactions";
        public static string pfClient { get; set; } = "pfClients";

        public static string GetEndpoint(string name)
        {
            return name switch
            {
                nameof(pfActivity) => "api/pfActivities",
                nameof(pfAdministrator) => "api/pfAdministrators",
                nameof(pfDestination) => "api/pfDestinations",
                nameof(pfItinerary) => "api/pfItineraries",
                nameof(pfReservation) => "api/pfReservations",
                nameof(pfTransaction) => "api/pfTransactions",
                nameof(pfClient) => "api/pfClients",

                _ => throw new ArgumentException($"Endpoint '{name}' no está definido.")
            };
        }
    }
}
