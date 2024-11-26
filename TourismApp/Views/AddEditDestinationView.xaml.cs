using TourismServices.Models;
using TourismApp.ViewModels;

namespace TourismApp.Views;

[QueryProperty(nameof(Destination), "DestinationEdit")]
public partial class AddEditDestinationView : ContentPage
{
    public pfDestination Destination
    {
        set
        {
            var destination = value;
            var viewModel = this.BindingContext as AddEditDestinationViewModel;
            viewModel.EditDestination = destination;
        }
    }
    public AddEditDestinationView()
    {
        InitializeComponent();
    }

    public AddEditDestinationView(pfDestination DestinationEdit)
    {
        InitializeComponent();
        var viewModel = this.BindingContext as AddEditDestinationViewModel;
        viewModel.EditDestination = DestinationEdit;
    }
}
