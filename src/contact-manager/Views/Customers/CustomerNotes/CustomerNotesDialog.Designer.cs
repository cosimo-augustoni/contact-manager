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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerNotesDialog));
            this.PnlNotes = new System.Windows.Forms.FlowLayoutPanel();
            this.TxtNewNote = new System.Windows.Forms.TextBox();
            this.CmdAddNote = new System.Windows.Forms.Button();
            this.CustomerNoteErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNoteErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlNotes
            // 
            this.PnlNotes.AutoScroll = true;
            this.PnlNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlNotes.Location = new System.Drawing.Point(5, 59);
            this.PnlNotes.Margin = new System.Windows.Forms.Padding(1);
            this.PnlNotes.Name = "PnlNotes";
            this.PnlNotes.Size = new System.Drawing.Size(658, 559);
            this.PnlNotes.TabIndex = 0;
            // 
            // TxtNewNote
            // 
            this.TxtNewNote.Location = new System.Drawing.Point(5, 4);
            this.TxtNewNote.Margin = new System.Windows.Forms.Padding(1);
            this.TxtNewNote.Multiline = true;
            this.TxtNewNote.Name = "TxtNewNote";
            this.TxtNewNote.PlaceholderText = "Neue Notiz erfassen";
            this.TxtNewNote.Size = new System.Drawing.Size(555, 53);
            this.TxtNewNote.TabIndex = 1;
            this.TxtNewNote.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNewNote_Validating);
            // 
            // CmdAddNote
            // 
            this.CmdAddNote.Location = new System.Drawing.Point(562, 36);
            this.CmdAddNote.Margin = new System.Windows.Forms.Padding(1);
            this.CmdAddNote.Name = "CmdAddNote";
            this.CmdAddNote.Size = new System.Drawing.Size(101, 21);
            this.CmdAddNote.TabIndex = 2;
            this.CmdAddNote.Text = "Erfassen";
            this.CmdAddNote.UseVisualStyleBackColor = true;
            this.CmdAddNote.Click += new System.EventHandler(this.CmdAddNote_Click);
            // 
            // CustomerNoteErrorProvider
            // 
            this.CustomerNoteErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.CustomerNoteErrorProvider.ContainerControl = this;
            // 
            // CustomerNotesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(667, 620);
            this.Controls.Add(this.CmdAddNote);
            this.Controls.Add(this.TxtNewNote);
            this.Controls.Add(this.PnlNotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "CustomerNotesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notizen";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNoteErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel PnlNotes;
        private TextBox TxtNewNote;
        private Button CmdAddNote;
        private ErrorProvider CustomerNoteErrorProvider;
    }
}