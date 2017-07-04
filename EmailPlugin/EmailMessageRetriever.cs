using System.Collections.Generic;
using Plugin.Core;

namespace EmailPlugin
{
    public class EmailMessageRetriever : MessageRetriever
    {
        public override IEnumerable<Message> RetrieveMessages()
        {
            return new List<EmailMessage>
            {
                new EmailMessage{From = "Company", To = "Employee", Subject = "Congratulations", Message = "Good job, here's some extra money."},
                new EmailMessage{From = "Company2", To = "Company", Subject = "Cutbacks", Message = "Spending way too much money..."}
            };
        }
    }
}
