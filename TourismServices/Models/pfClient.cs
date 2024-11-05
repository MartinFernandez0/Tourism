using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismServices.Models
{
    public class pfClient
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "El campo apellido es obligatorio")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El campo DNI es obligatorio")]
        public string Document { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateBirth { get; set; }

        // Relación con Reservación
        public int? ReservationId { get; set; }
        public virtual pfReservation? Reservation { get; set; }

        // Relación con Transacción
        public int? TransactionId { get; set; }
        public virtual pfTransaction? Transaction { get; set; }

        // Eliminado
        public bool IsDeleted { get; set; } = false;
    }

}
