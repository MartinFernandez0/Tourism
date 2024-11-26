using TourismApp.Class;
using TourismServices.Models;
using TourismServices.Services;

namespace TourismApp.ViewModels
{
    public class AddEditDestinationViewModel : ObjectNotification
    {
        private readonly GenericService<pfDestination> destinationService = new GenericService<pfDestination>();

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
        #endregion

        #region Commands
        public Command SaveDestinationCommand { get; }
        public Command BackCommand { get; }
        #endregion

        public AddEditDestinationViewModel()
        {
            SaveDestinationCommand = new Command(async () => await SaveDestination());
            BackCommand = new Command(async () => await GoBackToList());
        }

        private async Task SaveDestination()
        {
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
            await Shell.Current.GoToAsync("//DestinationList");
        }
    }
}
