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
            this.components = new System.ComponentModel.Container();
            this.LblCustomer = new System.Windows.Forms.Label();
            this.GbNotes = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GrpCustomerData = new System.Windows.Forms.GroupBox();
            this.TxtCompanyContact = new System.Windows.Forms.TextBox();
            this.CmbCustomerType = new System.Windows.Forms.ComboBox();
            this.LblCompanyContact = new System.Windows.Forms.Label();
            this.LblCustomerType = new System.Windows.Forms.Label();
            this.TxtRole = new System.Windows.Forms.TextBox();
            this.LblCompanyName = new System.Windows.Forms.Label();
            this.CmdClose = new System.Windows.Forms.Button();
            this.GrpContactData = new System.Windows.Forms.GroupBox();
            this.TxtFaxNumber = new System.Windows.Forms.TextBox();
            this.LblFaxBusiness = new System.Windows.Forms.Label();
            this.TxtPhoneNumberBusiness = new System.Windows.Forms.TextBox();
            this.LblPhoneBusiness = new System.Windows.Forms.Label();
            this.TxtPhoneNumberPrivate = new System.Windows.Forms.TextBox();
            this.LblPhonePrivate = new System.Windows.Forms.Label();
            this.TxtEMailAddress = new System.Windows.Forms.TextBox();
            this.LblMail = new System.Windows.Forms.Label();
            this.GrpAddress = new System.Windows.Forms.GroupBox();
            this.LblCity = new System.Windows.Forms.Label();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtZipCode = new System.Windows.Forms.TextBox();
            this.LblPostalCode = new System.Windows.Forms.Label();
            this.TxtStreetNumber = new System.Windows.Forms.TextBox();
            this.LblStreetNumber = new System.Windows.Forms.Label();
            this.TxtStreetName = new System.Windows.Forms.TextBox();
            this.LblStreet = new System.Windows.Forms.Label();
            this.GrpPersonalData = new System.Windows.Forms.GroupBox();
            this.TxtNationality = new System.Windows.Forms.TextBox();
            this.LblNationality = new System.Windows.Forms.Label();
            this.MTxtAHV13 = new System.Windows.Forms.MaskedTextBox();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtCustomerNumber = new System.Windows.Forms.TextBox();
            this.LblCustomerId = new System.Windows.Forms.Label();
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
            this.CmdSave = new System.Windows.Forms.Button();
            this.TxtPhoneNumberMobile = new System.Windows.Forms.TextBox();
            this.LblPhoneNumberMobile = new System.Windows.Forms.Label();
            this.GbNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNoteBindingSource)).BeginInit();
            this.GrpCustomerData.SuspendLayout();
            this.GrpContactData.SuspendLayout();
            this.GrpAddress.SuspendLayout();
            this.GrpPersonalData.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblCustomer
            // 
            this.LblCustomer.AutoSize = true;
            this.LblCustomer.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCustomer.Location = new System.Drawing.Point(29, 25);
            this.LblCustomer.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblCustomer.Name = "LblCustomer";
            this.LblCustomer.Size = new System.Drawing.Size(1177, 89);
            this.LblCustomer.TabIndex = 3;
            this.LblCustomer.Text = "Kunde (wird noch mit Infos ergänzt)";
            // 
            // GbNotes
            // 
            this.GbNotes.Controls.Add(this.dataGridView1);
            this.GbNotes.Location = new System.Drawing.Point(29, 948);
            this.GbNotes.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.GbNotes.Name = "GbNotes";
            this.GbNotes.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.GbNotes.Size = new System.Drawing.Size(1698, 552);
            this.GbNotes.TabIndex = 17;
            this.GbNotes.TabStop = false;
            this.GbNotes.Text = "Notizen";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.customerNoteBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(7, 48);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1684, 496);
            this.dataGridView1.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Text";
            this.dataGridViewTextBoxColumn1.HeaderText = "Text";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 500;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CreationTime";
            this.dataGridViewTextBoxColumn2.HeaderText = "Erstellungsdatum";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // customerNoteBindingSource
            // 
            this.customerNoteBindingSource.DataSource = typeof(contact_manager.Models.Data.Customer.CustomerNote);
            // 
            // GrpCustomerData
            // 
            this.GrpCustomerData.Controls.Add(this.TxtCompanyContact);
            this.GrpCustomerData.Controls.Add(this.CmbCustomerType);
            this.GrpCustomerData.Controls.Add(this.LblCompanyContact);
            this.GrpCustomerData.Controls.Add(this.LblCustomerType);
            this.GrpCustomerData.Controls.Add(this.TxtRole);
            this.GrpCustomerData.Controls.Add(this.LblCompanyName);
            this.GrpCustomerData.Location = new System.Drawing.Point(1797, 153);
            this.GrpCustomerData.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.GrpCustomerData.Name = "GrpCustomerData";
            this.GrpCustomerData.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.GrpCustomerData.Size = new System.Drawing.Size(874, 410);
            this.GrpCustomerData.TabIndex = 29;
            this.GrpCustomerData.TabStop = false;
            this.GrpCustomerData.Text = "Kunde";
            // 
            // TxtCompanyContact
            // 
            this.TxtCompanyContact.Location = new System.Drawing.Point(367, 203);
            this.TxtCompanyContact.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtCompanyContact.Name = "TxtCompanyContact";
            this.TxtCompanyContact.Size = new System.Drawing.Size(439, 47);
            this.TxtCompanyContact.TabIndex = 17;
            // 
            // CmbCustomerType
            // 
            this.CmbCustomerType.FormattingEnabled = true;
            this.CmbCustomerType.ItemHeight = 41;
            this.CmbCustomerType.Location = new System.Drawing.Point(367, 123);
            this.CmbCustomerType.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmbCustomerType.Name = "CmbCustomerType";
            this.CmbCustomerType.Size = new System.Drawing.Size(439, 49);
            this.CmbCustomerType.TabIndex = 16;
            // 
            // LblCompanyContact
            // 
            this.LblCompanyContact.AutoSize = true;
            this.LblCompanyContact.Location = new System.Drawing.Point(39, 211);
            this.LblCompanyContact.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblCompanyContact.Name = "LblCompanyContact";
            this.LblCompanyContact.Size = new System.Drawing.Size(220, 41);
            this.LblCompanyContact.TabIndex = 28;
            this.LblCompanyContact.Text = "Kundenkontakt";
            // 
            // LblCustomerType
            // 
            this.LblCustomerType.AutoSize = true;
            this.LblCustomerType.Location = new System.Drawing.Point(39, 131);
            this.LblCustomerType.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblCustomerType.Name = "LblCustomerType";
            this.LblCustomerType.Size = new System.Drawing.Size(163, 41);
            this.LblCustomerType.TabIndex = 26;
            this.LblCustomerType.Text = "Kundentyp";
            // 
            // TxtRole
            // 
            this.TxtRole.Location = new System.Drawing.Point(367, 44);
            this.TxtRole.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtRole.Name = "TxtRole";
            this.TxtRole.Size = new System.Drawing.Size(439, 47);
            this.TxtRole.TabIndex = 14;
            // 
            // LblCompanyName
            // 
            this.LblCompanyName.AutoSize = true;
            this.LblCompanyName.Location = new System.Drawing.Point(39, 52);
            this.LblCompanyName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblCompanyName.Name = "LblCompanyName";
            this.LblCompanyName.Size = new System.Drawing.Size(183, 41);
            this.LblCompanyName.TabIndex = 24;
            this.LblCompanyName.Text = "Firmenname";
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(2584, 1864);
            this.CmdClose.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(182, 63);
            this.CmdClose.TabIndex = 31;
            this.CmdClose.Text = "Schliessen";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // GrpContactData
            // 
            this.GrpContactData.Controls.Add(this.TxtPhoneNumberMobile);
            this.GrpContactData.Controls.Add(this.LblPhoneNumberMobile);
            this.GrpContactData.Controls.Add(this.TxtFaxNumber);
            this.GrpContactData.Controls.Add(this.LblFaxBusiness);
            this.GrpContactData.Controls.Add(this.TxtPhoneNumberBusiness);
            this.GrpContactData.Controls.Add(this.LblPhoneBusiness);
            this.GrpContactData.Controls.Add(this.TxtPhoneNumberPrivate);
            this.GrpContactData.Controls.Add(this.LblPhonePrivate);
            this.GrpContactData.Controls.Add(this.TxtEMailAddress);
            this.GrpContactData.Controls.Add(this.LblMail);
            this.GrpContactData.Location = new System.Drawing.Point(1797, 694);
            this.GrpContactData.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.GrpContactData.Name = "GrpContactData";
            this.GrpContactData.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.GrpContactData.Size = new System.Drawing.Size(872, 467);
            this.GrpContactData.TabIndex = 28;
            this.GrpContactData.TabStop = false;
            this.GrpContactData.Text = "Kontaktangaben";
            // 
            // TxtFaxNumber
            // 
            this.TxtFaxNumber.Location = new System.Drawing.Point(394, 356);
            this.TxtFaxNumber.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtFaxNumber.Name = "TxtFaxNumber";
            this.TxtFaxNumber.Size = new System.Drawing.Size(439, 47);
            this.TxtFaxNumber.TabIndex = 21;
            // 
            // LblFaxBusiness
            // 
            this.LblFaxBusiness.AutoSize = true;
            this.LblFaxBusiness.Location = new System.Drawing.Point(18, 364);
            this.LblFaxBusiness.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblFaxBusiness.Name = "LblFaxBusiness";
            this.LblFaxBusiness.Size = new System.Drawing.Size(184, 41);
            this.LblFaxBusiness.TabIndex = 32;
            this.LblFaxBusiness.Text = "Fax Geschäft";
            // 
            // TxtPhoneNumberBusiness
            // 
            this.TxtPhoneNumberBusiness.Location = new System.Drawing.Point(394, 276);
            this.TxtPhoneNumberBusiness.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtPhoneNumberBusiness.Name = "TxtPhoneNumberBusiness";
            this.TxtPhoneNumberBusiness.Size = new System.Drawing.Size(439, 47);
            this.TxtPhoneNumberBusiness.TabIndex = 20;
            // 
            // LblPhoneBusiness
            // 
            this.LblPhoneBusiness.AutoSize = true;
            this.LblPhoneBusiness.Location = new System.Drawing.Point(18, 284);
            this.LblPhoneBusiness.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblPhoneBusiness.Name = "LblPhoneBusiness";
            this.LblPhoneBusiness.Size = new System.Drawing.Size(184, 41);
            this.LblPhoneBusiness.TabIndex = 30;
            this.LblPhoneBusiness.Text = "Tel. Geschäft";
            // 
            // TxtPhoneNumberPrivate
            // 
            this.TxtPhoneNumberPrivate.Location = new System.Drawing.Point(391, 123);
            this.TxtPhoneNumberPrivate.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtPhoneNumberPrivate.Name = "TxtPhoneNumberPrivate";
            this.TxtPhoneNumberPrivate.Size = new System.Drawing.Size(439, 47);
            this.TxtPhoneNumberPrivate.TabIndex = 19;
            // 
            // LblPhonePrivate
            // 
            this.LblPhonePrivate.AutoSize = true;
            this.LblPhonePrivate.Location = new System.Drawing.Point(15, 131);
            this.LblPhonePrivate.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblPhonePrivate.Name = "LblPhonePrivate";
            this.LblPhonePrivate.Size = new System.Drawing.Size(142, 41);
            this.LblPhonePrivate.TabIndex = 28;
            this.LblPhonePrivate.Text = "Tel. Privat";
            // 
            // TxtEMailAddress
            // 
            this.TxtEMailAddress.Location = new System.Drawing.Point(391, 44);
            this.TxtEMailAddress.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtEMailAddress.Name = "TxtEMailAddress";
            this.TxtEMailAddress.Size = new System.Drawing.Size(439, 47);
            this.TxtEMailAddress.TabIndex = 18;
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.Location = new System.Drawing.Point(15, 52);
            this.LblMail.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(101, 41);
            this.LblMail.TabIndex = 26;
            this.LblMail.Text = "E-Mail";
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
            this.GrpAddress.Location = new System.Drawing.Point(34, 694);
            this.GrpAddress.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.GrpAddress.Name = "GrpAddress";
            this.GrpAddress.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.GrpAddress.Size = new System.Drawing.Size(1668, 238);
            this.GrpAddress.TabIndex = 27;
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
            // GrpPersonalData
            // 
            this.GrpPersonalData.Controls.Add(this.TxtNationality);
            this.GrpPersonalData.Controls.Add(this.LblNationality);
            this.GrpPersonalData.Controls.Add(this.MTxtAHV13);
            this.GrpPersonalData.Controls.Add(this.TxtTitle);
            this.GrpPersonalData.Controls.Add(this.LblTitle);
            this.GrpPersonalData.Controls.Add(this.TxtCustomerNumber);
            this.GrpPersonalData.Controls.Add(this.LblCustomerId);
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
            this.GrpPersonalData.Location = new System.Drawing.Point(34, 153);
            this.GrpPersonalData.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.GrpPersonalData.Name = "GrpPersonalData";
            this.GrpPersonalData.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.GrpPersonalData.Size = new System.Drawing.Size(1668, 525);
            this.GrpPersonalData.TabIndex = 26;
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
            // TxtCustomerNumber
            // 
            this.TxtCustomerNumber.Location = new System.Drawing.Point(391, 44);
            this.TxtCustomerNumber.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtCustomerNumber.Name = "TxtCustomerNumber";
            this.TxtCustomerNumber.ReadOnly = true;
            this.TxtCustomerNumber.Size = new System.Drawing.Size(439, 47);
            this.TxtCustomerNumber.TabIndex = 0;
            this.TxtCustomerNumber.TabStop = false;
            this.TxtCustomerNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblCustomerId
            // 
            this.LblCustomerId.AutoSize = true;
            this.LblCustomerId.Location = new System.Drawing.Point(15, 52);
            this.LblCustomerId.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblCustomerId.Name = "LblCustomerId";
            this.LblCustomerId.Size = new System.Drawing.Size(164, 41);
            this.LblCustomerId.TabIndex = 19;
            this.LblCustomerId.Text = "Kunden-Nr";
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
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(2387, 1864);
            this.CmdSave.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(182, 63);
            this.CmdSave.TabIndex = 30;
            this.CmdSave.Text = "Speichern";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
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
            this.LblPhoneNumberMobile.Location = new System.Drawing.Point(18, 209);
            this.LblPhoneNumberMobile.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblPhoneNumberMobile.Name = "LblPhoneNumberMobile";
            this.LblPhoneNumberMobile.Size = new System.Drawing.Size(142, 41);
            this.LblPhoneNumberMobile.TabIndex = 34;
            this.LblPhoneNumberMobile.Text = "Tel. Privat";
            // 
            // CustomerDetailDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2795, 1960);
            this.Controls.Add(this.GrpCustomerData);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.GbNotes);
            this.Controls.Add(this.GrpContactData);
            this.Controls.Add(this.GrpAddress);
            this.Controls.Add(this.LblCustomer);
            this.Controls.Add(this.GrpPersonalData);
            this.Controls.Add(this.CmdSave);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "CustomerDetailDialog";
            this.Text = "CustomerDetailDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerDetailDialog_FormClosing);
            this.GbNotes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNoteBindingSource)).EndInit();
            this.GrpCustomerData.ResumeLayout(false);
            this.GrpCustomerData.PerformLayout();
            this.GrpContactData.ResumeLayout(false);
            this.GrpContactData.PerformLayout();
            this.GrpAddress.ResumeLayout(false);
            this.GrpAddress.PerformLayout();
            this.GrpPersonalData.ResumeLayout(false);
            this.GrpPersonalData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    private Label LblCustomer;
    private GroupBox GbNotes;
    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn creationTimeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private BindingSource customerNoteBindingSource;
        private GroupBox GrpCustomerData;
        private TextBox TxtCompanyContact;
        private ComboBox CmbCustomerType;
        private Label LblCompanyContact;
        private Label LblCustomerType;
        private TextBox TxtRole;
        private Label LblCompanyName;
        private Button CmdClose;
        private GroupBox GrpContactData;
        private TextBox TxtFaxNumber;
        private Label LblFaxBusiness;
        private TextBox TxtPhoneNumberBusiness;
        private Label LblPhoneBusiness;
        private TextBox TxtPhoneNumberPrivate;
        private Label LblPhonePrivate;
        private TextBox TxtEMailAddress;
        private Label LblMail;
        private GroupBox GrpAddress;
        private Label LblCity;
        private TextBox TxtCity;
        private TextBox TxtZipCode;
        private Label LblPostalCode;
        private TextBox TxtStreetNumber;
        private Label LblStreetNumber;
        private TextBox TxtStreetName;
        private Label LblStreet;
        private GroupBox GrpPersonalData;
        private TextBox TxtNationality;
        private Label LblNationality;
        private MaskedTextBox MTxtAHV13;
        private TextBox TxtTitle;
        private Label LblTitle;
        private TextBox TxtCustomerNumber;
        private Label LblCustomerId;
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
        private Button CmdSave;
        private TextBox TxtPhoneNumberMobile;
        private Label LblPhoneNumberMobile;
    }
}
