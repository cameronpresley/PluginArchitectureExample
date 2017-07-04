using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.Core
{
    public abstract class MessageRetriever
    {
        public abstract IEnumerable<Message> RetrieveMessages();
    }
}
