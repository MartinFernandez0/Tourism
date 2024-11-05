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
        public DateTime ReservationDate { get; set; }
        [Required]
        public ReservationStatusEnum ReservationStatus { get; set; }

        // Relación con Itinerario
        public int? ItineraryId { get; set; }
        public virtual pfItinerary? Itinerary { get; set; }

        // Relación con Destino
        public int? DestinationId { get; set; }
        public virtual pfDestination? Destination { get; set; }

        // Eliminado
        public bool IsDeleted { get; set; } = false;
    }
}
