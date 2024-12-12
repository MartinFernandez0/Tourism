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
        public virtual ICollection<pfItinerary> Itineraries { get; set; } = new List<pfItinerary>();

        // Relación con Actividad
        public virtual ICollection<pfActivity> Activities { get; set; } = new List<pfActivity>();

        // Eliminado
        public bool IsDeleted { get; set; } = false;
    }


}
