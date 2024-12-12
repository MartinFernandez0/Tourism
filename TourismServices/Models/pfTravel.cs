using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismServices.Models
{
    public class pfTravel
    {
        public int Id { get; set; }
        public string TravelName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Relación con Cliente
        public int ClientId { get; set; }
        public virtual pfClient Client { get; set; }

        // Relación con Destino
        public int DestinationId { get; set; }
        public virtual pfDestination Destination { get; set; }

        // Relación con Itinerario
        public int ItineraryId { get; set; }
        public virtual pfItinerary Itinerary { get; set; }

        // Relación con Actividad
        public int ActivityId { get; set; }
        public virtual pfActivity Activity { get; set; }

        // Eliminado
        public bool IsDeleted { get; set; } = false;
    }


}
