using System.Collections.ObjectModel;
using System.Diagnostics;
using TourismApp.Utils;
using TourismServices.Interfaces;
using TourismServices.Models;
using TourismServices.Services;

namespace TourismApp.ViewModels
{
    public class DestinationViewModel : ObjectNotification
    {
        private GenericService<pfDestination> destinationService = new GenericService<pfDestination>();

        public Command GetDestinationsCommand { get; set; }
        public Command FilterDestinationCommand { get; set; }
        public Command AddDestinationCommand { get; set; }
        public Command UpdateDestinarionCommand { get; set; }

        public DestinationViewModel()
        {
            GetDestinationsCommand = new Command(async () => await GetDestinations());
            FilterDestinationCommand = new Command(async () => await FilterTextDestination());
            AddDestinationCommand = new Command(async () => await AddDestination());
            UpdateDestinarionCommand = new Command(async (obj) => await UpdateDestination(), AllowEdit);
            GetDestinations();
        }

        private string filterText;
        public string FilterText
        {
            get { return filterText; }
            set
            {
                filterText = value;
                OnPropertyChanged();
                _ = FilterTextDestination();
            }
        }

        private async Task FilterTextDestination()
        {
            if (DestinationListToFilter == null) return;

            var filterDestination = DestinationListToFilter
                .Where(d => d.Name.ToUpper().Contains(FilterText.ToUpper()));

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

        private bool AllowEdit(object obj)
        {
            return SelectedDestinations != null;
        }

        public async Task GetDestinations()
        {
            try
            {
                FilterText = string.Empty;
                IsRefreshing = true;
                DestinationListToFilter = await destinationService.GetAllAsync();
                Destinations = new ObservableCollection<pfDestination>();
            }
            catch (Exception ex)
            {
                // Manejo de errores, por ejemplo, escribir el error en los logs.
                Debug.WriteLine($"Error al obtener destinos: {ex.Message}");
            }
            finally
            {
                IsRefreshing = false;
            }
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
