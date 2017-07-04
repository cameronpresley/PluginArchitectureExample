using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.Core
{
    public interface MessageSender
    {
        void SendMessage(Message message);
    }
}
