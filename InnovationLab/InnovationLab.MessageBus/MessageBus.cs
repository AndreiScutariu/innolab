using TinyMessenger;

namespace InnovationLab.MessageBus
{
    public class MessageBus : IMessageBus
    {
        private TinyMessengerHub _messageHub;

        public MessageBus()
        {
            _messageHub = new TinyMessengerHub();
        }


    }
}