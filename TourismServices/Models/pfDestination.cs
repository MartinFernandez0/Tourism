using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TourismServices.Models
{
    public class pfDestination
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string URL_image { get; set; }
        public string CategoryName { get; set; }
        public string Country { get; set; }

        // Relación con Itinerario
        public int? ItineraryId { get; set; }
        public virtual pfItinerary? Itinerary { get; set; }

        // Eliminado
        public bool IsDeleted { get; set; } = false;
    }


}
