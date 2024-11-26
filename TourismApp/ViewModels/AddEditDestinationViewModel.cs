using System.Collections.ObjectModel;
using TourismApp.Class;
using TourismServices.Models;
using TourismServices.Services;

namespace TourismApp.ViewModels
{
    public class AddEditDestinationViewModel : ObjectNotification
    {
        private readonly GenericService<pfDestination> destinationService = new GenericService<pfDestination>();
        private readonly GenericService<pfItinerary> itineraryService = new GenericService<pfItinerary>();

        #region Properties

        private pfDestination editDestination;
        public pfDestination EditDestination
        {
            get { return editDestination; }
            set
            {
                editDestination = value;
                OnPropertyChanged();
                SettingData();
            }
        }

        private void SettingData()
        {
            if (editDestination != null)
            {
                Name = editDestination.Name;
                Description = editDestination.Description;
                URLImage = editDestination.URL_image;
                CategoryName = editDestination.CategoryName;
                Country = editDestination.Country;
                ItineraryId = editDestination.ItineraryId;
                IsDeleted = editDestination.IsDeleted;
            }
            else
            {
                Name = string.Empty;
                Description = string.Empty;
                URLImage = string.Empty;
                CategoryName = string.Empty;
                Country = string.Empty;
                ItineraryId = null;
                IsDeleted = false;
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged();
            }
        }

        private string urlImage;
        public string URLImage
        {
            get { return urlImage; }
            set
            {
                urlImage = value;
                OnPropertyChanged();
            }
        }

        private string categoryName;
        public string CategoryName
        {
            get { return categoryName; }
            set
            {
                categoryName = value;
                OnPropertyChanged();
            }
        }

        private string country;
        public string Country
        {
            get { return country; }
            set
            {
                country = value;
                OnPropertyChanged();
            }
        }

        private int? itineraryId;
        public int? ItineraryId
        {
            get { return itineraryId; }
            set
            {
                itineraryId = value;
                OnPropertyChanged();
            }
        }

        private bool isDeleted;
        public bool IsDeleted
        {
            get { return isDeleted; }
            set
            {
                isDeleted = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<pfItinerary> listItineraries = new ObservableCollection<pfItinerary>();
        public ObservableCollection<pfItinerary> ListItineraries
        {
            get { return listItineraries; }
            set
            {
                listItineraries = value;
                OnPropertyChanged();
            }
        }

        private pfItinerary itinerarySelected;
        public pfItinerary ItinerarySelected
        {
            get { return itinerarySelected; }
            set
            {
                itinerarySelected = value;
                OnPropertyChanged();

                // Actualiza el ID del itinerario seleccionado
                if (itinerarySelected != null)
                {
                    ItineraryId = itinerarySelected.Id;
                }
            }
        }

        private int idItinerarySelected;
        public int IdItinerarySelected
        {
            get { return idItinerarySelected; }
            set
            {
                idItinerarySelected = value;
                OnPropertyChanged();

                // Asigna el itinerario seleccionado según el índice
                if (ListItineraries != null && idItinerarySelected >= 0 && idItinerarySelected < ListItineraries.Count)
                {
                    ItinerarySelected = ListItineraries[idItinerarySelected];
                }
            }
        }

        #endregion

        #region Commands
        public Command SaveDestinationCommand { get; }
        public Command BackCommand { get; }
        #endregion

        public AddEditDestinationViewModel()
        {
            SaveDestinationCommand = new Command(async () => await SaveDestination());
            BackCommand = new Command(async () => await GoBackToList());

            // Inicializa la colección de itinerarios
            ListItineraries = new ObservableCollection<pfItinerary>();
            LoadItineraries();
        }

        private async Task LoadItineraries()
        {
            var itineraries = await itineraryService.GetAllAsync(); // O la llamada adecuada para obtener itinerarios
            ListItineraries.Clear();
            foreach (var itinerary in itineraries)
            {
                ListItineraries.Add(itinerary);
            }
        }

        private async Task SaveDestination()
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Description))
            {
                // Muestra un mensaje de error o maneja la validación (si tu framework lo permite)
                return;
            }

            if (EditDestination != null)
            {
                editDestination.Name = Name;
                editDestination.Description = Description;
                editDestination.URL_image = URLImage;
                editDestination.CategoryName = CategoryName;
                editDestination.Country = Country;
                editDestination.ItineraryId = ItineraryId;
                editDestination.IsDeleted = IsDeleted;

                await destinationService.UpdateAsync(editDestination);
            }
            else
            {
                var destination = new pfDestination()
                {
                    Name = Name,
                    Description = Description,
                    URL_image = URLImage,
                    CategoryName = CategoryName,
                    Country = Country,
                    ItineraryId = ItineraryId,
                    IsDeleted = IsDeleted
                };

                await destinationService.AddAsync(destination);
            }

            await GoBackToList();
        }

        private async Task GoBackToList()
        {
            EditDestination = null;
            await Shell.Current.GoToAsync("/DestinationList");
        }
    }
}
