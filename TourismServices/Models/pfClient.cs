using System.ComponentModel.DataAnnotations;
using TourismServices.Enums;

namespace TourismServices.Models
{
    public class pfClient
    {

        //Information Basic

        public int Id { get; set; }

        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "El campo apellido es obligatorio")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El campo DNI es obligatorio")]
        public string Document { get; set; }

            // Fecha de nacimiento
        public DateTime Birthdate { get; set; }
            // Genero
        public CustomerGenderEnum CustomerGender { get; set; }

        // - - - - - - 

        // Information Contact
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }

        // - - - - - - 

        //Information Tourist
        public AccommodationPreferenceEnum AccommodationPreference { get; set; }
        public FoodPreferenceEnum FoodPreference { get; set; }

            // Relación con Destinos
        public int? DestinationId { get; set; }
        public virtual pfDestination? Destination { get; set; }

            // Relación con Actividades
        public int? ActivityId { get; set; }
        public virtual pfActivity? Activity { get; set; }

        // - - - - - - 

        //Information Reservation
        public int NumberOfPeople { get; set; }
        public DateTime ReservationDate { get; set; }
        public ReservationStatusEnum ReservationStatus { get; set; }

            // Relación con Itinerario
        public int? ItineraryId { get; set; }
        public virtual pfItinerary? Itinerary { get; set; }

        // - - - - - - 

        //Information Payment
        public PaymentMethodEnum PaymentMethod { get; set; }
        public PaymentConfirmationEnum PaymentConfirmation { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal TotalAmount { get; set; }

        // - - - - - - 

        // Eliminado
        public bool IsDeleted { get; set; } = false;
    }

}
