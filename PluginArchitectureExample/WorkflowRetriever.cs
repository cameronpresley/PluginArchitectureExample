using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Plugin.Core;

namespace PluginArchitectureExample
{
    public class WorkflowRetriever
    {
        public List<Workflow> RetrieveWorkflows()
        {
            var results = new List<Workflow>();
            foreach (var file in Directory.GetFiles(Application.StartupPath).Where(x => x.ToLower().EndsWith(".dll")))
            {
                try
                {
                    var assembly = Assembly.LoadFrom(file);
                    foreach (var type in assembly.GetTypes())
                    {
                            if (type.BaseType == typeof(Workflow))
                            {
                                var workflow = (Workflow) Activator.CreateInstance(type);
                                results.Add(workflow);
                            }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed to load workflow for assembly " + file);
                }
            }
            return results;
        }
    }
}
