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
            get { return FilterText; }
            set
            {
                FilterText = value;
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
        private DestinationService SelectedDestination;

        //Selected Destination View
        //public pfDestination SelectedDestination
        //{
        //    get { return SelectedDestination; }
        //    set
        //    {
        //        SelectedDestination = value;
        //        OnPropertyChanged();
        //    }
        //}


        public Command GetDestinationsCommand { get; set; }
        public Command FilterDestinationCommand { get; set; }

        public DestinationViewModel()
        {
            GetDestinationsCommand = new Command(async () => await GetDestinations());
            FilterDestinationCommand = new Command(async () => await filterTextDestination());
        }

        private async Task GetDestinations()
        {
            FilterText = string.Empty;
            IsRefreshing = true;
            DestinationListToFilter = await pfDestinationService.GetAllAsync();
            Destinations = new ObservableCollection<pfDestination>(DestinationListToFilter);
            IsRefreshing = false;
        }


        //  Select Editt
        //private bool PermitirEditar(object arg)
        //{
        //    return selectedProducto != null;
        //}
    }
}
