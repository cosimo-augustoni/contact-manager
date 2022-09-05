namespace contact_manager.Views.Customers.CustomerNotes
{
    partial class CustomerNotesDialog
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
            this.PnlNotes = new System.Windows.Forms.FlowLayoutPanel();
            this.TxtNewNote = new System.Windows.Forms.TextBox();
            this.CmdAddNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PnlNotes
            // 
            this.PnlNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlNotes.Location = new System.Drawing.Point(12, 157);
            this.PnlNotes.Name = "PnlNotes";
            this.PnlNotes.Size = new System.Drawing.Size(1594, 743);
            this.PnlNotes.TabIndex = 0;
            // 
            // TxtNewNote
            // 
            this.TxtNewNote.Location = new System.Drawing.Point(12, 12);
            this.TxtNewNote.Multiline = true;
            this.TxtNewNote.Name = "TxtNewNote";
            this.TxtNewNote.PlaceholderText = "Neue Notiz erfassen";
            this.TxtNewNote.Size = new System.Drawing.Size(1343, 139);
            this.TxtNewNote.TabIndex = 1;
            // 
            // CmdAddNote
            // 
            this.CmdAddNote.Location = new System.Drawing.Point(1361, 93);
            this.CmdAddNote.Name = "CmdAddNote";
            this.CmdAddNote.Size = new System.Drawing.Size(245, 58);
            this.CmdAddNote.TabIndex = 2;
            this.CmdAddNote.Text = "Erfassen";
            this.CmdAddNote.UseVisualStyleBackColor = true;
            this.CmdAddNote.Click += new System.EventHandler(this.CmdAddNote_Click);
            // 
            // CustomerNotesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 912);
            this.Controls.Add(this.CmdAddNote);
            this.Controls.Add(this.TxtNewNote);
            this.Controls.Add(this.PnlNotes);
            this.Name = "CustomerNotesDialog";
            this.Text = "Notizen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel PnlNotes;
        private TextBox TxtNewNote;
        private Button CmdAddNote;
    }
}