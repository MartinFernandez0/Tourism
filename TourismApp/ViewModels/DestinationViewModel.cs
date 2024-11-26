using System.Collections.ObjectModel;
using System.Diagnostics;
using TourismApp.Class;
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
                UpdateDestinationCommand.ChangeCanExecute();
                DeleteDestinationCommand.ChangeCanExecute();
            }
        }

        public Command GetDestinationsCommand { get; }
        public Command FilterDestinationsCommand { get; }
        public Command AddDestinationCommand { get; }
        public Command UpdateDestinationCommand { get; }
        public Command DeleteDestinationCommand { get; }

        public DestinationViewModel()
        {
            GetDestinationsCommand = new Command(async () => await GetDestinations());
            FilterDestinationsCommand = new Command(async () => await FilteredDestinations());
            AddDestinationCommand = new Command(async () => await AddDestination());
            UpdateDestinationCommand = new Command(async (obj) => await UpdateDestination(), AllowEdit);
            DeleteDestinationCommand = new Command(async (obj) => await DeleteDestination(), AllowEdit);
            GetDestinations();
        }

        private bool AllowEdit(object arg)
        {
            return DestinationSelected != null;
        }

        private async Task UpdateDestination()
        {
            if (DestinationSelected == null)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "No hay destino seleccionado para actualizar.", "OK");
                return;
            }

            var navigationParameter = new Dictionary<string, object>
            {
                { "DestinationEdit", DestinationSelected }
            };
            await Shell.Current.GoToAsync("AddEditDestination", navigationParameter);
        }

        private async Task DeleteDestination()
        {
            var confirmacion = await Application.Current.MainPage.DisplayAlert("Eliminar Destino", "¿Está seguro que desea eliminar el Destino?", "Si", "No");
            if (confirmacion && DestinationSelected != null)
            {
                DestinationSelected.IsDeleted = true;
                await destinationService.UpdateAsync(DestinationSelected);
                DestinationSelected = null;
                await GetDestinations();
            }
        }

        private async Task AddDestination()
        {
            var navigationParameter = new ShellNavigationQueryParameters
            {
                { "DestinationEdit", new pfDestination() } // Asegúrate de que esto no sea null
            };
            await Shell.Current.GoToAsync("AddEditDestination", navigationParameter);
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
                if (listDestinationFilter == null)
                {
                    Debug.Print("No se encontraron destinos.");
                    Destinations = new ObservableCollection<pfDestination>();
                }
                else
                {
                    Destinations = new ObservableCollection<pfDestination>(listDestinationFilter);
                    Debug.Print($"Destinos cargados: {Destinations.Count}");
                    foreach (var destination in Destinations)
                    {
                        Debug.Print(destination.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Print($"Error al obtener destinos: {ex.Message}");
                Destinations = new ObservableCollection<pfDestination>();
            }
            finally
            {
                IsRefreshing = false;
            }
        }
    }
}
