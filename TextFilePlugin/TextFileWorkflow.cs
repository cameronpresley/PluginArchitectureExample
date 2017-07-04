using Plugin.Core;

namespace TextFilePlugin
{
    public class TextFileWorkflow : Workflow
    {
        public TextFileWorkflow()
            :base(new TextFileMessageRetriever(), new TextFileMessageSender(@"C:\temp\"))
        {
            
        }

        public override string Name => "Text File Workflow";

        public override string ToString()
        {
            return Name;
        }
    }
}
