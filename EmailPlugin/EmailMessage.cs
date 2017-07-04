using Plugin.Core;

namespace EmailPlugin
{
    public class EmailMessage : Message
    {
        public string To;
        public string From;
        public string Message;
        public string Subject;
    }
}
