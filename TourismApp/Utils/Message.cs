using CommunityToolkit.Mvvm.Messaging.Messages;
using TourismServices.Models;

namespace TourismApp.Utils
{
    class Message : ValueChangedMessage<string>
    {
        public pfDestination destination { get; set; }

        public Message(string value) : base(value) 
        {

        }
    }
}
