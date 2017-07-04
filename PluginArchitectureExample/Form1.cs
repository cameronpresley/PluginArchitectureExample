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
        }
    }
}
