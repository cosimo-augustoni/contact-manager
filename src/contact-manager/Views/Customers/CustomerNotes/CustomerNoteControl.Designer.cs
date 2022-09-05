namespace contact_manager.Views.Customers.CustomerNotes
{
    partial class CustomerNoteControl
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblNoteText = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            this.LblTimestamp = new System.Windows.Forms.Label();
            this.LblConnector = new System.Windows.Forms.Label();
            this.PnlText = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlText.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblNoteText
            // 
            this.LblNoteText.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNoteText.Location = new System.Drawing.Point(3, 0);
            this.LblNoteText.MaximumSize = new System.Drawing.Size(1600, 0);
            this.LblNoteText.Name = "LblNoteText";
            this.LblNoteText.Size = new System.Drawing.Size(1550, 46);
            this.LblNoteText.TabIndex = 0;
            this.LblNoteText.Text = "Notiztext";
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblUser.Location = new System.Drawing.Point(257, 0);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(104, 38);
            this.LblUser.TabIndex = 1;
            this.LblUser.Text = "creator";
            // 
            // LblTimestamp
            // 
            this.LblTimestamp.AutoSize = true;
            this.LblTimestamp.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTimestamp.Location = new System.Drawing.Point(401, 0);
            this.LblTimestamp.Name = "LblTimestamp";
            this.LblTimestamp.Size = new System.Drawing.Size(223, 38);
            this.LblTimestamp.TabIndex = 2;
            this.LblTimestamp.Text = "22.08.2022 16:30";
            // 
            // LblConnector
            // 
            this.LblConnector.AutoSize = true;
            this.LblConnector.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblConnector.Location = new System.Drawing.Point(367, 0);
            this.LblConnector.Name = "LblConnector";
            this.LblConnector.Size = new System.Drawing.Size(28, 38);
            this.LblConnector.TabIndex = 3;
            this.LblConnector.Text = "-";
            // 
            // PnlText
            // 
            this.PnlText.AutoSize = true;
            this.PnlText.BackColor = System.Drawing.Color.White;
            this.PnlText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlText.Controls.Add(this.LblNoteText);
            this.PnlText.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlText.Location = new System.Drawing.Point(3, 3);
            this.PnlText.MaximumSize = new System.Drawing.Size(1600, 0);
            this.PnlText.Name = "PnlText";
            this.PnlText.Size = new System.Drawing.Size(1558, 48);
            this.PnlText.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.PnlText);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(1600, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1600, 108);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.LblTimestamp);
            this.flowLayoutPanel2.Controls.Add(this.LblConnector);
            this.flowLayoutPanel2.Controls.Add(this.LblUser);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(934, 57);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(627, 48);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // CustomerNoteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(0, 470);
            this.Name = "CustomerNoteControl";
            this.Size = new System.Drawing.Size(1606, 118);
            this.PnlText.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblNoteText;
        private Label LblUser;
        private Label LblTimestamp;
        private Label LblConnector;
        private Panel PnlText;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}
