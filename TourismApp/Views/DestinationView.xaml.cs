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
            var viewmodel = this.BindingContext as DestinationViewModel;
            //if (viewmodel.NotaSeleccionada != null)
            //{
            viewmodel.GetDestinations();
            viewmodel.DestinationSelected = null;
            //}
        }
    }
}
