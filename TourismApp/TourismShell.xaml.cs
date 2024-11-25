using CommunityToolkit.Mvvm.Messaging;
using TourismApp.Utils;
using TourismApp.ViewModels;

namespace TourismApp
{
    public partial class TourismShell : Shell
    {
        public TourismShell()
        {
            InitializeComponent();
            FlyoutItemsPrincipal.IsVisible = false; // Oculta el menú lateral

            /////CÓDIGO QUE para preparar la recepción de mensajes y la llamada al método RecibirMensaje
            WeakReferenceMessenger.Default.Register<Message>(this, (r, mensaje) =>
            {
                OnReceiveMessage(mensaje);
            });
        }

        private void OnReceiveMessage(Message mensaje)
        {
            if (mensaje.Value == "GetDestinations")
            {
                //await Navigation.PushAsync(new ProductosView());
            }
            if (mensaje.Value == "AddDestinations")
            {
                //await Navigation.PushAsync(new AddEditProductoView());
            }
            if (mensaje.Value == "EditDestinations")
            {
                //await Navigation.PushAsync(new AddEditProductoView(mensaje.ProductoAEditar));
            }
        }

        // Metodos para que el Iniciar sesion se apage y encienda
        public void EnableAppAfterLogin()
        {
            FlyoutBehavior = FlyoutBehavior.Flyout; // Habilita el FlyOut
            FlyoutItemsPrincipal.IsVisible = true; // Muestra el menú lateral
            Shell.Current.GoToAsync("//MainPage"); // Navega a la página principal
            var viewmodel = this.BindingContext as DestinationShellViewModel;
            viewmodel.IsUserLogout = false;
        }
        public void DisableAppAfterLogin()
        {
            FlyoutItemsPrincipal.IsVisible = false; // Oculta el menú lateral
            FlyoutBehavior = FlyoutBehavior.Disabled; // Deshabilita el FlyOut
            Shell.Current.GoToAsync("//Login"); // Navega a la página de login
        }
    }
}
