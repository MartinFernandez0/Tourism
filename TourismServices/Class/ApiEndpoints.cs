
namespace TourismServices.Class
{
    public static class ApiEndpoints
    {
        public static string pfActivity { get; set; } = "pfActivities";
        public static string pfAdministrator { get; set; } = "pfAdministrators";
        public static string pfClient { get; set; } = "pfClients";
        public static string pfDestination { get; set; } = "pfDestinations";
        public static string pfItinerary { get; set; } = "pfItineraries";

        public static string GetEndpoint(string name)
        {
            return name switch
            {
                nameof(pfActivity) => pfActivity,
                nameof(pfAdministrator) => pfAdministrator,
                nameof(pfDestination) => pfDestination,
                nameof(pfItinerary) => pfItinerary,
                nameof(pfClient) => pfClient,

                _ => throw new ArgumentException($"Endpoint '{name}' no está definido.")
            };
        }
    }
}
