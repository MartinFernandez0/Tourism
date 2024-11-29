using System.ComponentModel.DataAnnotations;

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

        // Eliminado
        public bool IsDeleted { get; set; } = false;
    }

}
