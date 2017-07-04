using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.Core
{
    public class Workflow
    {
        public void Do(MessageRetriever retriever, MessageSender sender)
        {
            try
            {
                retriever.RetrieveMessages().ToList().ForEach(sender.SendMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to retrieve or send messages.");
            }
        }
    }
}
