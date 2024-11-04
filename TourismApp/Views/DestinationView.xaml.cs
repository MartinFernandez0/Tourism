using TourismServices.Interfaces;
using TourismServices.Services;

namespace TourismApp.Views
{
    public partial class DestinationView : ContentPage
    {
        private readonly IDestinationService destinationService;

        public DestinationView()
        {
            InitializeComponent();
            this.destinationService = new DestinationService();
            LoadDestinations();
        }

        private async void LoadDestinations()
        {
            try
            {
                var destinations = await destinationService.GetAllAsync(null);
                DestinationsCollectionView.ItemsSource = destinations;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
