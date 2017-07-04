using System;
using System.Linq;

namespace Plugin.Core
{
    public abstract class Workflow
    {
        private readonly MessageRetriever _retriever;
        private readonly MessageSender _sender;

        protected Workflow(MessageRetriever retriever, MessageSender sender)
        {
            _retriever = retriever ?? throw new ArgumentNullException(nameof(retriever));
            _sender = sender ?? throw new ArgumentNullException(nameof(sender));
        }

        public abstract string Name { get; }

        public void Do()
        {
            try
            {
                _sender.SendMessage(_retriever.RetrieveMessages().ToList());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to retrieve or send messages.");
                Console.WriteLine("Error of " + ex.Message);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
