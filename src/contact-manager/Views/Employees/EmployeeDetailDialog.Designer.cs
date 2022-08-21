namespace contact_manager.Views.Employees
{
    partial class EmployeeDetailDialog
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
            this.LblEmployee = new System.Windows.Forms.Label();
            this.GrpPersonalData = new System.Windows.Forms.GroupBox();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtCustomerId = new System.Windows.Forms.TextBox();
            this.LblEmployeeId = new System.Windows.Forms.Label();
            this.TxtSsn = new System.Windows.Forms.TextBox();
            this.LblSsn = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.LblSalutation = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.TxtLastname = new System.Windows.Forms.TextBox();
            this.LblBirthDate = new System.Windows.Forms.Label();
            this.LblLastname = new System.Windows.Forms.Label();
            this.DateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.CmbSalutation = new System.Windows.Forms.ComboBox();
            this.GrpAddress = new System.Windows.Forms.GroupBox();
            this.LblCity = new System.Windows.Forms.Label();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtPostalCode = new System.Windows.Forms.TextBox();
            this.LblPostalCode = new System.Windows.Forms.Label();
            this.TxtStreetNumber = new System.Windows.Forms.TextBox();
            this.LblStreetNumber = new System.Windows.Forms.Label();
            this.TxtStreet = new System.Windows.Forms.TextBox();
            this.LblStreet = new System.Windows.Forms.Label();
            this.GrpContactData = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.LblFax = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LblPhoneBusiness = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LblPhonePrivate = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblMail = new System.Windows.Forms.Label();
            this.CmdClose = new System.Windows.Forms.Button();
            this.GrpEmploymentData = new System.Windows.Forms.GroupBox();
            this.LblExitDate = new System.Windows.Forms.Label();
            this.DatePiExitDate = new System.Windows.Forms.DateTimePicker();
            this.LblEntryDate = new System.Windows.Forms.Label();
            this.NumCadreLevel = new System.Windows.Forms.NumericUpDown();
            this.DatePiEntryDate = new System.Windows.Forms.DateTimePicker();
            this.LblCadreLevel = new System.Windows.Forms.Label();
            this.NumEmployment = new System.Windows.Forms.NumericUpDown();
            this.LblEmployment = new System.Windows.Forms.Label();
            this.TxtRole = new System.Windows.Forms.TextBox();
            this.LblRole = new System.Windows.Forms.Label();
            this.TxtDeparment = new System.Windows.Forms.TextBox();
            this.LblDepartment = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GrpPersonalData.SuspendLayout();
            this.GrpAddress.SuspendLayout();
            this.GrpContactData.SuspendLayout();
            this.GrpEmploymentData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCadreLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEmployment)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(963, 570);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(75, 23);
            this.CmdSave.TabIndex = 1;
            this.CmdSave.Text = "Speichern";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // LblEmployee
            // 
            this.LblEmployee.AutoSize = true;
            this.LblEmployee.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblEmployee.Location = new System.Drawing.Point(12, 12);
            this.LblEmployee.Name = "LblEmployee";
            this.LblEmployee.Size = new System.Drawing.Size(165, 37);
            this.LblEmployee.TabIndex = 4;
            this.LblEmployee.Text = "Mitarbeiter";
            // 
            // GrpPersonalData
            // 
            this.GrpPersonalData.Controls.Add(this.TxtTitle);
            this.GrpPersonalData.Controls.Add(this.LblTitle);
            this.GrpPersonalData.Controls.Add(this.TxtCustomerId);
            this.GrpPersonalData.Controls.Add(this.LblEmployeeId);
            this.GrpPersonalData.Controls.Add(this.TxtSsn);
            this.GrpPersonalData.Controls.Add(this.LblSsn);
            this.GrpPersonalData.Controls.Add(this.LblGender);
            this.GrpPersonalData.Controls.Add(this.CmbGender);
            this.GrpPersonalData.Controls.Add(this.LblSalutation);
            this.GrpPersonalData.Controls.Add(this.TxtFirstName);
            this.GrpPersonalData.Controls.Add(this.LblStatus);
            this.GrpPersonalData.Controls.Add(this.CmbStatus);
            this.GrpPersonalData.Controls.Add(this.LblFirstName);
            this.GrpPersonalData.Controls.Add(this.TxtLastname);
            this.GrpPersonalData.Controls.Add(this.LblBirthDate);
            this.GrpPersonalData.Controls.Add(this.LblLastname);
            this.GrpPersonalData.Controls.Add(this.DateTimePickerBirthDate);
            this.GrpPersonalData.Controls.Add(this.CmbSalutation);
            this.GrpPersonalData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GrpPersonalData.Location = new System.Drawing.Point(12, 78);
            this.GrpPersonalData.Name = "GrpPersonalData";
            this.GrpPersonalData.Size = new System.Drawing.Size(704, 210);
            this.GrpPersonalData.TabIndex = 16;
            this.GrpPersonalData.TabStop = false;
            this.GrpPersonalData.Text = "Person";
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
            // LblEmployeeId
            // 
            this.LblEmployeeId.AutoSize = true;
            this.LblEmployeeId.Location = new System.Drawing.Point(6, 19);
            this.LblEmployeeId.Name = "LblEmployeeId";
            this.LblEmployeeId.Size = new System.Drawing.Size(86, 15);
            this.LblEmployeeId.TabIndex = 19;
            this.LblEmployeeId.Text = "Mitarbeiter-Nr.";
            // 
            // TxtSsn
            // 
            this.TxtSsn.Location = new System.Drawing.Point(492, 74);
            this.TxtSsn.Name = "TxtSsn";
            this.TxtSsn.Size = new System.Drawing.Size(183, 23);
            this.TxtSsn.TabIndex = 16;
            // 
            // LblSsn
            // 
            this.LblSsn.AutoSize = true;
            this.LblSsn.Location = new System.Drawing.Point(406, 79);
            this.LblSsn.Name = "LblSsn";
            this.LblSsn.Size = new System.Drawing.Size(52, 15);
            this.LblSsn.TabIndex = 17;
            this.LblSsn.Text = "AHV-Nr.";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Location = new System.Drawing.Point(406, 48);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(65, 15);
            this.LblGender.TabIndex = 15;
            this.LblGender.Text = "Geschlecht";
            // 
            // CmbGender
            // 
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Location = new System.Drawing.Point(492, 45);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(183, 23);
            this.CmbGender.TabIndex = 14;
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
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(161, 79);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(183, 23);
            this.TxtFirstName.TabIndex = 1;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(406, 19);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(39, 15);
            this.LblStatus.TabIndex = 13;
            this.LblStatus.Text = "Status";
            // 
            // CmbStatus
            // 
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Location = new System.Drawing.Point(492, 16);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(183, 23);
            this.CmbStatus.TabIndex = 12;
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
            // TxtLastname
            // 
            this.TxtLastname.Location = new System.Drawing.Point(161, 108);
            this.TxtLastname.Name = "TxtLastname";
            this.TxtLastname.Size = new System.Drawing.Size(183, 23);
            this.TxtLastname.TabIndex = 4;
            // 
            // LblBirthDate
            // 
            this.LblBirthDate.AutoSize = true;
            this.LblBirthDate.Location = new System.Drawing.Point(403, 114);
            this.LblBirthDate.Name = "LblBirthDate";
            this.LblBirthDate.Size = new System.Drawing.Size(83, 15);
            this.LblBirthDate.TabIndex = 11;
            this.LblBirthDate.Text = "Geburtsdatum";
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
            // DateTimePickerBirthDate
            // 
            this.DateTimePickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerBirthDate.Location = new System.Drawing.Point(492, 108);
            this.DateTimePickerBirthDate.Name = "DateTimePickerBirthDate";
            this.DateTimePickerBirthDate.Size = new System.Drawing.Size(183, 23);
            this.DateTimePickerBirthDate.TabIndex = 10;
            // 
            // CmbSalutation
            // 
            this.CmbSalutation.FormattingEnabled = true;
            this.CmbSalutation.Location = new System.Drawing.Point(161, 50);
            this.CmbSalutation.Name = "CmbSalutation";
            this.CmbSalutation.Size = new System.Drawing.Size(183, 23);
            this.CmbSalutation.TabIndex = 8;
            // 
            // GrpAddress
            // 
            this.GrpAddress.Controls.Add(this.LblCity);
            this.GrpAddress.Controls.Add(this.TxtCity);
            this.GrpAddress.Controls.Add(this.TxtPostalCode);
            this.GrpAddress.Controls.Add(this.LblPostalCode);
            this.GrpAddress.Controls.Add(this.TxtStreetNumber);
            this.GrpAddress.Controls.Add(this.LblStreetNumber);
            this.GrpAddress.Controls.Add(this.TxtStreet);
            this.GrpAddress.Controls.Add(this.LblStreet);
            this.GrpAddress.Location = new System.Drawing.Point(12, 303);
            this.GrpAddress.Name = "GrpAddress";
            this.GrpAddress.Size = new System.Drawing.Size(704, 100);
            this.GrpAddress.TabIndex = 17;
            this.GrpAddress.TabStop = false;
            this.GrpAddress.Text = "Adresse";
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(407, 51);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(56, 15);
            this.LblCity.TabIndex = 28;
            this.LblCity.Text = "Ortschaft";
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(492, 48);
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
            this.TxtStreetNumber.Location = new System.Drawing.Point(492, 22);
            this.TxtStreetNumber.Name = "TxtStreetNumber";
            this.TxtStreetNumber.Size = new System.Drawing.Size(183, 23);
            this.TxtStreetNumber.TabIndex = 25;
            // 
            // LblStreetNumber
            // 
            this.LblStreetNumber.AutoSize = true;
            this.LblStreetNumber.Location = new System.Drawing.Point(406, 22);
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
            // GrpContactData
            // 
            this.GrpContactData.Controls.Add(this.textBox4);
            this.GrpContactData.Controls.Add(this.LblFax);
            this.GrpContactData.Controls.Add(this.textBox3);
            this.GrpContactData.Controls.Add(this.LblPhoneBusiness);
            this.GrpContactData.Controls.Add(this.textBox2);
            this.GrpContactData.Controls.Add(this.LblPhonePrivate);
            this.GrpContactData.Controls.Add(this.textBox1);
            this.GrpContactData.Controls.Add(this.LblMail);
            this.GrpContactData.Location = new System.Drawing.Point(12, 409);
            this.GrpContactData.Name = "GrpContactData";
            this.GrpContactData.Size = new System.Drawing.Size(364, 143);
            this.GrpContactData.TabIndex = 18;
            this.GrpContactData.TabStop = false;
            this.GrpContactData.Text = "Kontaktangaben";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(161, 109);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(183, 23);
            this.textBox4.TabIndex = 31;
            // 
            // LblFax
            // 
            this.LblFax.AutoSize = true;
            this.LblFax.Location = new System.Drawing.Point(6, 112);
            this.LblFax.Name = "LblFax";
            this.LblFax.Size = new System.Drawing.Size(74, 15);
            this.LblFax.TabIndex = 32;
            this.LblFax.Text = "Fax Geschäft";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(161, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(183, 23);
            this.textBox3.TabIndex = 29;
            // 
            // LblPhoneBusiness
            // 
            this.LblPhoneBusiness.AutoSize = true;
            this.LblPhoneBusiness.Location = new System.Drawing.Point(6, 83);
            this.LblPhoneBusiness.Name = "LblPhoneBusiness";
            this.LblPhoneBusiness.Size = new System.Drawing.Size(73, 15);
            this.LblPhoneBusiness.TabIndex = 30;
            this.LblPhoneBusiness.Text = "Tel. Geschäft";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 23);
            this.textBox2.TabIndex = 27;
            // 
            // LblPhonePrivate
            // 
            this.LblPhonePrivate.AutoSize = true;
            this.LblPhonePrivate.Location = new System.Drawing.Point(6, 54);
            this.LblPhonePrivate.Name = "LblPhonePrivate";
            this.LblPhonePrivate.Size = new System.Drawing.Size(57, 15);
            this.LblPhonePrivate.TabIndex = 28;
            this.LblPhonePrivate.Text = "Tel. Privat";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 23);
            this.textBox1.TabIndex = 25;
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.Location = new System.Drawing.Point(6, 25);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(41, 15);
            this.LblMail.TabIndex = 26;
            this.LblMail.Text = "E-Mail";
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(1044, 570);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(75, 23);
            this.CmdClose.TabIndex = 19;
            this.CmdClose.Text = "Schliessen";
            this.CmdClose.UseVisualStyleBackColor = true;
            // 
            // GrpEmploymentData
            // 
            this.GrpEmploymentData.Controls.Add(this.LblExitDate);
            this.GrpEmploymentData.Controls.Add(this.DatePiExitDate);
            this.GrpEmploymentData.Controls.Add(this.LblEntryDate);
            this.GrpEmploymentData.Controls.Add(this.NumCadreLevel);
            this.GrpEmploymentData.Controls.Add(this.DatePiEntryDate);
            this.GrpEmploymentData.Controls.Add(this.LblCadreLevel);
            this.GrpEmploymentData.Controls.Add(this.NumEmployment);
            this.GrpEmploymentData.Controls.Add(this.LblEmployment);
            this.GrpEmploymentData.Controls.Add(this.TxtRole);
            this.GrpEmploymentData.Controls.Add(this.LblRole);
            this.GrpEmploymentData.Controls.Add(this.TxtDeparment);
            this.GrpEmploymentData.Controls.Add(this.LblDepartment);
            this.GrpEmploymentData.Location = new System.Drawing.Point(736, 80);
            this.GrpEmploymentData.Name = "GrpEmploymentData";
            this.GrpEmploymentData.Size = new System.Drawing.Size(360, 208);
            this.GrpEmploymentData.TabIndex = 20;
            this.GrpEmploymentData.TabStop = false;
            this.GrpEmploymentData.Text = "Anstellung";
            // 
            // LblExitDate
            // 
            this.LblExitDate.AutoSize = true;
            this.LblExitDate.Location = new System.Drawing.Point(16, 174);
            this.LblExitDate.Name = "LblExitDate";
            this.LblExitDate.Size = new System.Drawing.Size(86, 15);
            this.LblExitDate.TabIndex = 31;
            this.LblExitDate.Text = "Austrittsdatum";
            // 
            // DatePiExitDate
            // 
            this.DatePiExitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePiExitDate.Location = new System.Drawing.Point(171, 169);
            this.DatePiExitDate.MinDate = new System.DateTime(2022, 8, 21, 0, 0, 0, 0);
            this.DatePiExitDate.Name = "DatePiExitDate";
            this.DatePiExitDate.Size = new System.Drawing.Size(183, 23);
            this.DatePiExitDate.TabIndex = 30;
            // 
            // LblEntryDate
            // 
            this.LblEntryDate.AutoSize = true;
            this.LblEntryDate.Location = new System.Drawing.Point(16, 145);
            this.LblEntryDate.Name = "LblEntryDate";
            this.LblEntryDate.Size = new System.Drawing.Size(82, 15);
            this.LblEntryDate.TabIndex = 22;
            this.LblEntryDate.Text = "Eintrittsdatum";
            // 
            // NumCadreLevel
            // 
            this.NumCadreLevel.Location = new System.Drawing.Point(171, 110);
            this.NumCadreLevel.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumCadreLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumCadreLevel.Name = "NumCadreLevel";
            this.NumCadreLevel.Size = new System.Drawing.Size(183, 23);
            this.NumCadreLevel.TabIndex = 29;
            this.NumCadreLevel.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // DatePiEntryDate
            // 
            this.DatePiEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePiEntryDate.Location = new System.Drawing.Point(171, 140);
            this.DatePiEntryDate.MinDate = new System.DateTime(2022, 8, 21, 0, 0, 0, 0);
            this.DatePiEntryDate.Name = "DatePiEntryDate";
            this.DatePiEntryDate.Size = new System.Drawing.Size(183, 23);
            this.DatePiEntryDate.TabIndex = 21;
            this.DatePiEntryDate.Value = new System.DateTime(2022, 8, 21, 11, 47, 15, 0);
            // 
            // LblCadreLevel
            // 
            this.LblCadreLevel.AutoSize = true;
            this.LblCadreLevel.Location = new System.Drawing.Point(16, 112);
            this.LblCadreLevel.Name = "LblCadreLevel";
            this.LblCadreLevel.Size = new System.Drawing.Size(63, 15);
            this.LblCadreLevel.TabIndex = 28;
            this.LblCadreLevel.Text = "Kaderstufe";
            // 
            // NumEmployment
            // 
            this.NumEmployment.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumEmployment.Location = new System.Drawing.Point(171, 81);
            this.NumEmployment.Name = "NumEmployment";
            this.NumEmployment.Size = new System.Drawing.Size(183, 23);
            this.NumEmployment.TabIndex = 27;
            this.NumEmployment.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // LblEmployment
            // 
            this.LblEmployment.AutoSize = true;
            this.LblEmployment.Location = new System.Drawing.Point(16, 83);
            this.LblEmployment.Name = "LblEmployment";
            this.LblEmployment.Size = new System.Drawing.Size(112, 15);
            this.LblEmployment.TabIndex = 26;
            this.LblEmployment.Text = "Beschäftigungsgrad";
            // 
            // TxtRole
            // 
            this.TxtRole.Location = new System.Drawing.Point(169, 22);
            this.TxtRole.Name = "TxtRole";
            this.TxtRole.Size = new System.Drawing.Size(183, 23);
            this.TxtRole.TabIndex = 25;
            // 
            // LblRole
            // 
            this.LblRole.AutoSize = true;
            this.LblRole.Location = new System.Drawing.Point(16, 22);
            this.LblRole.Name = "LblRole";
            this.LblRole.Size = new System.Drawing.Size(33, 15);
            this.LblRole.TabIndex = 24;
            this.LblRole.Text = "Rolle";
            // 
            // TxtDeparment
            // 
            this.TxtDeparment.Location = new System.Drawing.Point(169, 51);
            this.TxtDeparment.Name = "TxtDeparment";
            this.TxtDeparment.Size = new System.Drawing.Size(183, 23);
            this.TxtDeparment.TabIndex = 23;
            // 
            // LblDepartment
            // 
            this.LblDepartment.AutoSize = true;
            this.LblDepartment.Location = new System.Drawing.Point(16, 54);
            this.LblDepartment.Name = "LblDepartment";
            this.LblDepartment.Size = new System.Drawing.Size(59, 15);
            this.LblDepartment.TabIndex = 11;
            this.LblDepartment.Text = "Abteilung";
            // 
            // EmployeeDetailDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CmdClose;
            this.ClientSize = new System.Drawing.Size(1131, 605);
            this.Controls.Add(this.GrpEmploymentData);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.GrpContactData);
            this.Controls.Add(this.GrpAddress);
            this.Controls.Add(this.GrpPersonalData);
            this.Controls.Add(this.LblEmployee);
            this.Controls.Add(this.CmdSave);
            this.Name = "EmployeeDetailDialog";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mitarbeiter Dialog";
            this.TopMost = true;
            this.GrpPersonalData.ResumeLayout(false);
            this.GrpPersonalData.PerformLayout();
            this.GrpAddress.ResumeLayout(false);
            this.GrpAddress.PerformLayout();
            this.GrpContactData.ResumeLayout(false);
            this.GrpContactData.PerformLayout();
            this.GrpEmploymentData.ResumeLayout(false);
            this.GrpEmploymentData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCadreLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEmployment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button CmdSave;
        private Label LblEmployee;
        private GroupBox GrpPersonalData;
        private TextBox TxtTitle;
        private Label LblTitle;
        private TextBox TxtCustomerId;
        private Label LblEmployeeId;
        private TextBox TxtSsn;
        private Label LblSsn;
        private Label LblGender;
        private ComboBox CmbGender;
        private Label LblSalutation;
        private TextBox TxtFirstName;
        private Label LblStatus;
        private ComboBox CmbStatus;
        private Label LblFirstName;
        private TextBox TxtLastname;
        private Label LblBirthDate;
        private Label LblLastname;
        private DateTimePicker DateTimePickerBirthDate;
        private ComboBox CmbSalutation;
        private GroupBox GrpAddress;
        private Label LblCity;
        private TextBox TxtCity;
        private TextBox TxtPostalCode;
        private Label LblPostalCode;
        private TextBox TxtStreetNumber;
        private Label LblStreetNumber;
        private TextBox TxtStreet;
        private Label LblStreet;
        private GroupBox GrpContactData;
        private TextBox textBox4;
        private Label LblFax;
        private TextBox textBox3;
        private Label LblPhoneBusiness;
        private TextBox textBox2;
        private Label LblPhonePrivate;
        private TextBox textBox1;
        private Label LblMail;
        private Button CmdClose;
        private GroupBox GrpEmploymentData;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private NumericUpDown NumEmployment;
        private Label LblEmployment;
        private TextBox TxtRole;
        private Label LblRole;
        private TextBox TxtDeparment;
        private Label LblDepartment;
        private NumericUpDown NumCadreLevel;
        private Label LblCadreLevel;
        private Label LblExitDate;
        private DateTimePicker DatePiExitDate;
        private Label LblEntryDate;
        private DateTimePicker DatePiEntryDate;
    }
}
