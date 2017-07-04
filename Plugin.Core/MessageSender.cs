using System.Collections.Generic;

namespace Plugin.Core
{
    public abstract class MessageSender
    {
        public abstract void SendMessage(List<Message> message);
    }
}
