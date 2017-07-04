using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Plugin.Core;

namespace TextFilePlugin
{
    public class TextFileMessageSender : MessageSender
    {
        private readonly string _path;

        public TextFileMessageSender(string path) 
        {
            if (String.IsNullOrWhiteSpace(path)) throw new ArgumentNullException(nameof(path));
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            _path = path;
        }

        public override void SendMessage(List<Message> messages)
        {
            var validMessages = messages.OfType<TextFileMessage>().ToList();
            using (var writer = new StreamWriter(_path + "output.txt", append:true))
            {
                writer.WriteLine("First Name, Last Name, Number of Sales");
                foreach (var message in validMessages)
                {
                    writer.WriteLine(FormatMessage(message));
                }
                writer.Close();
            }
        }

        private string FormatMessage(TextFileMessage message)
        {
            return $"{message.FirstName}, {message.LastName}, {message.NumberOfSales}";
        }
    }
}
