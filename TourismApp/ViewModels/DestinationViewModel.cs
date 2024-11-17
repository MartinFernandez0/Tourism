using System.Collections.ObjectModel;
using TourismApp.Utils;
using TourismServices.Models;
using TourismServices.Services;


namespace TourismApp.ViewModels
{
    public class DestinationViewModel : ObjectNotification
    {
        private GenericService<pfDestination> pfDestinationService = new GenericService<pfDestination>();

        private string filterText;
        public string FilterText
        {
            get { return filterText; }
            set
            {
                filterText = value;
                OnPropertyChanged();
                _ = filterTextDestination();
            }
        }

        private async Task filterTextDestination()
        {
            var filterDestination = DestinationListToFilter.Where(d => d.Name.ToUpper().Contains(FilterText.ToLower()));
            Destinations = new ObservableCollection<pfDestination>(filterDestination);
        }

        private bool isRefreshing;
        public bool IsRefreshing
        {
            get => isRefreshing;
            set
            {
                isRefreshing = value;
                OnPropertyChanged();
            }
        }


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

        private List<pfDestination>? DestinationListToFilter;
        private pfDestination selectedDestination;

        public pfDestination SelectedDestinations
        {
            get { return selectedDestination; }
            set
            {
                selectedDestination = value;
                OnPropertyChanged();
            }
        }


        public Command GetDestinationsCommand { get; set; }
        public Command FilterDestinationCommand { get; set; }
        public Command AddDestinationCommand { get; set; }
        public Command UpdateDestinarionCommand { get; set; }


        public DestinationViewModel()
        {
            GetDestinationsCommand = new Command(async () => await GetDestinations());
            FilterDestinationCommand = new Command(async () => await filterTextDestination());
            AddDestinationCommand = new Command(async () => await AddDestination());
            UpdateDestinarionCommand = new Command(async (obj) => await UpdateDestination(), allowEdit);
            GetDestinations();
        }

        private bool allowEdit(object obj)
        {
            return SelectedDestinations != null;
        }

        public async Task GetDestinations()
        {
            FilterText = string.Empty;
            IsRefreshing = true;
            DestinationListToFilter = await pfDestinationService.GetAllAsync();
            Destinations = new ObservableCollection<pfDestination>(DestinationListToFilter);
            IsRefreshing = false;
        }
        private async Task AddDestination()
        {
            var navigationParameter = new ShellNavigationQueryParameters
            {
                { "DestinationToEdit", null }
            };
            await Shell.Current.GoToAsync("//AddEditDestination", navigationParameter);
        }

        private async Task UpdateDestination()
        {
            var navigationParameter = new ShellNavigationQueryParameters
            {
                { "DestinationToEdit", SelectedDestinations }
            };
            await Shell.Current.GoToAsync("//AddEditDestination", navigationParameter);
        }

    }
}
