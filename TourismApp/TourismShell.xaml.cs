using CommunityToolkit.Mvvm.Messaging;
using TourismApp.Class;
using TourismApp.Views;
namespace TourismApp
{
    public partial class TourismShell : Shell
    {
        public TourismShell()
        {
            InitializeComponent();
        }

        internal void DisableAppAfterLogin()
        {
            throw new NotImplementedException();
        }
    }
}
