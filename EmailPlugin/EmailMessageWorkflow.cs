using Plugin.Core;

namespace EmailPlugin
{
    public class EmailMessageWorkflow : Workflow
    {
        public EmailMessageWorkflow(EmailMessageRetriever retriever, EmailMessageSender sender) : base(retriever, sender)
        {
        }

        public override string Name => "Email Sender";
    }
}
