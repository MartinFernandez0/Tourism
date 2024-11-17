using CommunityToolkit.Mvvm.Messaging;
using TourismApp.Utils;
using TourismApp.Views;
namespace TourismApp
{
    public partial class TourismShell : Shell
    {
        public TourismShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(DestinationView), typeof(DestinationView));
            CurrentItem = new ShellContent
            {
                ContentTemplate = new DataTemplate(typeof(DestinationView))
            };
        }
    }
}
