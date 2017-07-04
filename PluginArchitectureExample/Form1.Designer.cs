namespace PluginArchitectureExample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbWorkflows = new System.Windows.Forms.ComboBox();
            this.btnDoWorkflow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbWorkflows
            // 
            this.cmbWorkflows.FormattingEnabled = true;
            this.cmbWorkflows.Location = new System.Drawing.Point(195, 222);
            this.cmbWorkflows.Name = "cmbWorkflows";
            this.cmbWorkflows.Size = new System.Drawing.Size(383, 33);
            this.cmbWorkflows.TabIndex = 0;
            // 
            // btnDoWorkflow
            // 
            this.btnDoWorkflow.Location = new System.Drawing.Point(195, 342);
            this.btnDoWorkflow.Name = "btnDoWorkflow";
            this.btnDoWorkflow.Size = new System.Drawing.Size(383, 53);
            this.btnDoWorkflow.TabIndex = 1;
            this.btnDoWorkflow.Text = "Execute Workflow";
            this.btnDoWorkflow.UseVisualStyleBackColor = true;
            this.btnDoWorkflow.Click += new System.EventHandler(this.btnDoWorkflow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 576);
            this.Controls.Add(this.btnDoWorkflow);
            this.Controls.Add(this.cmbWorkflows);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbWorkflows;
        private System.Windows.Forms.Button btnDoWorkflow;
    }
}

