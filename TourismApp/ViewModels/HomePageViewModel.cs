using CommunityToolkit.Mvvm.Messaging;

using TourismApp.Utils;

namespace TourismApp.ViewModels
{
    public class HomePageViewModel : ObjectNotification
    {
        public void OpenDestinationView(object obj)
        {
            WeakReferenceMessenger.Default.Send(new Message("OpenDestinationsPage"));
        }
    }
}
