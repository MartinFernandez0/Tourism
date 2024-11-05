using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismServices.Models
{
    public class pfItinerary
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Description { get; set; }

        // Relación con Actividad
        public int ActivityId { get; set; }
        public virtual pfActivity Activity { get; set; }

        // Eliminado
        public bool IsDeleted { get; set; } = false;
    }

}
