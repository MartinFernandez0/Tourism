using TourismApp.ViewModels;

namespace TourismApp.Views
{
    public partial class DestinationView : ContentPage
    {
        public DestinationView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var viewModel = BindingContext as DestinationViewModel;
            viewModel.GetDestinations();
            viewModel.SelectedDestination = null;
        }
    }
}
