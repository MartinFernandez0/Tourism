using CommunityToolkit.Mvvm.Messaging;
using TourismApp.Utils;

namespace TourismApp.Views;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
        //BindingContext = new IniciarSesionViewModel();

        /////C�DIGO QUE para preparar la recepci�n de mensajes y la llamada al m�todo RecibirMensaje
        WeakReferenceMessenger.Default.Register<Message>(this, (r, mensaje) =>
        {
            OnReceiveMessage(mensaje);
        });
    }

    private async void OnReceiveMessage(Message mensaje)
    {
        if (mensaje.Value == "OpenDestinationsPage")
        {
            await Navigation.PushAsync(new DestinationView());
        }
    }

    private async void OnStartButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DestinationView());
    }
}
