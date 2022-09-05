namespace contact_manager.Views.Authentication
{
    partial class LoginView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      this.TxtUserName = new System.Windows.Forms.TextBox();
      this.LblUserName = new System.Windows.Forms.Label();
      this.LblPassword = new System.Windows.Forms.Label();
      this.TxtPassword = new System.Windows.Forms.TextBox();
      this.CmdLogin = new System.Windows.Forms.Button();
      this.LoginErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider)).BeginInit();
      this.SuspendLayout();
      // 
      // TxtUserName
      // 
      this.TxtUserName.Location = new System.Drawing.Point(86, 12);
      this.TxtUserName.Name = "TxtUserName";
      this.TxtUserName.Size = new System.Drawing.Size(248, 23);
      this.TxtUserName.TabIndex = 0;
      this.TxtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUserName_Validating);
      // 
      // LblUserName
      // 
      this.LblUserName.AutoSize = true;
      this.LblUserName.Location = new System.Drawing.Point(12, 15);
      this.LblUserName.Name = "LblUserName";
      this.LblUserName.Size = new System.Drawing.Size(68, 15);
      this.LblUserName.TabIndex = 1;
      this.LblUserName.Text = "User Name:";
      // 
      // LblPassword
      // 
      this.LblPassword.AutoSize = true;
      this.LblPassword.Location = new System.Drawing.Point(12, 44);
      this.LblPassword.Name = "LblPassword";
      this.LblPassword.Size = new System.Drawing.Size(57, 15);
      this.LblPassword.TabIndex = 3;
      this.LblPassword.Text = "Passwort:";
      // 
      // TxtPassword
      // 
      this.TxtPassword.Location = new System.Drawing.Point(86, 41);
      this.TxtPassword.Name = "TxtPassword";
      this.TxtPassword.PasswordChar = '*';
      this.TxtPassword.Size = new System.Drawing.Size(248, 23);
      this.TxtPassword.TabIndex = 2;
      this.TxtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPassword_Validating);
      // 
      // CmdLogin
      // 
      this.CmdLogin.Location = new System.Drawing.Point(259, 70);
      this.CmdLogin.Name = "CmdLogin";
      this.CmdLogin.Size = new System.Drawing.Size(75, 23);
      this.CmdLogin.TabIndex = 4;
      this.CmdLogin.Text = "Anmelden";
      this.CmdLogin.UseVisualStyleBackColor = true;
      this.CmdLogin.Click += new System.EventHandler(this.CmdLogin_Click);
      // 
      // LoginErrorProvider
      // 
      this.LoginErrorProvider.ContainerControl = this;
      // 
      // LoginView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(380, 111);
      this.Controls.Add(this.CmdLogin);
      this.Controls.Add(this.LblPassword);
      this.Controls.Add(this.TxtPassword);
      this.Controls.Add(this.LblUserName);
      this.Controls.Add(this.TxtUserName);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "LoginView";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Login";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginView_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private TextBox TxtUserName;
        private Label LblUserName;
        private Label LblPassword;
        private TextBox TxtPassword;
        private Button CmdLogin;
        private ErrorProvider LoginErrorProvider;
    }
}
