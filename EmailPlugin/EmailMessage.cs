using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
