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
        GenericService<pfDestination> destinationService = new GenericService<pfDestination>();

        private string filterDestination;
        public string FilterDestination
        {
            get { return filterDestination; }
            set
            {
                filterDestination = value;
                OnPropertyChanged();
                FilteredDestinations();
            }
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

        ObservableCollection<pfDestination> destinations;
        public ObservableCollection<pfDestination> Destinations
        {
            get { return destinations; }
            set
            {
                destinations = value;
                OnPropertyChanged();
            }
        }

        public List<pfDestination>? listDestinationFilter;

        private pfDestination destinationSelected;
        public pfDestination DestinationSelected
        {
            get { return destinationSelected; }
            set
            {
                destinationSelected = value;
                OnPropertyChanged();
                EditDestinationCommand.ChangeCanExecute();
                DeleteDestinationCommand.ChangeCanExecute();
            }
        }

        public Command GetDestinationsCommand { get; }
        public Command FilterDestinationsCommand { get; }
        public Command AddDestinationCommand { get; }
        public Command EditDestinationCommand { get; }
        public Command DeleteDestinationCommand { get; }

        public DestinationViewModel()
        {
            GetDestinationsCommand = new Command(async () => await GetDestinations());
            FilterDestinationsCommand = new Command(async () => await FilteredDestinations());
            AddDestinationCommand = new Command(async () => await AddDestination());
            EditDestinationCommand = new Command(async (obj) => await EditDestination(), AllowEdit);
            DeleteDestinationCommand = new Command(async (obj) => await DeleteDestination(), AllowEdit);
            GetDestinations();
        }

        private bool AllowEdit(object arg)
        {
            return DestinationSelected != null;
        }

        private async Task EditDestination()
        {
            var navigationParameter = new ShellNavigationQueryParameters
                {
                    { "DestinationEdit", DestinationSelected }
                };
            await Shell.Current.GoToAsync($"//AddEditDestination", navigationParameter);
        }

        private async Task DeleteDestination()
        {
            var confirmacion = await Application.Current.MainPage.DisplayAlert("Eliminar Destino", "¿Está seguro que desea eliminar el Destino?", "Si", "No");
            if (confirmacion)
            {
                await destinationService.DeleteAsync(DestinationSelected.Id);
                DestinationSelected = null;
                await GetDestinations();
            }
        }

        private async Task AddDestination()
        {
            var navigationParameter = new ShellNavigationQueryParameters
                {
                    { "DestinationEdit", null }
                };
            await Shell.Current.GoToAsync($"//AddEditDestination", navigationParameter);
        }

        private async Task FilteredDestinations()
        {
            var destinationFilter = listDestinationFilter.Where(p => p.Name.ToLower().Contains(filterDestination.ToLower())).ToList();
            Destinations = new ObservableCollection<pfDestination>(destinationFilter);
        }

        public async Task GetDestinations()
        {
            FilterDestination = string.Empty;
            IsRefreshing = true;
            try
            {
                listDestinationFilter = await destinationService.GetAllAsync();
                if (listDestinationFilter == null || !listDestinationFilter.Any())
                {
                    Debug.WriteLine("No se encontraron destinos.");
                    Destinations = new ObservableCollection<pfDestination>();
                }
                else
                {
                    Destinations = new ObservableCollection<pfDestination>(listDestinationFilter);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al obtener destinos: {ex.Message}");
                Destinations = new ObservableCollection<pfDestination>();
            }
            finally
            {
                IsRefreshing = false;
            }
        }
    }
}
