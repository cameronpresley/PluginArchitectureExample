using Plugin.Core;

namespace TextFilePlugin
{
    public class TextFileWorkflow : Workflow
    {
        public TextFileWorkflow():base(new TextFileMessageRetriever(), new TextFileMessageSender())
        {
            
        }
    }
}
