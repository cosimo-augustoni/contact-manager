﻿namespace contact_manager.Views
{
    partial class HistoryDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryDialog));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.FlowLayoutPnlHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.LblTitel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowLayoutPnlHistory
            // 
            this.FlowLayoutPnlHistory.AutoScroll = true;
            this.FlowLayoutPnlHistory.BackColor = System.Drawing.SystemColors.Control;
            this.FlowLayoutPnlHistory.Location = new System.Drawing.Point(29, 52);
            this.FlowLayoutPnlHistory.Name = "FlowLayoutPnlHistory";
            this.FlowLayoutPnlHistory.Size = new System.Drawing.Size(434, 484);
            this.FlowLayoutPnlHistory.TabIndex = 1;
            // 
            // LblTitel
            // 
            this.LblTitel.AutoSize = true;
            this.LblTitel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitel.Location = new System.Drawing.Point(29, 19);
            this.LblTitel.Name = "LblTitel";
            this.LblTitel.Size = new System.Drawing.Size(44, 21);
            this.LblTitel.TabIndex = 2;
            this.LblTitel.Text = "Titel";
            // 
            // HistoryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 561);
            this.Controls.Add(this.LblTitel);
            this.Controls.Add(this.FlowLayoutPnlHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistoryDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change-History";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource bindingSource1;
        private FlowLayoutPanel FlowLayoutPnlHistory;
        private Label LblTitel;
    }
}
