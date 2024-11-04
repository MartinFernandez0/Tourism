using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismServices.Enums;

namespace TourismServices.Models
{
    public class pfReservation
    {
        public int Id { get; set; }
        public int ItineraryId { get; set; }
        public int ClientId { get; set; }
        public int DestinationId { get; set; }
        public DateTime ReservationDate { get; set; }
        [Required]
        public ReservationStatusEnum ReservationStatus { get; set; }

        public pfItinerary Itinerary { get; set; } // Relación de navegación
        public pfClient Client { get; set; } // Relación de navegación
        public pfDestination Destination { get; set; } // Relación de navegación
    }
}
