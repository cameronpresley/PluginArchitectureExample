using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plugin.Core;

namespace PluginArchitectureExample
{
    public partial class Form1 : Form
    {
        public Form1(List<Workflow> workflows)
        {
            InitializeComponent();
            Console.WriteLine(workflows.Count);
            cmbWorkflows.Items.AddRange(workflows.ToArray());
            if (cmbWorkflows.Items.Count > 0)
            {
                cmbWorkflows.SelectedIndex = 0;
            }
        }

        private void btnDoWorkflow_Click(object sender, EventArgs e)
        {
            var selectedItem = cmbWorkflows.SelectedItem;
            if (selectedItem == null) return;
            if (!(selectedItem is Workflow)) return;
            var workflow = (Workflow) selectedItem;
            workflow.Do();
        }
    }
}
