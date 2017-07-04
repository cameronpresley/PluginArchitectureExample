using System.Collections.Generic;
using Plugin.Core;

namespace TextFilePlugin
{
    public class TextFileMessageRetriever : MessageRetriever
    {
        public override IEnumerable<Message> RetrieveMessages()
        {
            return new List<Message>
            {
                new TextFileMessage{FirstName = "Cameron", LastName = "Presley", NumberOfSales = 4},
                new TextFileMessage{FirstName = "John", LastName = "Doe", NumberOfSales = 10}
            };
        }
    }
}
