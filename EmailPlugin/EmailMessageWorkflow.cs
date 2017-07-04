using Plugin.Core;

namespace EmailPlugin
{
    public class EmailMessageWorkflow : Workflow
    {
        public EmailMessageWorkflow():base(new EmailMessageRetriever(), new EmailMessageSender())
        {
        }

        public override string Name => "Email Sender";
    }
}
