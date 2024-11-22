using System.Collections.ObjectModel;
using TourismApp.Class;
using TourismServices.Models;
using TourismServices.Services;

namespace TourismApp.ViewModels
{
    public class DestinationViewModel : ObjectNotification
    {
        private GenericService<pfDestination> destinationService = new GenericService<pfDestination> ();


        // -    -   -   -   -   

        private ObservableCollection<pfDestination> destinations;
        public ObservableCollection<pfDestination> Destinations
        {
            get { return destinations; }
            set
            {
                destinations = value;
                OnPropertyChanged();
            }
        }

        private List<pfDestination> destinationsList;
        private pfDestination selectedDestination;
        public pfDestination SelectedDestination
        {
            get { return selectedDestination; }
            set
            {
                selectedDestination = value;
                OnPropertyChanged();
            }
        }


        //Command
        public Command GetDestinationsCommand { get; set; }

        public DestinationViewModel()
        {
            GetDestinationsCommand = new Command(async () => await GetDestinations());
            GetDestinations();
        }

        //Methodos
        private async Task GetDestinations()
        {
            FilterDestination = string.Empty;
            IsRefreshing = true;
            destinationsList = await destinationService.GetAllAsync();
            Destinations = new ObservableCollection<pfDestination> (destinationsList);
            IsRefreshing = false;
        }


        //Filtered // IsRefreshing
        private string filterDestination;
        public string FilterDestination
        {
            get { return filterDestination; }
            set
            {
                filterDestination = value;
                OnPropertyChanged();
                _ = FilteredDestination();
            }
        }

        private object FilteredDestination()
        {
            throw new NotImplementedException();
        }

        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }
    }
}
