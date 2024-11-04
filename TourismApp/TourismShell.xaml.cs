using CommunityToolkit.Mvvm.Messaging;
using TourismApp.Utils;
namespace TourismApp
{
    public partial class TourismShell : Shell
    {
        public TourismShell()
        {
            InitializeComponent();

            /////CÓDIGO QUE para preparar la recepción de mensajes y la llamada al método RecibirMensaje
            WeakReferenceMessenger.Default.Register<Message>(this, (r, mensaje) =>
            {
                OnReceiveMessage(mensaje);
            });
        }

        private void OnReceiveMessage(Message mensaje)
        {
            if (mensaje.Value == "OpenDestinationsPage")
            {
                //await Navigation.PushAsync(new ProductosView());
            }
        }
    }
}
