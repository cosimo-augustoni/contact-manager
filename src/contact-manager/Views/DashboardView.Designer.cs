namespace contact_manager.Views
{
    partial class DashboardView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdCreateNewEmployee = new System.Windows.Forms.Button();
            this.CmdCreateNewCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdCreateNewEmployee
            // 
            this.CmdCreateNewEmployee.Location = new System.Drawing.Point(133, 60);
            this.CmdCreateNewEmployee.Name = "CmdCreateNewEmployee";
            this.CmdCreateNewEmployee.Size = new System.Drawing.Size(156, 23);
            this.CmdCreateNewEmployee.TabIndex = 0;
            this.CmdCreateNewEmployee.Text = "Create New Employee";
            this.CmdCreateNewEmployee.UseVisualStyleBackColor = true;
            this.CmdCreateNewEmployee.Click += new System.EventHandler(this.CmdCreateNewEmployee_Click);
            // 
            // CmdCreateNewCustomer
            // 
            this.CmdCreateNewCustomer.Location = new System.Drawing.Point(133, 103);
            this.CmdCreateNewCustomer.Name = "CmdCreateNewCustomer";
            this.CmdCreateNewCustomer.Size = new System.Drawing.Size(156, 23);
            this.CmdCreateNewCustomer.TabIndex = 1;
            this.CmdCreateNewCustomer.Text = "Create New Customer";
            this.CmdCreateNewCustomer.UseVisualStyleBackColor = true;
            this.CmdCreateNewCustomer.Click += new System.EventHandler(this.CmdCreateNewCustomer_Click);
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdCreateNewCustomer);
            this.Controls.Add(this.CmdCreateNewEmployee);
            this.Name = "DashboardView";
            this.Text = "DashboardView";
            this.ResumeLayout(false);

        }

        #endregion

        private Button CmdCreateNewEmployee;
        private Button CmdCreateNewCustomer;
    }
}