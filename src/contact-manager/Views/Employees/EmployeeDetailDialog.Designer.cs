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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(2339, 1558);
            this.CmdSave.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(182, 63);
            this.CmdSave.TabIndex = 24;
            this.CmdSave.Text = "Speichern";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // LblEmployee
            // 
            this.LblEmployee.AutoSize = true;
            this.LblEmployee.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblEmployee.Location = new System.Drawing.Point(29, 33);
            this.LblEmployee.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblEmployee.Name = "LblEmployee";
            this.LblEmployee.Size = new System.Drawing.Size(396, 89);
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
            this.GrpPersonalData.Location = new System.Drawing.Point(29, 213);
            this.GrpPersonalData.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.GrpPersonalData.Name = "GrpPersonalData";
            this.GrpPersonalData.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.GrpPersonalData.Size = new System.Drawing.Size(1668, 525);
            this.GrpPersonalData.TabIndex = 16;
            this.GrpPersonalData.TabStop = false;
            this.GrpPersonalData.Text = "Person";
            // 
            // TxtNationality
            // 
            this.TxtNationality.Location = new System.Drawing.Point(1195, 361);
            this.TxtNationality.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtNationality.Name = "TxtNationality";
            this.TxtNationality.Size = new System.Drawing.Size(439, 47);
            this.TxtNationality.TabIndex = 9;
            // 
            // LblNationality
            // 
            this.LblNationality.AutoSize = true;
            this.LblNationality.Location = new System.Drawing.Point(986, 374);
            this.LblNationality.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblNationality.Name = "LblNationality";
            this.LblNationality.Size = new System.Drawing.Size(171, 41);
            this.LblNationality.TabIndex = 25;
            this.LblNationality.Text = "Nationalität";
            // 
            // MTxtAHV13
            // 
            this.MTxtAHV13.Location = new System.Drawing.Point(1195, 202);
            this.MTxtAHV13.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MTxtAHV13.Mask = "000.0000.0000.00";
            this.MTxtAHV13.Name = "MTxtAHV13";
            this.MTxtAHV13.Size = new System.Drawing.Size(439, 47);
            this.MTxtAHV13.TabIndex = 7;
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(391, 361);
            this.TxtTitle.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(439, 47);
            this.TxtTitle.TabIndex = 4;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(15, 369);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(74, 41);
            this.LblTitle.TabIndex = 22;
            this.LblTitle.Text = "Titel";
            // 
            // TxtEmployeeNumber
            // 
            this.TxtEmployeeNumber.Location = new System.Drawing.Point(391, 44);
            this.TxtEmployeeNumber.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtEmployeeNumber.Name = "TxtEmployeeNumber";
            this.TxtEmployeeNumber.ReadOnly = true;
            this.TxtEmployeeNumber.Size = new System.Drawing.Size(439, 47);
            this.TxtEmployeeNumber.TabIndex = 0;
            this.TxtEmployeeNumber.TabStop = false;
            this.TxtEmployeeNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblEmployeeId
            // 
            this.LblEmployeeId.AutoSize = true;
            this.LblEmployeeId.Location = new System.Drawing.Point(15, 52);
            this.LblEmployeeId.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblEmployeeId.Name = "LblEmployeeId";
            this.LblEmployeeId.Size = new System.Drawing.Size(215, 41);
            this.LblEmployeeId.TabIndex = 19;
            this.LblEmployeeId.Text = "Mitarbeiter-Nr.";
            // 
            // LblSsn
            // 
            this.LblSsn.AutoSize = true;
            this.LblSsn.Location = new System.Drawing.Point(986, 210);
            this.LblSsn.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblSsn.Name = "LblSsn";
            this.LblSsn.Size = new System.Drawing.Size(128, 41);
            this.LblSsn.TabIndex = 17;
            this.LblSsn.Text = "AHV-Nr.";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Location = new System.Drawing.Point(979, 131);
            this.LblGender.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(163, 41);
            this.LblGender.TabIndex = 15;
            this.LblGender.Text = "Geschlecht";
            // 
            // CmbSex
            // 
            this.CmbSex.FormattingEnabled = true;
            this.CmbSex.Location = new System.Drawing.Point(1195, 123);
            this.CmbSex.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmbSex.Name = "CmbSex";
            this.CmbSex.Size = new System.Drawing.Size(439, 49);
            this.CmbSex.TabIndex = 6;
            // 
            // LblSalutation
            // 
            this.LblSalutation.AutoSize = true;
            this.LblSalutation.Location = new System.Drawing.Point(15, 131);
            this.LblSalutation.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblSalutation.Name = "LblSalutation";
            this.LblSalutation.Size = new System.Drawing.Size(114, 41);
            this.LblSalutation.TabIndex = 9;
            this.LblSalutation.Text = "Anrede";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(391, 202);
            this.TxtFirstName.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(439, 47);
            this.TxtFirstName.TabIndex = 2;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(986, 52);
            this.LblStatus.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(98, 41);
            this.LblStatus.TabIndex = 13;
            this.LblStatus.Text = "Status";
            // 
            // CmbState
            // 
            this.CmbState.FormattingEnabled = true;
            this.CmbState.Location = new System.Drawing.Point(1195, 44);
            this.CmbState.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmbState.Name = "CmbState";
            this.CmbState.Size = new System.Drawing.Size(439, 49);
            this.CmbState.TabIndex = 5;
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(15, 210);
            this.LblFirstName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(137, 41);
            this.LblFirstName.TabIndex = 2;
            this.LblFirstName.Text = "Vorname";
            // 
            // TxtLastname
            // 
            this.TxtLastname.Location = new System.Drawing.Point(391, 282);
            this.TxtLastname.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtLastname.Name = "TxtLastname";
            this.TxtLastname.Size = new System.Drawing.Size(439, 47);
            this.TxtLastname.TabIndex = 3;
            // 
            // LblBirthDate
            // 
            this.LblBirthDate.AutoSize = true;
            this.LblBirthDate.Location = new System.Drawing.Point(979, 298);
            this.LblBirthDate.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblBirthDate.Name = "LblBirthDate";
            this.LblBirthDate.Size = new System.Drawing.Size(209, 41);
            this.LblBirthDate.TabIndex = 11;
            this.LblBirthDate.Text = "Geburtsdatum";
            // 
            // LblLastname
            // 
            this.LblLastname.AutoSize = true;
            this.LblLastname.Location = new System.Drawing.Point(15, 290);
            this.LblLastname.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblLastname.Name = "LblLastname";
            this.LblLastname.Size = new System.Drawing.Size(160, 41);
            this.LblLastname.TabIndex = 5;
            this.LblLastname.Text = "Nachname";
            // 
            // DateTimePickerDateOfBirth
            // 
            this.DateTimePickerDateOfBirth.CustomFormat = " ";
            this.DateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerDateOfBirth.Location = new System.Drawing.Point(1195, 282);
            this.DateTimePickerDateOfBirth.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.DateTimePickerDateOfBirth.Name = "DateTimePickerDateOfBirth";
            this.DateTimePickerDateOfBirth.Size = new System.Drawing.Size(439, 47);
            this.DateTimePickerDateOfBirth.TabIndex = 8;
            // 
            // CmbSalutation
            // 
            this.CmbSalutation.FormattingEnabled = true;
            this.CmbSalutation.Location = new System.Drawing.Point(391, 123);
            this.CmbSalutation.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmbSalutation.Name = "CmbSalutation";
            this.CmbSalutation.Size = new System.Drawing.Size(439, 49);
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
            this.GrpAddress.Location = new System.Drawing.Point(29, 754);
            this.GrpAddress.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.GrpAddress.Name = "GrpAddress";
            this.GrpAddress.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.GrpAddress.Size = new System.Drawing.Size(1668, 238);
            this.GrpAddress.TabIndex = 17;
            this.GrpAddress.TabStop = false;
            this.GrpAddress.Text = "Adresse";
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(986, 123);
            this.LblCity.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(139, 41);
            this.LblCity.TabIndex = 28;
            this.LblCity.Text = "Ortschaft";
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(1195, 123);
            this.TxtCity.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(439, 47);
            this.TxtCity.TabIndex = 13;
            // 
            // TxtZipCode
            // 
            this.TxtZipCode.Location = new System.Drawing.Point(391, 123);
            this.TxtZipCode.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtZipCode.Name = "TxtZipCode";
            this.TxtZipCode.Size = new System.Drawing.Size(439, 47);
            this.TxtZipCode.TabIndex = 12;
            this.TxtZipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblPostalCode
            // 
            this.LblPostalCode.AutoSize = true;
            this.LblPostalCode.Location = new System.Drawing.Point(15, 123);
            this.LblPostalCode.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblPostalCode.Name = "LblPostalCode";
            this.LblPostalCode.Size = new System.Drawing.Size(168, 41);
            this.LblPostalCode.TabIndex = 26;
            this.LblPostalCode.Text = "Postleitzahl";
            // 
            // TxtStreetNumber
            // 
            this.TxtStreetNumber.Location = new System.Drawing.Point(1195, 44);
            this.TxtStreetNumber.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtStreetNumber.Name = "TxtStreetNumber";
            this.TxtStreetNumber.Size = new System.Drawing.Size(439, 47);
            this.TxtStreetNumber.TabIndex = 11;
            // 
            // LblStreetNumber
            // 
            this.LblStreetNumber.AutoSize = true;
            this.LblStreetNumber.Location = new System.Drawing.Point(986, 52);
            this.LblStreetNumber.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblStreetNumber.Name = "LblStreetNumber";
            this.LblStreetNumber.Size = new System.Drawing.Size(57, 41);
            this.LblStreetNumber.TabIndex = 23;
            this.LblStreetNumber.Text = "Nr.";
            // 
            // TxtStreetName
            // 
            this.TxtStreetName.Location = new System.Drawing.Point(391, 44);
            this.TxtStreetName.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtStreetName.Name = "TxtStreetName";
            this.TxtStreetName.Size = new System.Drawing.Size(439, 47);
            this.TxtStreetName.TabIndex = 10;
            // 
            // LblStreet
            // 
            this.LblStreet.AutoSize = true;
            this.LblStreet.Location = new System.Drawing.Point(15, 52);
            this.LblStreet.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblStreet.Name = "LblStreet";
            this.LblStreet.Size = new System.Drawing.Size(110, 41);
            this.LblStreet.TabIndex = 24;
            this.LblStreet.Text = "Strasse";
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(2535, 1558);
            this.CmdClose.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(182, 63);
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
            this.GrpEmploymentData.Location = new System.Drawing.Point(1792, 213);
            this.GrpEmploymentData.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.GrpEmploymentData.Name = "GrpEmploymentData";
            this.GrpEmploymentData.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.GrpEmploymentData.Size = new System.Drawing.Size(874, 525);
            this.GrpEmploymentData.TabIndex = 20;
            this.GrpEmploymentData.TabStop = false;
            this.GrpEmploymentData.Text = "Anstellung";
            // 
            // LblExitDate
            // 
            this.LblExitDate.AutoSize = true;
            this.LblExitDate.Location = new System.Drawing.Point(39, 443);
            this.LblExitDate.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblExitDate.Name = "LblExitDate";
            this.LblExitDate.Size = new System.Drawing.Size(213, 41);
            this.LblExitDate.TabIndex = 31;
            this.LblExitDate.Text = "Austrittsdatum";
            // 
            // DatePickerExitDate
            // 
            this.DatePickerExitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerExitDate.Location = new System.Drawing.Point(367, 426);
            this.DatePickerExitDate.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.DatePickerExitDate.MinDate = new System.DateTime(2022, 8, 21, 0, 0, 0, 0);
            this.DatePickerExitDate.Name = "DatePickerExitDate";
            this.DatePickerExitDate.Size = new System.Drawing.Size(439, 47);
            this.DatePickerExitDate.TabIndex = 23;
            // 
            // LblEntryDate
            // 
            this.LblEntryDate.AutoSize = true;
            this.LblEntryDate.Location = new System.Drawing.Point(39, 369);
            this.LblEntryDate.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblEntryDate.Name = "LblEntryDate";
            this.LblEntryDate.Size = new System.Drawing.Size(203, 41);
            this.LblEntryDate.TabIndex = 22;
            this.LblEntryDate.Text = "Eintrittsdatum";
            // 
            // NumCadreLevel
            // 
            this.NumCadreLevel.Location = new System.Drawing.Point(367, 268);
            this.NumCadreLevel.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.NumCadreLevel.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumCadreLevel.Name = "NumCadreLevel";
            this.NumCadreLevel.Size = new System.Drawing.Size(444, 47);
            this.NumCadreLevel.TabIndex = 21;
            // 
            // DatePickerEntranceDate
            // 
            this.DatePickerEntranceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerEntranceDate.Location = new System.Drawing.Point(367, 347);
            this.DatePickerEntranceDate.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.DatePickerEntranceDate.MinDate = new System.DateTime(2022, 8, 21, 0, 0, 0, 0);
            this.DatePickerEntranceDate.Name = "DatePickerEntranceDate";
            this.DatePickerEntranceDate.Size = new System.Drawing.Size(439, 47);
            this.DatePickerEntranceDate.TabIndex = 22;
            this.DatePickerEntranceDate.Value = new System.DateTime(2022, 8, 21, 11, 47, 15, 0);
            // 
            // LblCadreLevel
            // 
            this.LblCadreLevel.AutoSize = true;
            this.LblCadreLevel.Location = new System.Drawing.Point(39, 290);
            this.LblCadreLevel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblCadreLevel.Name = "LblCadreLevel";
            this.LblCadreLevel.Size = new System.Drawing.Size(159, 41);
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
            this.NumEmployment.Location = new System.Drawing.Point(367, 189);
            this.NumEmployment.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.NumEmployment.Name = "NumEmployment";
            this.NumEmployment.Size = new System.Drawing.Size(444, 47);
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
            this.LblEmployment.Location = new System.Drawing.Point(39, 194);
            this.LblEmployment.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblEmployment.Name = "LblEmployment";
            this.LblEmployment.Size = new System.Drawing.Size(280, 41);
            this.LblEmployment.TabIndex = 26;
            this.LblEmployment.Text = "Beschäftigungsgrad";
            // 
            // TxtRole
            // 
            this.TxtRole.Location = new System.Drawing.Point(367, 30);
            this.TxtRole.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtRole.Name = "TxtRole";
            this.TxtRole.Size = new System.Drawing.Size(439, 47);
            this.TxtRole.TabIndex = 18;
            // 
            // LblRole
            // 
            this.LblRole.AutoSize = true;
            this.LblRole.Location = new System.Drawing.Point(39, 52);
            this.LblRole.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblRole.Name = "LblRole";
            this.LblRole.Size = new System.Drawing.Size(83, 41);
            this.LblRole.TabIndex = 24;
            this.LblRole.Text = "Rolle";
            // 
            // TxtDeparment
            // 
            this.TxtDeparment.Location = new System.Drawing.Point(367, 109);
            this.TxtDeparment.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtDeparment.Name = "TxtDeparment";
            this.TxtDeparment.Size = new System.Drawing.Size(439, 47);
            this.TxtDeparment.TabIndex = 19;
            // 
            // LblDepartment
            // 
            this.LblDepartment.AutoSize = true;
            this.LblDepartment.Location = new System.Drawing.Point(39, 118);
            this.LblDepartment.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblDepartment.Name = "LblDepartment";
            this.LblDepartment.Size = new System.Drawing.Size(147, 41);
            this.LblDepartment.TabIndex = 11;
            this.LblDepartment.Text = "Abteilung";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtPhoneNumberMobile);
            this.groupBox1.Controls.Add(this.LblPhoneNumberMobile);
            this.groupBox1.Controls.Add(this.TxtFaxNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtPhoneNumberBusiness);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtPhoneNumberPrivate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtEMailAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(1792, 771);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupBox1.Size = new System.Drawing.Size(872, 467);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kontaktangaben";
            // 
            // TxtPhoneNumberMobile
            // 
            this.TxtPhoneNumberMobile.Location = new System.Drawing.Point(394, 201);
            this.TxtPhoneNumberMobile.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtPhoneNumberMobile.Name = "TxtPhoneNumberMobile";
            this.TxtPhoneNumberMobile.Size = new System.Drawing.Size(439, 47);
            this.TxtPhoneNumberMobile.TabIndex = 33;
            // 
            // LblPhoneNumberMobile
            // 
            this.LblPhoneNumberMobile.AutoSize = true;
            this.LblPhoneNumberMobile.Location = new System.Drawing.Point(22, 214);
            this.LblPhoneNumberMobile.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblPhoneNumberMobile.Name = "LblPhoneNumberMobile";
            this.LblPhoneNumberMobile.Size = new System.Drawing.Size(142, 41);
            this.LblPhoneNumberMobile.TabIndex = 34;
            this.LblPhoneNumberMobile.Text = "Tel. Privat";
            // 
            // TxtFaxNumber
            // 
            this.TxtFaxNumber.Location = new System.Drawing.Point(394, 356);
            this.TxtFaxNumber.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtFaxNumber.Name = "TxtFaxNumber";
            this.TxtFaxNumber.Size = new System.Drawing.Size(439, 47);
            this.TxtFaxNumber.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 369);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 41);
            this.label1.TabIndex = 32;
            this.label1.Text = "Fax Geschäft";
            // 
            // TxtPhoneNumberBusiness
            // 
            this.TxtPhoneNumberBusiness.Location = new System.Drawing.Point(394, 276);
            this.TxtPhoneNumberBusiness.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtPhoneNumberBusiness.Name = "TxtPhoneNumberBusiness";
            this.TxtPhoneNumberBusiness.Size = new System.Drawing.Size(439, 47);
            this.TxtPhoneNumberBusiness.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 289);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 41);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tel. Geschäft";
            // 
            // TxtPhoneNumberPrivate
            // 
            this.TxtPhoneNumberPrivate.Location = new System.Drawing.Point(391, 123);
            this.TxtPhoneNumberPrivate.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtPhoneNumberPrivate.Name = "TxtPhoneNumberPrivate";
            this.TxtPhoneNumberPrivate.Size = new System.Drawing.Size(439, 47);
            this.TxtPhoneNumberPrivate.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 41);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tel. Privat";
            // 
            // TxtEMailAddress
            // 
            this.TxtEMailAddress.Location = new System.Drawing.Point(391, 44);
            this.TxtEMailAddress.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtEMailAddress.Name = "TxtEMailAddress";
            this.TxtEMailAddress.Size = new System.Drawing.Size(439, 47);
            this.TxtEMailAddress.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 41);
            this.label4.TabIndex = 26;
            this.label4.Text = "E-Mail";
            // 
            // EmployeeDetailDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CmdClose;
            this.ClientSize = new System.Drawing.Size(2752, 1654);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrpEmploymentData);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.GrpAddress);
            this.Controls.Add(this.GrpPersonalData);
            this.Controls.Add(this.LblEmployee);
            this.Controls.Add(this.CmdSave);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
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
