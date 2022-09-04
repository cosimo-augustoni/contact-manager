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
      this.TxtNationality = new System.Windows.Forms.TextBox();
      this.LblNationality = new System.Windows.Forms.Label();
      this.MTxtAHV13 = new System.Windows.Forms.MaskedTextBox();
      this.TxtTitle = new System.Windows.Forms.TextBox();
      this.LblTitle = new System.Windows.Forms.Label();
      this.TxtEmployeeNumber = new System.Windows.Forms.TextBox();
      this.LblEmployeeId = new System.Windows.Forms.Label();
      this.LblSsn = new System.Windows.Forms.Label();
      this.LblGender = new System.Windows.Forms.Label();
      this.CmbSex = new System.Windows.Forms.ComboBox();
      this.LblSalutation = new System.Windows.Forms.Label();
      this.TxtFirstName = new System.Windows.Forms.TextBox();
      this.LblStatus = new System.Windows.Forms.Label();
      this.CmbState = new System.Windows.Forms.ComboBox();
      this.LblFirstName = new System.Windows.Forms.Label();
      this.TxtLastname = new System.Windows.Forms.TextBox();
      this.LblBirthDate = new System.Windows.Forms.Label();
      this.LblLastname = new System.Windows.Forms.Label();
      this.DateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
      this.CmbSalutation = new System.Windows.Forms.ComboBox();
      this.GrpAddress = new System.Windows.Forms.GroupBox();
      this.LblCity = new System.Windows.Forms.Label();
      this.TxtCity = new System.Windows.Forms.TextBox();
      this.TxtZipCode = new System.Windows.Forms.TextBox();
      this.LblPostalCode = new System.Windows.Forms.Label();
      this.TxtStreetNumber = new System.Windows.Forms.TextBox();
      this.LblStreetNumber = new System.Windows.Forms.Label();
      this.TxtStreetName = new System.Windows.Forms.TextBox();
      this.LblStreet = new System.Windows.Forms.Label();
      this.CmdClose = new System.Windows.Forms.Button();
      this.GrpEmploymentData = new System.Windows.Forms.GroupBox();
      this.LblExitDate = new System.Windows.Forms.Label();
      this.DatePickerExitDate = new System.Windows.Forms.DateTimePicker();
      this.LblEntryDate = new System.Windows.Forms.Label();
      this.NumCadreLevel = new System.Windows.Forms.NumericUpDown();
      this.DatePickerEntranceDate = new System.Windows.Forms.DateTimePicker();
      this.LblCadreLevel = new System.Windows.Forms.Label();
      this.NumEmployment = new System.Windows.Forms.NumericUpDown();
      this.LblEmployment = new System.Windows.Forms.Label();
      this.TxtRole = new System.Windows.Forms.TextBox();
      this.LblRole = new System.Windows.Forms.Label();
      this.TxtDeparment = new System.Windows.Forms.TextBox();
      this.LblDepartment = new System.Windows.Forms.Label();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.GrpContactData = new System.Windows.Forms.GroupBox();
      this.TxtPhoneNumberMobile = new System.Windows.Forms.TextBox();
      this.LblPhoneNumberMobile = new System.Windows.Forms.Label();
      this.TxtFaxNumber = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.TxtPhoneNumberBusiness = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.TxtPhoneNumberPrivate = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.TxtEMailAddress = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.GrpPersonalData.SuspendLayout();
      this.GrpAddress.SuspendLayout();
      this.GrpEmploymentData.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.NumCadreLevel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.NumEmployment)).BeginInit();
      this.GrpContactData.SuspendLayout();
      this.SuspendLayout();
      // 
      // CmdSave
      // 
      this.CmdSave.Location = new System.Drawing.Point(963, 570);
      this.CmdSave.Name = "CmdSave";
      this.CmdSave.Size = new System.Drawing.Size(75, 23);
      this.CmdSave.TabIndex = 24;
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
      this.GrpPersonalData.Controls.Add(this.TxtNationality);
      this.GrpPersonalData.Controls.Add(this.LblNationality);
      this.GrpPersonalData.Controls.Add(this.MTxtAHV13);
      this.GrpPersonalData.Controls.Add(this.TxtTitle);
      this.GrpPersonalData.Controls.Add(this.LblTitle);
      this.GrpPersonalData.Controls.Add(this.TxtEmployeeNumber);
      this.GrpPersonalData.Controls.Add(this.LblEmployeeId);
      this.GrpPersonalData.Controls.Add(this.LblSsn);
      this.GrpPersonalData.Controls.Add(this.LblGender);
      this.GrpPersonalData.Controls.Add(this.CmbSex);
      this.GrpPersonalData.Controls.Add(this.LblSalutation);
      this.GrpPersonalData.Controls.Add(this.TxtFirstName);
      this.GrpPersonalData.Controls.Add(this.LblStatus);
      this.GrpPersonalData.Controls.Add(this.CmbState);
      this.GrpPersonalData.Controls.Add(this.LblFirstName);
      this.GrpPersonalData.Controls.Add(this.TxtLastname);
      this.GrpPersonalData.Controls.Add(this.LblBirthDate);
      this.GrpPersonalData.Controls.Add(this.LblLastname);
      this.GrpPersonalData.Controls.Add(this.DateTimePickerDateOfBirth);
      this.GrpPersonalData.Controls.Add(this.CmbSalutation);
      this.GrpPersonalData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.GrpPersonalData.Location = new System.Drawing.Point(12, 78);
      this.GrpPersonalData.Name = "GrpPersonalData";
      this.GrpPersonalData.Size = new System.Drawing.Size(687, 192);
      this.GrpPersonalData.TabIndex = 16;
      this.GrpPersonalData.TabStop = false;
      this.GrpPersonalData.Text = "Person";
      // 
      // TxtNationality
      // 
      this.TxtNationality.Location = new System.Drawing.Point(492, 132);
      this.TxtNationality.Name = "TxtNationality";
      this.TxtNationality.Size = new System.Drawing.Size(183, 23);
      this.TxtNationality.TabIndex = 9;
      // 
      // LblNationality
      // 
      this.LblNationality.AutoSize = true;
      this.LblNationality.Location = new System.Drawing.Point(406, 137);
      this.LblNationality.Name = "LblNationality";
      this.LblNationality.Size = new System.Drawing.Size(69, 15);
      this.LblNationality.TabIndex = 25;
      this.LblNationality.Text = "Nationalität";
      // 
      // MTxtAHV13
      // 
      this.MTxtAHV13.Location = new System.Drawing.Point(492, 74);
      this.MTxtAHV13.Mask = "000.0000.0000.00";
      this.MTxtAHV13.Name = "MTxtAHV13";
      this.MTxtAHV13.Size = new System.Drawing.Size(183, 23);
      this.MTxtAHV13.TabIndex = 7;
      // 
      // TxtTitle
      // 
      this.TxtTitle.Location = new System.Drawing.Point(161, 132);
      this.TxtTitle.Name = "TxtTitle";
      this.TxtTitle.Size = new System.Drawing.Size(183, 23);
      this.TxtTitle.TabIndex = 4;
      // 
      // LblTitle
      // 
      this.LblTitle.AutoSize = true;
      this.LblTitle.Location = new System.Drawing.Point(6, 135);
      this.LblTitle.Name = "LblTitle";
      this.LblTitle.Size = new System.Drawing.Size(29, 15);
      this.LblTitle.TabIndex = 22;
      this.LblTitle.Text = "Titel";
      // 
      // TxtEmployeeNumber
      // 
      this.TxtEmployeeNumber.Location = new System.Drawing.Point(161, 16);
      this.TxtEmployeeNumber.Name = "TxtEmployeeNumber";
      this.TxtEmployeeNumber.ReadOnly = true;
      this.TxtEmployeeNumber.Size = new System.Drawing.Size(183, 23);
      this.TxtEmployeeNumber.TabIndex = 0;
      this.TxtEmployeeNumber.TabStop = false;
      this.TxtEmployeeNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
      // LblSsn
      // 
      this.LblSsn.AutoSize = true;
      this.LblSsn.Location = new System.Drawing.Point(406, 77);
      this.LblSsn.Name = "LblSsn";
      this.LblSsn.Size = new System.Drawing.Size(52, 15);
      this.LblSsn.TabIndex = 17;
      this.LblSsn.Text = "AHV-Nr.";
      // 
      // LblGender
      // 
      this.LblGender.AutoSize = true;
      this.LblGender.Location = new System.Drawing.Point(403, 48);
      this.LblGender.Name = "LblGender";
      this.LblGender.Size = new System.Drawing.Size(65, 15);
      this.LblGender.TabIndex = 15;
      this.LblGender.Text = "Geschlecht";
      // 
      // CmbSex
      // 
      this.CmbSex.FormattingEnabled = true;
      this.CmbSex.Location = new System.Drawing.Point(492, 45);
      this.CmbSex.Name = "CmbSex";
      this.CmbSex.Size = new System.Drawing.Size(183, 23);
      this.CmbSex.TabIndex = 6;
      // 
      // LblSalutation
      // 
      this.LblSalutation.AutoSize = true;
      this.LblSalutation.Location = new System.Drawing.Point(6, 48);
      this.LblSalutation.Name = "LblSalutation";
      this.LblSalutation.Size = new System.Drawing.Size(45, 15);
      this.LblSalutation.TabIndex = 9;
      this.LblSalutation.Text = "Anrede";
      // 
      // TxtFirstName
      // 
      this.TxtFirstName.Location = new System.Drawing.Point(161, 74);
      this.TxtFirstName.Name = "TxtFirstName";
      this.TxtFirstName.Size = new System.Drawing.Size(183, 23);
      this.TxtFirstName.TabIndex = 2;
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
      // CmbState
      // 
      this.CmbState.FormattingEnabled = true;
      this.CmbState.Location = new System.Drawing.Point(492, 16);
      this.CmbState.Name = "CmbState";
      this.CmbState.Size = new System.Drawing.Size(183, 23);
      this.CmbState.TabIndex = 5;
      // 
      // LblFirstName
      // 
      this.LblFirstName.AutoSize = true;
      this.LblFirstName.Location = new System.Drawing.Point(6, 77);
      this.LblFirstName.Name = "LblFirstName";
      this.LblFirstName.Size = new System.Drawing.Size(54, 15);
      this.LblFirstName.TabIndex = 2;
      this.LblFirstName.Text = "Vorname";
      // 
      // TxtLastname
      // 
      this.TxtLastname.Location = new System.Drawing.Point(161, 103);
      this.TxtLastname.Name = "TxtLastname";
      this.TxtLastname.Size = new System.Drawing.Size(183, 23);
      this.TxtLastname.TabIndex = 3;
      // 
      // LblBirthDate
      // 
      this.LblBirthDate.AutoSize = true;
      this.LblBirthDate.Location = new System.Drawing.Point(403, 109);
      this.LblBirthDate.Name = "LblBirthDate";
      this.LblBirthDate.Size = new System.Drawing.Size(83, 15);
      this.LblBirthDate.TabIndex = 11;
      this.LblBirthDate.Text = "Geburtsdatum";
      // 
      // LblLastname
      // 
      this.LblLastname.AutoSize = true;
      this.LblLastname.Location = new System.Drawing.Point(6, 106);
      this.LblLastname.Name = "LblLastname";
      this.LblLastname.Size = new System.Drawing.Size(65, 15);
      this.LblLastname.TabIndex = 5;
      this.LblLastname.Text = "Nachname";
      // 
      // DateTimePickerDateOfBirth
      // 
      this.DateTimePickerDateOfBirth.CustomFormat = " ";
      this.DateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.DateTimePickerDateOfBirth.Location = new System.Drawing.Point(492, 103);
      this.DateTimePickerDateOfBirth.Name = "DateTimePickerDateOfBirth";
      this.DateTimePickerDateOfBirth.Size = new System.Drawing.Size(183, 23);
      this.DateTimePickerDateOfBirth.TabIndex = 8;
      // 
      // CmbSalutation
      // 
      this.CmbSalutation.FormattingEnabled = true;
      this.CmbSalutation.Location = new System.Drawing.Point(161, 45);
      this.CmbSalutation.Name = "CmbSalutation";
      this.CmbSalutation.Size = new System.Drawing.Size(183, 23);
      this.CmbSalutation.TabIndex = 1;
      // 
      // GrpAddress
      // 
      this.GrpAddress.Controls.Add(this.LblCity);
      this.GrpAddress.Controls.Add(this.TxtCity);
      this.GrpAddress.Controls.Add(this.TxtZipCode);
      this.GrpAddress.Controls.Add(this.LblPostalCode);
      this.GrpAddress.Controls.Add(this.TxtStreetNumber);
      this.GrpAddress.Controls.Add(this.LblStreetNumber);
      this.GrpAddress.Controls.Add(this.TxtStreetName);
      this.GrpAddress.Controls.Add(this.LblStreet);
      this.GrpAddress.Location = new System.Drawing.Point(12, 276);
      this.GrpAddress.Name = "GrpAddress";
      this.GrpAddress.Size = new System.Drawing.Size(687, 87);
      this.GrpAddress.TabIndex = 17;
      this.GrpAddress.TabStop = false;
      this.GrpAddress.Text = "Adresse";
      // 
      // LblCity
      // 
      this.LblCity.AutoSize = true;
      this.LblCity.Location = new System.Drawing.Point(406, 45);
      this.LblCity.Name = "LblCity";
      this.LblCity.Size = new System.Drawing.Size(56, 15);
      this.LblCity.TabIndex = 28;
      this.LblCity.Text = "Ortschaft";
      // 
      // TxtCity
      // 
      this.TxtCity.Location = new System.Drawing.Point(492, 45);
      this.TxtCity.Name = "TxtCity";
      this.TxtCity.Size = new System.Drawing.Size(183, 23);
      this.TxtCity.TabIndex = 13;
      // 
      // TxtZipCode
      // 
      this.TxtZipCode.Location = new System.Drawing.Point(161, 45);
      this.TxtZipCode.Name = "TxtZipCode";
      this.TxtZipCode.Size = new System.Drawing.Size(183, 23);
      this.TxtZipCode.TabIndex = 12;
      this.TxtZipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
      this.TxtStreetNumber.Location = new System.Drawing.Point(492, 16);
      this.TxtStreetNumber.Name = "TxtStreetNumber";
      this.TxtStreetNumber.Size = new System.Drawing.Size(183, 23);
      this.TxtStreetNumber.TabIndex = 11;
      // 
      // LblStreetNumber
      // 
      this.LblStreetNumber.AutoSize = true;
      this.LblStreetNumber.Location = new System.Drawing.Point(406, 19);
      this.LblStreetNumber.Name = "LblStreetNumber";
      this.LblStreetNumber.Size = new System.Drawing.Size(23, 15);
      this.LblStreetNumber.TabIndex = 23;
      this.LblStreetNumber.Text = "Nr.";
      // 
      // TxtStreetName
      // 
      this.TxtStreetName.Location = new System.Drawing.Point(161, 16);
      this.TxtStreetName.Name = "TxtStreetName";
      this.TxtStreetName.Size = new System.Drawing.Size(183, 23);
      this.TxtStreetName.TabIndex = 10;
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
      // CmdClose
      // 
      this.CmdClose.Location = new System.Drawing.Point(1044, 570);
      this.CmdClose.Name = "CmdClose";
      this.CmdClose.Size = new System.Drawing.Size(75, 23);
      this.CmdClose.TabIndex = 25;
      this.CmdClose.Text = "Schliessen";
      this.CmdClose.UseVisualStyleBackColor = true;
      // 
      // GrpEmploymentData
      // 
      this.GrpEmploymentData.Controls.Add(this.LblExitDate);
      this.GrpEmploymentData.Controls.Add(this.DatePickerExitDate);
      this.GrpEmploymentData.Controls.Add(this.LblEntryDate);
      this.GrpEmploymentData.Controls.Add(this.NumCadreLevel);
      this.GrpEmploymentData.Controls.Add(this.DatePickerEntranceDate);
      this.GrpEmploymentData.Controls.Add(this.LblCadreLevel);
      this.GrpEmploymentData.Controls.Add(this.NumEmployment);
      this.GrpEmploymentData.Controls.Add(this.LblEmployment);
      this.GrpEmploymentData.Controls.Add(this.TxtRole);
      this.GrpEmploymentData.Controls.Add(this.LblRole);
      this.GrpEmploymentData.Controls.Add(this.TxtDeparment);
      this.GrpEmploymentData.Controls.Add(this.LblDepartment);
      this.GrpEmploymentData.Location = new System.Drawing.Point(738, 78);
      this.GrpEmploymentData.Name = "GrpEmploymentData";
      this.GrpEmploymentData.Size = new System.Drawing.Size(360, 192);
      this.GrpEmploymentData.TabIndex = 20;
      this.GrpEmploymentData.TabStop = false;
      this.GrpEmploymentData.Text = "Anstellung";
      // 
      // LblExitDate
      // 
      this.LblExitDate.AutoSize = true;
      this.LblExitDate.Location = new System.Drawing.Point(16, 162);
      this.LblExitDate.Name = "LblExitDate";
      this.LblExitDate.Size = new System.Drawing.Size(86, 15);
      this.LblExitDate.TabIndex = 31;
      this.LblExitDate.Text = "Austrittsdatum";
      // 
      // DatePickerExitDate
      // 
      this.DatePickerExitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.DatePickerExitDate.Location = new System.Drawing.Point(151, 156);
      this.DatePickerExitDate.MinDate = new System.DateTime(2022, 8, 21, 0, 0, 0, 0);
      this.DatePickerExitDate.Name = "DatePickerExitDate";
      this.DatePickerExitDate.Size = new System.Drawing.Size(183, 23);
      this.DatePickerExitDate.TabIndex = 23;
      // 
      // LblEntryDate
      // 
      this.LblEntryDate.AutoSize = true;
      this.LblEntryDate.Location = new System.Drawing.Point(16, 135);
      this.LblEntryDate.Name = "LblEntryDate";
      this.LblEntryDate.Size = new System.Drawing.Size(82, 15);
      this.LblEntryDate.TabIndex = 22;
      this.LblEntryDate.Text = "Eintrittsdatum";
      // 
      // NumCadreLevel
      // 
      this.NumCadreLevel.Location = new System.Drawing.Point(151, 98);
      this.NumCadreLevel.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
      this.NumCadreLevel.Name = "NumCadreLevel";
      this.NumCadreLevel.Size = new System.Drawing.Size(183, 23);
      this.NumCadreLevel.TabIndex = 21;
      // 
      // DatePickerEntranceDate
      // 
      this.DatePickerEntranceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.DatePickerEntranceDate.Location = new System.Drawing.Point(151, 127);
      this.DatePickerEntranceDate.MinDate = new System.DateTime(2022, 8, 21, 0, 0, 0, 0);
      this.DatePickerEntranceDate.Name = "DatePickerEntranceDate";
      this.DatePickerEntranceDate.Size = new System.Drawing.Size(183, 23);
      this.DatePickerEntranceDate.TabIndex = 22;
      this.DatePickerEntranceDate.Value = new System.DateTime(2022, 8, 21, 11, 47, 15, 0);
      // 
      // LblCadreLevel
      // 
      this.LblCadreLevel.AutoSize = true;
      this.LblCadreLevel.Location = new System.Drawing.Point(16, 106);
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
      this.NumEmployment.Location = new System.Drawing.Point(151, 69);
      this.NumEmployment.Name = "NumEmployment";
      this.NumEmployment.Size = new System.Drawing.Size(183, 23);
      this.NumEmployment.TabIndex = 20;
      this.NumEmployment.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      // 
      // LblEmployment
      // 
      this.LblEmployment.AutoSize = true;
      this.LblEmployment.Location = new System.Drawing.Point(16, 71);
      this.LblEmployment.Name = "LblEmployment";
      this.LblEmployment.Size = new System.Drawing.Size(112, 15);
      this.LblEmployment.TabIndex = 26;
      this.LblEmployment.Text = "Beschäftigungsgrad";
      // 
      // TxtRole
      // 
      this.TxtRole.Location = new System.Drawing.Point(151, 11);
      this.TxtRole.Name = "TxtRole";
      this.TxtRole.Size = new System.Drawing.Size(183, 23);
      this.TxtRole.TabIndex = 18;
      // 
      // LblRole
      // 
      this.LblRole.AutoSize = true;
      this.LblRole.Location = new System.Drawing.Point(16, 19);
      this.LblRole.Name = "LblRole";
      this.LblRole.Size = new System.Drawing.Size(33, 15);
      this.LblRole.TabIndex = 24;
      this.LblRole.Text = "Rolle";
      // 
      // TxtDeparment
      // 
      this.TxtDeparment.Location = new System.Drawing.Point(151, 40);
      this.TxtDeparment.Name = "TxtDeparment";
      this.TxtDeparment.Size = new System.Drawing.Size(183, 23);
      this.TxtDeparment.TabIndex = 19;
      // 
      // LblDepartment
      // 
      this.LblDepartment.AutoSize = true;
      this.LblDepartment.Location = new System.Drawing.Point(16, 43);
      this.LblDepartment.Name = "LblDepartment";
      this.LblDepartment.Size = new System.Drawing.Size(59, 15);
      this.LblDepartment.TabIndex = 11;
      this.LblDepartment.Text = "Abteilung";
      // 
      // GrpContactData
      // 
      this.GrpContactData.Controls.Add(this.TxtPhoneNumberMobile);
      this.GrpContactData.Controls.Add(this.LblPhoneNumberMobile);
      this.GrpContactData.Controls.Add(this.TxtFaxNumber);
      this.GrpContactData.Controls.Add(this.label1);
      this.GrpContactData.Controls.Add(this.TxtPhoneNumberBusiness);
      this.GrpContactData.Controls.Add(this.label2);
      this.GrpContactData.Controls.Add(this.TxtPhoneNumberPrivate);
      this.GrpContactData.Controls.Add(this.label3);
      this.GrpContactData.Controls.Add(this.TxtEMailAddress);
      this.GrpContactData.Controls.Add(this.label4);
      this.GrpContactData.Location = new System.Drawing.Point(738, 282);
      this.GrpContactData.Name = "GrpContactData";
      this.GrpContactData.Size = new System.Drawing.Size(359, 171);
      this.GrpContactData.TabIndex = 29;
      this.GrpContactData.TabStop = false;
      this.GrpContactData.Text = "Kontaktangaben";
      // 
      // TxtPhoneNumberMobile
      // 
      this.TxtPhoneNumberMobile.Location = new System.Drawing.Point(162, 74);
      this.TxtPhoneNumberMobile.Name = "TxtPhoneNumberMobile";
      this.TxtPhoneNumberMobile.Size = new System.Drawing.Size(183, 23);
      this.TxtPhoneNumberMobile.TabIndex = 33;
      // 
      // LblPhoneNumberMobile
      // 
      this.LblPhoneNumberMobile.AutoSize = true;
      this.LblPhoneNumberMobile.Location = new System.Drawing.Point(9, 78);
      this.LblPhoneNumberMobile.Name = "LblPhoneNumberMobile";
      this.LblPhoneNumberMobile.Size = new System.Drawing.Size(57, 15);
      this.LblPhoneNumberMobile.TabIndex = 34;
      this.LblPhoneNumberMobile.Text = "Tel. Privat";
      // 
      // TxtFaxNumber
      // 
      this.TxtFaxNumber.Location = new System.Drawing.Point(162, 130);
      this.TxtFaxNumber.Name = "TxtFaxNumber";
      this.TxtFaxNumber.Size = new System.Drawing.Size(183, 23);
      this.TxtFaxNumber.TabIndex = 21;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 135);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(74, 15);
      this.label1.TabIndex = 32;
      this.label1.Text = "Fax Geschäft";
      // 
      // TxtPhoneNumberBusiness
      // 
      this.TxtPhoneNumberBusiness.Location = new System.Drawing.Point(162, 101);
      this.TxtPhoneNumberBusiness.Name = "TxtPhoneNumberBusiness";
      this.TxtPhoneNumberBusiness.Size = new System.Drawing.Size(183, 23);
      this.TxtPhoneNumberBusiness.TabIndex = 20;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(9, 106);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(73, 15);
      this.label2.TabIndex = 30;
      this.label2.Text = "Tel. Geschäft";
      // 
      // TxtPhoneNumberPrivate
      // 
      this.TxtPhoneNumberPrivate.Location = new System.Drawing.Point(161, 45);
      this.TxtPhoneNumberPrivate.Name = "TxtPhoneNumberPrivate";
      this.TxtPhoneNumberPrivate.Size = new System.Drawing.Size(183, 23);
      this.TxtPhoneNumberPrivate.TabIndex = 19;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(8, 50);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(57, 15);
      this.label3.TabIndex = 28;
      this.label3.Text = "Tel. Privat";
      // 
      // TxtEMailAddress
      // 
      this.TxtEMailAddress.Location = new System.Drawing.Point(161, 16);
      this.TxtEMailAddress.Name = "TxtEMailAddress";
      this.TxtEMailAddress.Size = new System.Drawing.Size(183, 23);
      this.TxtEMailAddress.TabIndex = 18;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(8, 21);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(41, 15);
      this.label4.TabIndex = 26;
      this.label4.Text = "E-Mail";
      // 
      // EmployeeDetailDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.CmdClose;
      this.ClientSize = new System.Drawing.Size(792, 388);
      this.Controls.Add(this.GrpContactData);
      this.Controls.Add(this.GrpEmploymentData);
      this.Controls.Add(this.CmdClose);
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
      this.GrpEmploymentData.ResumeLayout(false);
      this.GrpEmploymentData.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.NumCadreLevel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.NumEmployment)).EndInit();
      this.GrpContactData.ResumeLayout(false);
      this.GrpContactData.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private Button CmdSave;
        private Label LblEmployee;
        private GroupBox GrpPersonalData;
        private TextBox TxtTitle;
        private Label LblTitle;
        private TextBox TxtEmployeeNumber;
        private Label LblEmployeeId;
        private Label LblSsn;
        private Label LblGender;
        private ComboBox CmbSex;
        private Label LblSalutation;
        private TextBox TxtFirstName;
        private Label LblStatus;
        private ComboBox CmbState;
        private Label LblFirstName;
        private TextBox TxtLastname;
        private Label LblBirthDate;
        private Label LblLastname;
        private DateTimePicker DateTimePickerDateOfBirth;
        private ComboBox CmbSalutation;
        private GroupBox GrpAddress;
        private Label LblCity;
        private TextBox TxtCity;
        private TextBox TxtZipCode;
        private Label LblPostalCode;
        private TextBox TxtStreetNumber;
        private Label LblStreetNumber;
        private TextBox TxtStreetName;
        private Label LblStreet;
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
        private DateTimePicker DatePickerExitDate;
        private Label LblEntryDate;
        private DateTimePicker DatePickerEntranceDate;
        private MaskedTextBox MTxtAHV13;
        private TextBox TxtNationality;
        private Label LblNationality;
        private GroupBox GrpContactData;
        private TextBox TxtPhoneNumberMobile;
        private Label LblPhoneNumberMobile;
        private TextBox TxtFaxNumber;
        private Label label1;
        private TextBox TxtPhoneNumberBusiness;
        private Label label2;
        private TextBox TxtPhoneNumberPrivate;
        private Label label3;
        private TextBox TxtEMailAddress;
        private Label label4;
    }
}
