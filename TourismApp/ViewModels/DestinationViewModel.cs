using System.Collections.ObjectModel;
using System.Diagnostics;
using TourismApp.Class;
using TourismServices.Models;
using TourismServices.Services;

namespace TourismApp.ViewModels
{
    public class DestinationViewModel : ObjectNotification
    {
        private GenericService<pfDestination> destinationService = new GenericService<pfDestination>();

        public Command GetDestinationsCommand { get; }
        public Command FilterDestinationCommand { get; }
        public Command AddDestinationCommand { get; }
        public Command UpdateDestinarionCommand { get; }

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

        public pfDestination SelectedDestination
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
            return SelectedDestination != null;
        }

        public async Task GetDestinations()
        {
            try
            {
                filterText = string.Empty;
                IsRefreshing = true;

                Debug.WriteLine("Obteniendo destinos...");
                DestinationListToFilter = await destinationService.GetAllAsync();

                if (DestinationListToFilter == null || !DestinationListToFilter.Any())
                {
                    Debug.WriteLine("No se encontraron destinos.");
                    Destinations = new ObservableCollection<pfDestination>();
                }
                else
                {
                    Debug.WriteLine($"Se encontraron {DestinationListToFilter.Count} destinos.");
                    Destinations = new ObservableCollection<pfDestination>(DestinationListToFilter);
                }
            }
            catch (Exception ex)
            {
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
                { "DestinationToEdit", SelectedDestination }
            };
            await Shell.Current.GoToAsync("//AddEditDestination", navigationParameter);
        }
    }
}
