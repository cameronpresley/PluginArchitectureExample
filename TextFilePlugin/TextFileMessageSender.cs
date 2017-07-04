using System;
using System.IO;
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

        public void SendMessage(Message message)
        {
            var textFileMessage = message as TextFileMessage;
            if (textFileMessage == null) return;

            using (var writer = new StreamWriter(_path + "output.txt", append:true))
            {
                writer.WriteLine("First Name, Last Name, Number of Sales");
                writer.WriteLine(FormatMessage(textFileMessage));
                writer.Close();
            }
        }

        private string FormatMessage(TextFileMessage message)
        {
            return $"{message.FirstName}, {message.LastName}, {message.NumberOfSales}";
        }
    }
}
