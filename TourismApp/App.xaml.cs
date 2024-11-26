using TourismApp.Views;
using TourismApp.ViewModels;

namespace TourismApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TourismShell();
        }
    }
}
