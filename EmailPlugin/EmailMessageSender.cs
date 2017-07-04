using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using Plugin.Core;

namespace EmailPlugin
{
    public class EmailMessageSender : MessageSender
    {
        public override void SendMessage(List<Message> messages)
        {
            foreach (var message in messages.OfType<EmailMessage>())
            {
                using (var smtp = new SmtpClient("smtp.google.com"))
                {
                    var mailMessage = new MailMessage(message.From, message.To, message.Subject, message.Message);
                    smtp.Send(mailMessage);
                }
            }
        }
    }
}
