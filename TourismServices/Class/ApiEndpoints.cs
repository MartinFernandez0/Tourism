using System;
using System.Net;
using Microsoft.EntityFrameworkCore;

namespace TourismServices.Class
{
    public static class ApiEndpoints
    {
        public static string pfActivity { get; set; } = "Activity";
        public static string pfAdministrator { get; set; } = "Administrator";
        public static string pfDestination { get; set; } = "Destination";
        public static string pfExpense { get; set; } = "Expense";
        public static string pfItinerary { get; set; } = "Itinerary";
        public static string pfReservation { get; set; } = "Reservation";
        public static string pfTransaction { get; set; } = "Transaction";
        public static string pfClient { get; set; } = "Client";

        public static string GetEndpoint(string name)
        {
            return name switch
            {
                nameof(pfActivity) => "api/pfActivity",
                nameof(pfAdministrator) => "api/pfAdministrator",
                nameof(pfDestination) => "api/pfDestination",
                nameof(pfExpense) => "api/pfExpense",
                nameof(pfItinerary) => "api/pfItinerary",
                nameof(pfReservation) => "api/pfReservation",
                nameof(pfTransaction) => "api/pfTransaction",
                nameof(pfClient) => "api/pfClient",

                _ => throw new ArgumentException($"Endpoint '{name}' no está definido.")
            };
        }
    }
}
