namespace contact_manager.Views.Customers
{
    partial class CustomerDetailDialog
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
      this.CmdSave = new System.Windows.Forms.Button();
      this.TxtFirstName = new System.Windows.Forms.TextBox();
      this.LblFirstName = new System.Windows.Forms.Label();
      this.LblCustomer = new System.Windows.Forms.Label();
      this.LblLastname = new System.Windows.Forms.Label();
      this.TxtLastname = new System.Windows.Forms.TextBox();
      this.CmdClose = new System.Windows.Forms.Button();
      this.CmbSalutation = new System.Windows.Forms.ComboBox();
      this.LblSalutation = new System.Windows.Forms.Label();
      this.DateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
      this.LblBirthDate = new System.Windows.Forms.Label();
      this.LblStatus = new System.Windows.Forms.Label();
      this.CmbStatus = new System.Windows.Forms.ComboBox();
      this.GBContactData = new System.Windows.Forms.GroupBox();
      this.GbPersonalData = new System.Windows.Forms.GroupBox();
      this.TxtTitle = new System.Windows.Forms.TextBox();
      this.LblTitle = new System.Windows.Forms.Label();
      this.TxtCustomerId = new System.Windows.Forms.TextBox();
      this.LblCustomerId = new System.Windows.Forms.Label();
      this.TxtSsn = new System.Windows.Forms.TextBox();
      this.LblSsn = new System.Windows.Forms.Label();
      this.LblGender = new System.Windows.Forms.Label();
      this.CmbGender = new System.Windows.Forms.ComboBox();
      this.GbAddress = new System.Windows.Forms.GroupBox();
      this.LblCity = new System.Windows.Forms.Label();
      this.TxtCity = new System.Windows.Forms.TextBox();
      this.TxtPostalCode = new System.Windows.Forms.TextBox();
      this.LblPostalCode = new System.Windows.Forms.Label();
      this.TxtStreetNumber = new System.Windows.Forms.TextBox();
      this.LblStreetNumber = new System.Windows.Forms.Label();
      this.TxtStreet = new System.Windows.Forms.TextBox();
      this.LblStreet = new System.Windows.Forms.Label();
      this.GbNotes = new System.Windows.Forms.GroupBox();
      this.GbPersonalData.SuspendLayout();
      this.GbAddress.SuspendLayout();
      this.SuspendLayout();
      // 
      // CmdSave
      // 
      this.CmdSave.Location = new System.Drawing.Point(554, 565);
      this.CmdSave.Name = "CmdSave";
      this.CmdSave.Size = new System.Drawing.Size(75, 23);
      this.CmdSave.TabIndex = 0;
      this.CmdSave.Text = "Save";
      this.CmdSave.UseVisualStyleBackColor = true;
      this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
      // 
      // TxtFirstName
      // 
      this.TxtFirstName.Location = new System.Drawing.Point(161, 79);
      this.TxtFirstName.Name = "TxtFirstName";
      this.TxtFirstName.Size = new System.Drawing.Size(183, 23);
      this.TxtFirstName.TabIndex = 1;
      // 
      // LblFirstName
      // 
      this.LblFirstName.AutoSize = true;
      this.LblFirstName.Location = new System.Drawing.Point(6, 82);
      this.LblFirstName.Name = "LblFirstName";
      this.LblFirstName.Size = new System.Drawing.Size(54, 15);
      this.LblFirstName.TabIndex = 2;
      this.LblFirstName.Text = "Vorname";
      // 
      // LblCustomer
      // 
      this.LblCustomer.AutoSize = true;
      this.LblCustomer.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.LblCustomer.Location = new System.Drawing.Point(12, 9);
      this.LblCustomer.Name = "LblCustomer";
      this.LblCustomer.Size = new System.Drawing.Size(480, 37);
      this.LblCustomer.TabIndex = 3;
      this.LblCustomer.Text = "Kunde (wird noch mit Infos ergänzt)";
      // 
      // LblLastname
      // 
      this.LblLastname.AutoSize = true;
      this.LblLastname.Location = new System.Drawing.Point(6, 111);
      this.LblLastname.Name = "LblLastname";
      this.LblLastname.Size = new System.Drawing.Size(65, 15);
      this.LblLastname.TabIndex = 5;
      this.LblLastname.Text = "Nachname";
      // 
      // TxtLastname
      // 
      this.TxtLastname.Location = new System.Drawing.Point(161, 108);
      this.TxtLastname.Name = "TxtLastname";
      this.TxtLastname.Size = new System.Drawing.Size(183, 23);
      this.TxtLastname.TabIndex = 4;
      // 
      // CmdClose
      // 
      this.CmdClose.Location = new System.Drawing.Point(635, 565);
      this.CmdClose.Name = "CmdClose";
      this.CmdClose.Size = new System.Drawing.Size(75, 23);
      this.CmdClose.TabIndex = 7;
      this.CmdClose.Text = "Close";
      this.CmdClose.UseVisualStyleBackColor = true;
      this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
      // 
      // CmbSalutation
      // 
      this.CmbSalutation.FormattingEnabled = true;
      this.CmbSalutation.Location = new System.Drawing.Point(161, 50);
      this.CmbSalutation.Name = "CmbSalutation";
      this.CmbSalutation.Size = new System.Drawing.Size(183, 23);
      this.CmbSalutation.TabIndex = 8;
      // 
      // LblSalutation
      // 
      this.LblSalutation.AutoSize = true;
      this.LblSalutation.Location = new System.Drawing.Point(6, 53);
      this.LblSalutation.Name = "LblSalutation";
      this.LblSalutation.Size = new System.Drawing.Size(45, 15);
      this.LblSalutation.TabIndex = 9;
      this.LblSalutation.Text = "Anrede";
      // 
      // DateTimePickerBirthDate
      // 
      this.DateTimePickerBirthDate.Location = new System.Drawing.Point(593, 108);
      this.DateTimePickerBirthDate.Name = "DateTimePickerBirthDate";
      this.DateTimePickerBirthDate.Size = new System.Drawing.Size(200, 23);
      this.DateTimePickerBirthDate.TabIndex = 10;
      // 
      // LblBirthDate
      // 
      this.LblBirthDate.AutoSize = true;
      this.LblBirthDate.Location = new System.Drawing.Point(507, 108);
      this.LblBirthDate.Name = "LblBirthDate";
      this.LblBirthDate.Size = new System.Drawing.Size(83, 15);
      this.LblBirthDate.TabIndex = 11;
      this.LblBirthDate.Text = "Geburtsdatum";
      // 
      // LblStatus
      // 
      this.LblStatus.AutoSize = true;
      this.LblStatus.Location = new System.Drawing.Point(507, 19);
      this.LblStatus.Name = "LblStatus";
      this.LblStatus.Size = new System.Drawing.Size(39, 15);
      this.LblStatus.TabIndex = 13;
      this.LblStatus.Text = "Status";
      // 
      // CmbStatus
      // 
      this.CmbStatus.FormattingEnabled = true;
      this.CmbStatus.Location = new System.Drawing.Point(593, 16);
      this.CmbStatus.Name = "CmbStatus";
      this.CmbStatus.Size = new System.Drawing.Size(183, 23);
      this.CmbStatus.TabIndex = 12;
      // 
      // GBContactData
      // 
      this.GBContactData.Location = new System.Drawing.Point(12, 391);
      this.GBContactData.Name = "GBContactData";
      this.GBContactData.Size = new System.Drawing.Size(355, 100);
      this.GBContactData.TabIndex = 14;
      this.GBContactData.TabStop = false;
      this.GBContactData.Text = "Kontaktangaben";
      // 
      // GbPersonalData
      // 
      this.GbPersonalData.Controls.Add(this.TxtTitle);
      this.GbPersonalData.Controls.Add(this.LblTitle);
      this.GbPersonalData.Controls.Add(this.TxtCustomerId);
      this.GbPersonalData.Controls.Add(this.LblCustomerId);
      this.GbPersonalData.Controls.Add(this.TxtSsn);
      this.GbPersonalData.Controls.Add(this.LblSsn);
      this.GbPersonalData.Controls.Add(this.LblGender);
      this.GbPersonalData.Controls.Add(this.CmbGender);
      this.GbPersonalData.Controls.Add(this.LblSalutation);
      this.GbPersonalData.Controls.Add(this.TxtFirstName);
      this.GbPersonalData.Controls.Add(this.LblStatus);
      this.GbPersonalData.Controls.Add(this.CmbStatus);
      this.GbPersonalData.Controls.Add(this.LblFirstName);
      this.GbPersonalData.Controls.Add(this.TxtLastname);
      this.GbPersonalData.Controls.Add(this.LblBirthDate);
      this.GbPersonalData.Controls.Add(this.LblLastname);
      this.GbPersonalData.Controls.Add(this.DateTimePickerBirthDate);
      this.GbPersonalData.Controls.Add(this.CmbSalutation);
      this.GbPersonalData.Location = new System.Drawing.Point(12, 86);
      this.GbPersonalData.Name = "GbPersonalData";
      this.GbPersonalData.Size = new System.Drawing.Size(971, 193);
      this.GbPersonalData.TabIndex = 15;
      this.GbPersonalData.TabStop = false;
      this.GbPersonalData.Text = "Person";
      // 
      // TxtTitle
      // 
      this.TxtTitle.Location = new System.Drawing.Point(161, 139);
      this.TxtTitle.Name = "TxtTitle";
      this.TxtTitle.Size = new System.Drawing.Size(183, 23);
      this.TxtTitle.TabIndex = 21;
      // 
      // LblTitle
      // 
      this.LblTitle.AutoSize = true;
      this.LblTitle.Location = new System.Drawing.Point(6, 142);
      this.LblTitle.Name = "LblTitle";
      this.LblTitle.Size = new System.Drawing.Size(29, 15);
      this.LblTitle.TabIndex = 22;
      this.LblTitle.Text = "Titel";
      // 
      // TxtCustomerId
      // 
      this.TxtCustomerId.Location = new System.Drawing.Point(161, 16);
      this.TxtCustomerId.Name = "TxtCustomerId";
      this.TxtCustomerId.ReadOnly = true;
      this.TxtCustomerId.Size = new System.Drawing.Size(183, 23);
      this.TxtCustomerId.TabIndex = 20;
      this.TxtCustomerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // LblCustomerId
      // 
      this.LblCustomerId.AutoSize = true;
      this.LblCustomerId.Location = new System.Drawing.Point(6, 19);
      this.LblCustomerId.Name = "LblCustomerId";
      this.LblCustomerId.Size = new System.Drawing.Size(69, 15);
      this.LblCustomerId.TabIndex = 19;
      this.LblCustomerId.Text = "Kunden-Nr.";
      // 
      // TxtSsn
      // 
      this.TxtSsn.Location = new System.Drawing.Point(593, 74);
      this.TxtSsn.Name = "TxtSsn";
      this.TxtSsn.Size = new System.Drawing.Size(183, 23);
      this.TxtSsn.TabIndex = 16;
      // 
      // LblSsn
      // 
      this.LblSsn.AutoSize = true;
      this.LblSsn.Location = new System.Drawing.Point(507, 77);
      this.LblSsn.Name = "LblSsn";
      this.LblSsn.Size = new System.Drawing.Size(52, 15);
      this.LblSsn.TabIndex = 17;
      this.LblSsn.Text = "AHV-Nr.";
      // 
      // LblGender
      // 
      this.LblGender.AutoSize = true;
      this.LblGender.Location = new System.Drawing.Point(507, 48);
      this.LblGender.Name = "LblGender";
      this.LblGender.Size = new System.Drawing.Size(65, 15);
      this.LblGender.TabIndex = 15;
      this.LblGender.Text = "Geschlecht";
      // 
      // CmbGender
      // 
      this.CmbGender.FormattingEnabled = true;
      this.CmbGender.Location = new System.Drawing.Point(593, 45);
      this.CmbGender.Name = "CmbGender";
      this.CmbGender.Size = new System.Drawing.Size(183, 23);
      this.CmbGender.TabIndex = 14;
      // 
      // GbAddress
      // 
      this.GbAddress.Controls.Add(this.LblCity);
      this.GbAddress.Controls.Add(this.TxtCity);
      this.GbAddress.Controls.Add(this.TxtPostalCode);
      this.GbAddress.Controls.Add(this.LblPostalCode);
      this.GbAddress.Controls.Add(this.TxtStreetNumber);
      this.GbAddress.Controls.Add(this.LblStreetNumber);
      this.GbAddress.Controls.Add(this.TxtStreet);
      this.GbAddress.Controls.Add(this.LblStreet);
      this.GbAddress.Location = new System.Drawing.Point(12, 285);
      this.GbAddress.Name = "GbAddress";
      this.GbAddress.Size = new System.Drawing.Size(971, 100);
      this.GbAddress.TabIndex = 16;
      this.GbAddress.TabStop = false;
      this.GbAddress.Text = "Adresse";
      // 
      // LblCity
      // 
      this.LblCity.AutoSize = true;
      this.LblCity.Location = new System.Drawing.Point(508, 48);
      this.LblCity.Name = "LblCity";
      this.LblCity.Size = new System.Drawing.Size(56, 15);
      this.LblCity.TabIndex = 28;
      this.LblCity.Text = "Ortschaft";
      // 
      // TxtCity
      // 
      this.TxtCity.Location = new System.Drawing.Point(593, 45);
      this.TxtCity.Name = "TxtCity";
      this.TxtCity.Size = new System.Drawing.Size(183, 23);
      this.TxtCity.TabIndex = 18;
      // 
      // TxtPostalCode
      // 
      this.TxtPostalCode.Location = new System.Drawing.Point(161, 45);
      this.TxtPostalCode.Name = "TxtPostalCode";
      this.TxtPostalCode.Size = new System.Drawing.Size(183, 23);
      this.TxtPostalCode.TabIndex = 27;
      this.TxtPostalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.TxtPostalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPostalCode_KeyPress);
      // 
      // LblPostalCode
      // 
      this.LblPostalCode.AutoSize = true;
      this.LblPostalCode.Location = new System.Drawing.Point(6, 45);
      this.LblPostalCode.Name = "LblPostalCode";
      this.LblPostalCode.Size = new System.Drawing.Size(67, 15);
      this.LblPostalCode.TabIndex = 26;
      this.LblPostalCode.Text = "Postleitzahl";
      // 
      // TxtStreetNumber
      // 
      this.TxtStreetNumber.Location = new System.Drawing.Point(593, 16);
      this.TxtStreetNumber.Name = "TxtStreetNumber";
      this.TxtStreetNumber.Size = new System.Drawing.Size(183, 23);
      this.TxtStreetNumber.TabIndex = 25;
      // 
      // LblStreetNumber
      // 
      this.LblStreetNumber.AutoSize = true;
      this.LblStreetNumber.Location = new System.Drawing.Point(507, 19);
      this.LblStreetNumber.Name = "LblStreetNumber";
      this.LblStreetNumber.Size = new System.Drawing.Size(23, 15);
      this.LblStreetNumber.TabIndex = 23;
      this.LblStreetNumber.Text = "Nr.";
      // 
      // TxtStreet
      // 
      this.TxtStreet.Location = new System.Drawing.Point(161, 16);
      this.TxtStreet.Name = "TxtStreet";
      this.TxtStreet.Size = new System.Drawing.Size(183, 23);
      this.TxtStreet.TabIndex = 23;
      // 
      // LblStreet
      // 
      this.LblStreet.AutoSize = true;
      this.LblStreet.Location = new System.Drawing.Point(6, 19);
      this.LblStreet.Name = "LblStreet";
      this.LblStreet.Size = new System.Drawing.Size(43, 15);
      this.LblStreet.TabIndex = 24;
      this.LblStreet.Text = "Strasse";
      // 
      // GbNotes
      // 
      this.GbNotes.Location = new System.Drawing.Point(948, 422);
      this.GbNotes.Name = "GbNotes";
      this.GbNotes.Size = new System.Drawing.Size(200, 100);
      this.GbNotes.TabIndex = 17;
      this.GbNotes.TabStop = false;
      this.GbNotes.Text = "Notizen";
      // 
      // CustomerDetailDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1435, 773);
      this.Controls.Add(this.GbNotes);
      this.Controls.Add(this.GbAddress);
      this.Controls.Add(this.GbPersonalData);
      this.Controls.Add(this.GBContactData);
      this.Controls.Add(this.CmdClose);
      this.Controls.Add(this.LblCustomer);
      this.Controls.Add(this.CmdSave);
      this.Name = "CustomerDetailDialog";
      this.Text = "CustomerDetailDialog";
      this.GbPersonalData.ResumeLayout(false);
      this.GbPersonalData.PerformLayout();
      this.GbAddress.ResumeLayout(false);
      this.GbAddress.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private Button CmdSave;
        private TextBox TxtFirstName;
    private Label LblFirstName;
    private Label LblCustomer;
    private Label LblLastname;
    private TextBox TxtLastname;
    private Button CmdClose;
    private ComboBox CmbSalutation;
    private Label LblSalutation;
    private DateTimePicker DateTimePickerBirthDate;
    private Label LblBirthDate;
    private Label LblStatus;
    private ComboBox CmbStatus;
    private GroupBox GBContactData;
    private GroupBox GbPersonalData;
    private TextBox TxtCustomerId;
    private Label LblCustomerId;
    private TextBox TxtSsn;
    private Label LblSsn;
    private Label LblGender;
    private ComboBox CmbGender;
    private TextBox TxtTitle;
    private Label LblTitle;
    private GroupBox GbAddress;
    private TextBox TxtStreetNumber;
    private Label LblStreetNumber;
    private TextBox TxtStreet;
    private Label LblStreet;
    private TextBox TxtPostalCode;
    private Label LblPostalCode;
    private GroupBox GbNotes;
    private Label LblCity;
    private TextBox TxtCity;
  }
}