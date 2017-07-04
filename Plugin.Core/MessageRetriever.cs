using System.Collections.Generic;

namespace Plugin.Core
{
    public abstract class MessageRetriever
    {
        public abstract IEnumerable<Message> RetrieveMessages();
    }
}
