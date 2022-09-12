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
      this.customerNoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.GrpCustomerData = new System.Windows.Forms.GroupBox();
      this.TxtCompanyAddress = new System.Windows.Forms.TextBox();
      this.LblCompanyAddress = new System.Windows.Forms.Label();
      this.TxtCompanyContact = new System.Windows.Forms.TextBox();
      this.CmbCustomerType = new System.Windows.Forms.ComboBox();
      this.LblCompanyContact = new System.Windows.Forms.Label();
      this.LblCustomerType = new System.Windows.Forms.Label();
      this.TxtCompanyName = new System.Windows.Forms.TextBox();
      this.LblCompanyName = new System.Windows.Forms.Label();
      this.GrpContactData = new System.Windows.Forms.GroupBox();
      this.TxtPhoneNumberMobile = new System.Windows.Forms.TextBox();
      this.LblPhoneNumberMobile = new System.Windows.Forms.Label();
      this.TxtFaxNumber = new System.Windows.Forms.TextBox();
      this.LblFaxBusiness = new System.Windows.Forms.Label();
      this.TxtPhoneNumberBusiness = new System.Windows.Forms.TextBox();
      this.LblPhoneBusiness = new System.Windows.Forms.Label();
      this.TxtPhoneNumberPrivate = new System.Windows.Forms.TextBox();
      this.LblPhonePrivate = new System.Windows.Forms.Label();
      this.TxtEMailAddress = new System.Windows.Forms.TextBox();
      this.LblMail = new System.Windows.Forms.Label();
      this.GrpAddress = new System.Windows.Forms.GroupBox();
      this.TxtZipCode = new System.Windows.Forms.TextBox();
      this.LblCity = new System.Windows.Forms.Label();
      this.TxtCity = new System.Windows.Forms.TextBox();
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
      this.CmdChangeStatus = new System.Windows.Forms.Button();
      this.CmdCancel = new System.Windows.Forms.Button();
      this.CmdSave = new System.Windows.Forms.Button();
      this.CmdProtocol = new System.Windows.Forms.Button();
      this.CmdShowCustomerNotes = new System.Windows.Forms.Button();
      this.CustomerErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.customerNoteBindingSource)).BeginInit();
      this.GrpCustomerData.SuspendLayout();
      this.GrpContactData.SuspendLayout();
      this.GrpAddress.SuspendLayout();
      this.GrpPersonalData.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.CustomerErrorProvider)).BeginInit();
      this.SuspendLayout();
      // 
      // customerNoteBindingSource
      // 
      this.customerNoteBindingSource.DataSource = typeof(contact_manager.Models.Data.CustomerNote);
      // 
      // GrpCustomerData
      // 
      this.GrpCustomerData.Controls.Add(this.TxtCompanyAddress);
      this.GrpCustomerData.Controls.Add(this.LblCompanyAddress);
      this.GrpCustomerData.Controls.Add(this.TxtCompanyContact);
      this.GrpCustomerData.Controls.Add(this.CmbCustomerType);
      this.GrpCustomerData.Controls.Add(this.LblCompanyContact);
      this.GrpCustomerData.Controls.Add(this.LblCustomerType);
      this.GrpCustomerData.Controls.Add(this.TxtCompanyName);
      this.GrpCustomerData.Controls.Add(this.LblCompanyName);
      this.GrpCustomerData.Location = new System.Drawing.Point(740, 56);
      this.GrpCustomerData.Name = "GrpCustomerData";
      this.GrpCustomerData.Size = new System.Drawing.Size(370, 137);
      this.GrpCustomerData.TabIndex = 16;
      this.GrpCustomerData.TabStop = false;
      this.GrpCustomerData.Text = "Kunde";
      // 
      // TxtCompanyAddress
      // 
      this.TxtCompanyAddress.Location = new System.Drawing.Point(151, 103);
      this.TxtCompanyAddress.Name = "TxtCompanyAddress";
      this.TxtCompanyAddress.Size = new System.Drawing.Size(183, 23);
      this.TxtCompanyAddress.TabIndex = 20;
      // 
      // LblCompanyAddress
      // 
      this.LblCompanyAddress.AutoSize = true;
      this.LblCompanyAddress.Location = new System.Drawing.Point(6, 106);
      this.LblCompanyAddress.Name = "LblCompanyAddress";
      this.LblCompanyAddress.Size = new System.Drawing.Size(97, 15);
      this.LblCompanyAddress.TabIndex = 30;
      this.LblCompanyAddress.Text = "Geschäftsadresse";
      // 
      // TxtCompanyContact
      // 
      this.TxtCompanyContact.Location = new System.Drawing.Point(151, 74);
      this.TxtCompanyContact.Name = "TxtCompanyContact";
      this.TxtCompanyContact.Size = new System.Drawing.Size(183, 23);
      this.TxtCompanyContact.TabIndex = 19;
      // 
      // CmbCustomerType
      // 
      this.CmbCustomerType.FormattingEnabled = true;
      this.CmbCustomerType.ItemHeight = 15;
      this.CmbCustomerType.Location = new System.Drawing.Point(151, 45);
      this.CmbCustomerType.Name = "CmbCustomerType";
      this.CmbCustomerType.Size = new System.Drawing.Size(183, 23);
      this.CmbCustomerType.TabIndex = 18;
      // 
      // LblCompanyContact
      // 
      this.LblCompanyContact.AutoSize = true;
      this.LblCompanyContact.Location = new System.Drawing.Point(6, 77);
      this.LblCompanyContact.Name = "LblCompanyContact";
      this.LblCompanyContact.Size = new System.Drawing.Size(84, 15);
      this.LblCompanyContact.TabIndex = 28;
      this.LblCompanyContact.Text = "Firmenkontakt";
      // 
      // LblCustomerType
      // 
      this.LblCustomerType.AutoSize = true;
      this.LblCustomerType.Location = new System.Drawing.Point(6, 48);
      this.LblCustomerType.Name = "LblCustomerType";
      this.LblCustomerType.Size = new System.Drawing.Size(65, 15);
      this.LblCustomerType.TabIndex = 26;
      this.LblCustomerType.Text = "Kundentyp";
      // 
      // TxtCompanyName
      // 
      this.TxtCompanyName.Location = new System.Drawing.Point(151, 16);
      this.TxtCompanyName.Name = "TxtCompanyName";
      this.TxtCompanyName.Size = new System.Drawing.Size(183, 23);
      this.TxtCompanyName.TabIndex = 17;
      // 
      // LblCompanyName
      // 
      this.LblCompanyName.AutoSize = true;
      this.LblCompanyName.Location = new System.Drawing.Point(6, 19);
      this.LblCompanyName.Name = "LblCompanyName";
      this.LblCompanyName.Size = new System.Drawing.Size(74, 15);
      this.LblCompanyName.TabIndex = 24;
      this.LblCompanyName.Text = "Firmenname";
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
      this.GrpContactData.Location = new System.Drawing.Point(740, 199);
      this.GrpContactData.Name = "GrpContactData";
      this.GrpContactData.Size = new System.Drawing.Size(370, 163);
      this.GrpContactData.TabIndex = 21;
      this.GrpContactData.TabStop = false;
      this.GrpContactData.Text = "Kontaktangaben";
      // 
      // TxtPhoneNumberMobile
      // 
      this.TxtPhoneNumberMobile.Location = new System.Drawing.Point(151, 74);
      this.TxtPhoneNumberMobile.Name = "TxtPhoneNumberMobile";
      this.TxtPhoneNumberMobile.PlaceholderText = "+41 xx xxx xx xx";
      this.TxtPhoneNumberMobile.Size = new System.Drawing.Size(183, 23);
      this.TxtPhoneNumberMobile.TabIndex = 24;
      this.TxtPhoneNumberMobile.TextChanged += new System.EventHandler(this.TxtPhoneNumberMobile_TextChanged);
      // 
      // LblPhoneNumberMobile
      // 
      this.LblPhoneNumberMobile.AutoSize = true;
      this.LblPhoneNumberMobile.Location = new System.Drawing.Point(6, 77);
      this.LblPhoneNumberMobile.Name = "LblPhoneNumberMobile";
      this.LblPhoneNumberMobile.Size = new System.Drawing.Size(65, 15);
      this.LblPhoneNumberMobile.TabIndex = 34;
      this.LblPhoneNumberMobile.Text = "Mobile-Nr.";
      // 
      // TxtFaxNumber
      // 
      this.TxtFaxNumber.Location = new System.Drawing.Point(151, 132);
      this.TxtFaxNumber.Name = "TxtFaxNumber";
      this.TxtFaxNumber.PlaceholderText = "+41 xx xxx xx xx";
      this.TxtFaxNumber.Size = new System.Drawing.Size(183, 23);
      this.TxtFaxNumber.TabIndex = 26;
      this.TxtFaxNumber.TextChanged += new System.EventHandler(this.TxtFaxNumber_TextChanged);
      // 
      // LblFaxBusiness
      // 
      this.LblFaxBusiness.AutoSize = true;
      this.LblFaxBusiness.Location = new System.Drawing.Point(6, 135);
      this.LblFaxBusiness.Name = "LblFaxBusiness";
      this.LblFaxBusiness.Size = new System.Drawing.Size(74, 15);
      this.LblFaxBusiness.TabIndex = 32;
      this.LblFaxBusiness.Text = "Fax Geschäft";
      // 
      // TxtPhoneNumberBusiness
      // 
      this.TxtPhoneNumberBusiness.Location = new System.Drawing.Point(151, 103);
      this.TxtPhoneNumberBusiness.Name = "TxtPhoneNumberBusiness";
      this.TxtPhoneNumberBusiness.PlaceholderText = "+41 xx xxx xx xx";
      this.TxtPhoneNumberBusiness.Size = new System.Drawing.Size(183, 23);
      this.TxtPhoneNumberBusiness.TabIndex = 25;
      this.TxtPhoneNumberBusiness.TextChanged += new System.EventHandler(this.TxtPhoneNumberBusiness_TextChanged);
      // 
      // LblPhoneBusiness
      // 
      this.LblPhoneBusiness.AutoSize = true;
      this.LblPhoneBusiness.Location = new System.Drawing.Point(6, 106);
      this.LblPhoneBusiness.Name = "LblPhoneBusiness";
      this.LblPhoneBusiness.Size = new System.Drawing.Size(73, 15);
      this.LblPhoneBusiness.TabIndex = 30;
      this.LblPhoneBusiness.Text = "Tel. Geschäft";
      // 
      // TxtPhoneNumberPrivate
      // 
      this.TxtPhoneNumberPrivate.Location = new System.Drawing.Point(151, 45);
      this.TxtPhoneNumberPrivate.Name = "TxtPhoneNumberPrivate";
      this.TxtPhoneNumberPrivate.PlaceholderText = "+41 xx xxx xx xx";
      this.TxtPhoneNumberPrivate.Size = new System.Drawing.Size(183, 23);
      this.TxtPhoneNumberPrivate.TabIndex = 23;
      this.TxtPhoneNumberPrivate.TextChanged += new System.EventHandler(this.TxtPhoneNumberPrivate_TextChanged);
      // 
      // LblPhonePrivate
      // 
      this.LblPhonePrivate.AutoSize = true;
      this.LblPhonePrivate.Location = new System.Drawing.Point(6, 48);
      this.LblPhonePrivate.Name = "LblPhonePrivate";
      this.LblPhonePrivate.Size = new System.Drawing.Size(57, 15);
      this.LblPhonePrivate.TabIndex = 28;
      this.LblPhonePrivate.Text = "Tel. Privat";
      // 
      // TxtEMailAddress
      // 
      this.TxtEMailAddress.Location = new System.Drawing.Point(151, 16);
      this.TxtEMailAddress.Name = "TxtEMailAddress";
      this.TxtEMailAddress.Size = new System.Drawing.Size(183, 23);
      this.TxtEMailAddress.TabIndex = 22;
      this.TxtEMailAddress.TextChanged += new System.EventHandler(this.TxtEMailAddress_TextChanged);
      // 
      // LblMail
      // 
      this.LblMail.AutoSize = true;
      this.LblMail.Location = new System.Drawing.Point(6, 19);
      this.LblMail.Name = "LblMail";
      this.LblMail.Size = new System.Drawing.Size(41, 15);
      this.LblMail.TabIndex = 26;
      this.LblMail.Text = "E-Mail";
      // 
      // GrpAddress
      // 
      this.GrpAddress.Controls.Add(this.TxtZipCode);
      this.GrpAddress.Controls.Add(this.LblCity);
      this.GrpAddress.Controls.Add(this.TxtCity);
      this.GrpAddress.Controls.Add(this.LblPostalCode);
      this.GrpAddress.Controls.Add(this.TxtStreetNumber);
      this.GrpAddress.Controls.Add(this.LblStreetNumber);
      this.GrpAddress.Controls.Add(this.TxtStreetName);
      this.GrpAddress.Controls.Add(this.LblStreet);
      this.GrpAddress.Location = new System.Drawing.Point(12, 226);
      this.GrpAddress.Name = "GrpAddress";
      this.GrpAddress.Size = new System.Drawing.Size(708, 97);
      this.GrpAddress.TabIndex = 11;
      this.GrpAddress.TabStop = false;
      this.GrpAddress.Text = "Adresse";
      // 
      // TxtZipCode
      // 
      this.TxtZipCode.Location = new System.Drawing.Point(161, 45);
      this.TxtZipCode.Name = "TxtZipCode";
      this.TxtZipCode.Size = new System.Drawing.Size(183, 23);
      this.TxtZipCode.TabIndex = 14;
      this.TxtZipCode.TextChanged += new System.EventHandler(this.TxtZipCode_TextChanged);
      this.TxtZipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtZipCode_KeyPress);
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
      this.TxtCity.TabIndex = 15;
      this.TxtCity.TextChanged += new System.EventHandler(this.TxtCity_TextChanged);
      // 
      // LblPostalCode
      // 
      this.LblPostalCode.AutoSize = true;
      this.LblPostalCode.Location = new System.Drawing.Point(6, 50);
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
      this.TxtStreetNumber.TabIndex = 13;
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
      this.TxtStreetName.TabIndex = 12;
      this.TxtStreetName.TextChanged += new System.EventHandler(this.TxtStreetName_TextChanged);
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
      this.GrpPersonalData.Location = new System.Drawing.Point(14, 56);
      this.GrpPersonalData.Name = "GrpPersonalData";
      this.GrpPersonalData.Size = new System.Drawing.Size(706, 166);
      this.GrpPersonalData.TabIndex = 0;
      this.GrpPersonalData.TabStop = false;
      this.GrpPersonalData.Text = "Person";
      // 
      // TxtNationality
      // 
      this.TxtNationality.Location = new System.Drawing.Point(492, 132);
      this.TxtNationality.Name = "TxtNationality";
      this.TxtNationality.Size = new System.Drawing.Size(183, 23);
      this.TxtNationality.TabIndex = 10;
      // 
      // LblNationality
      // 
      this.LblNationality.AutoSize = true;
      this.LblNationality.Location = new System.Drawing.Point(404, 135);
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
      this.MTxtAHV13.TabIndex = 8;
      this.MTxtAHV13.TextChanged += new System.EventHandler(this.MTxtAHV13_TextChanged);
      // 
      // TxtTitle
      // 
      this.TxtTitle.Location = new System.Drawing.Point(161, 132);
      this.TxtTitle.Name = "TxtTitle";
      this.TxtTitle.Size = new System.Drawing.Size(183, 23);
      this.TxtTitle.TabIndex = 5;
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
      // TxtCustomerNumber
      // 
      this.TxtCustomerNumber.Location = new System.Drawing.Point(161, 16);
      this.TxtCustomerNumber.Name = "TxtCustomerNumber";
      this.TxtCustomerNumber.ReadOnly = true;
      this.TxtCustomerNumber.Size = new System.Drawing.Size(183, 23);
      this.TxtCustomerNumber.TabIndex = 1;
      this.TxtCustomerNumber.TabStop = false;
      this.TxtCustomerNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // LblCustomerId
      // 
      this.LblCustomerId.AutoSize = true;
      this.LblCustomerId.Location = new System.Drawing.Point(6, 19);
      this.LblCustomerId.Name = "LblCustomerId";
      this.LblCustomerId.Size = new System.Drawing.Size(66, 15);
      this.LblCustomerId.TabIndex = 19;
      this.LblCustomerId.Text = "Kunden-Nr";
      // 
      // LblSsn
      // 
      this.LblSsn.AutoSize = true;
      this.LblSsn.Location = new System.Drawing.Point(404, 82);
      this.LblSsn.Name = "LblSsn";
      this.LblSsn.Size = new System.Drawing.Size(52, 15);
      this.LblSsn.TabIndex = 17;
      this.LblSsn.Text = "AHV-Nr.";
      // 
      // LblGender
      // 
      this.LblGender.AutoSize = true;
      this.LblGender.Location = new System.Drawing.Point(404, 48);
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
      this.CmbSex.TabIndex = 7;
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
      this.TxtFirstName.TabIndex = 3;
      this.TxtFirstName.TextChanged += new System.EventHandler(this.TxtFirstName_TextChanged);
      // 
      // LblStatus
      // 
      this.LblStatus.AutoSize = true;
      this.LblStatus.Location = new System.Drawing.Point(404, 19);
      this.LblStatus.Name = "LblStatus";
      this.LblStatus.Size = new System.Drawing.Size(39, 15);
      this.LblStatus.TabIndex = 13;
      this.LblStatus.Text = "Status";
      // 
      // CmbState
      // 
      this.CmbState.Enabled = false;
      this.CmbState.FormattingEnabled = true;
      this.CmbState.Location = new System.Drawing.Point(492, 16);
      this.CmbState.Name = "CmbState";
      this.CmbState.Size = new System.Drawing.Size(183, 23);
      this.CmbState.TabIndex = 6;
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
      this.TxtLastname.TabIndex = 4;
      this.TxtLastname.TextChanged += new System.EventHandler(this.TxtLastname_TextChanged);
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
      this.DateTimePickerDateOfBirth.TabIndex = 9;
      this.DateTimePickerDateOfBirth.ValueChanged += new System.EventHandler(this.DateTimePickerDateOfBirth_ValueChanged);
      this.DateTimePickerDateOfBirth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DatePickerDateOfBirth_KeyDown);
      // 
      // CmbSalutation
      // 
      this.CmbSalutation.FormattingEnabled = true;
      this.CmbSalutation.Location = new System.Drawing.Point(161, 45);
      this.CmbSalutation.Name = "CmbSalutation";
      this.CmbSalutation.Size = new System.Drawing.Size(183, 23);
      this.CmbSalutation.TabIndex = 2;
      // 
      // CmdChangeStatus
      // 
      this.CmdChangeStatus.Image = global::contact_manager.Properties.Resources.EditLabel;
      this.CmdChangeStatus.Location = new System.Drawing.Point(224, 12);
      this.CmdChangeStatus.Name = "CmdChangeStatus";
      this.CmdChangeStatus.Size = new System.Drawing.Size(100, 30);
      this.CmdChangeStatus.TabIndex = 34;
      this.CmdChangeStatus.TabStop = false;
      this.CmdChangeStatus.Text = "Aktivieren";
      this.CmdChangeStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.CmdChangeStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.CmdChangeStatus.UseVisualStyleBackColor = true;
      this.CmdChangeStatus.Click += new System.EventHandler(this.CmdChangeStatus_Click);
      // 
      // CmdCancel
      // 
      this.CmdCancel.Image = global::contact_manager.Properties.Resources.Cancel;
      this.CmdCancel.Location = new System.Drawing.Point(118, 12);
      this.CmdCancel.Name = "CmdCancel";
      this.CmdCancel.Size = new System.Drawing.Size(100, 30);
      this.CmdCancel.TabIndex = 33;
      this.CmdCancel.TabStop = false;
      this.CmdCancel.Text = "Abbrechen";
      this.CmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.CmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.CmdCancel.UseVisualStyleBackColor = true;
      this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
      // 
      // CmdSave
      // 
      this.CmdSave.Image = global::contact_manager.Properties.Resources.Save;
      this.CmdSave.Location = new System.Drawing.Point(12, 12);
      this.CmdSave.Name = "CmdSave";
      this.CmdSave.Size = new System.Drawing.Size(100, 30);
      this.CmdSave.TabIndex = 32;
      this.CmdSave.TabStop = false;
      this.CmdSave.Text = "Speichern";
      this.CmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.CmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.CmdSave.UseVisualStyleBackColor = true;
      this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
      // 
      // CmdProtocol
      // 
      this.CmdProtocol.Image = global::contact_manager.Properties.Resources.History;
      this.CmdProtocol.Location = new System.Drawing.Point(436, 12);
      this.CmdProtocol.Name = "CmdProtocol";
      this.CmdProtocol.Size = new System.Drawing.Size(100, 30);
      this.CmdProtocol.TabIndex = 35;
      this.CmdProtocol.TabStop = false;
      this.CmdProtocol.Text = "Protokoll";
      this.CmdProtocol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.CmdProtocol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.CmdProtocol.UseVisualStyleBackColor = true;
      this.CmdProtocol.Click += new System.EventHandler(this.CmdProtocol_Click);
      // 
      // CmdShowCustomerNotes
      // 
      this.CmdShowCustomerNotes.Image = global::contact_manager.Properties.Resources.Note;
      this.CmdShowCustomerNotes.Location = new System.Drawing.Point(330, 12);
      this.CmdShowCustomerNotes.Name = "CmdShowCustomerNotes";
      this.CmdShowCustomerNotes.Size = new System.Drawing.Size(100, 30);
      this.CmdShowCustomerNotes.TabIndex = 36;
      this.CmdShowCustomerNotes.TabStop = false;
      this.CmdShowCustomerNotes.Text = "Notizen";
      this.CmdShowCustomerNotes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.CmdShowCustomerNotes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.CmdShowCustomerNotes.UseVisualStyleBackColor = true;
      this.CmdShowCustomerNotes.Click += new System.EventHandler(this.CmdShowCustomerNotes_Click);
      // 
      // CustomerErrorProvider
      // 
      this.CustomerErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.CustomerErrorProvider.ContainerControl = this;
      // 
      // CustomerDetailDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
      this.ClientSize = new System.Drawing.Size(1106, 388);
      this.Controls.Add(this.CmdShowCustomerNotes);
      this.Controls.Add(this.CmdProtocol);
      this.Controls.Add(this.CmdChangeStatus);
      this.Controls.Add(this.CmdCancel);
      this.Controls.Add(this.CmdSave);
      this.Controls.Add(this.GrpCustomerData);
      this.Controls.Add(this.GrpContactData);
      this.Controls.Add(this.GrpAddress);
      this.Controls.Add(this.GrpPersonalData);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "CustomerDetailDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Kunde";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerDetailDialog_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.customerNoteBindingSource)).EndInit();
      this.GrpCustomerData.ResumeLayout(false);
      this.GrpCustomerData.PerformLayout();
      this.GrpContactData.ResumeLayout(false);
      this.GrpContactData.PerformLayout();
      this.GrpAddress.ResumeLayout(false);
      this.GrpAddress.PerformLayout();
      this.GrpPersonalData.ResumeLayout(false);
      this.GrpPersonalData.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.CustomerErrorProvider)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion
    private DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn creationTimeDataGridViewTextBoxColumn;
    private BindingSource customerNoteBindingSource;
        private GroupBox GrpCustomerData;
        private TextBox TxtCompanyContact;
        private ComboBox CmbCustomerType;
        private Label LblCompanyContact;
        private Label LblCustomerType;
        private TextBox TxtCompanyName;
        private Label LblCompanyName;
        private GroupBox GrpContactData;
        private Label LblFaxBusiness;
        private Label LblPhoneBusiness;
        private Label LblPhonePrivate;
        private Label LblMail;
        private GroupBox GrpAddress;
        private Label LblCity;
        private Label LblPostalCode;
        private TextBox TxtStreetNumber;
        private Label LblStreetNumber;
        private Label LblStreet;
        private GroupBox GrpPersonalData;
        private TextBox TxtNationality;
        private Label LblNationality;
        private TextBox TxtTitle;
        private Label LblTitle;
        private TextBox TxtCustomerNumber;
        private Label LblCustomerId;
        private Label LblSsn;
        private Label LblGender;
        private ComboBox CmbSex;
        private Label LblSalutation;
        private Label LblStatus;
        private ComboBox CmbState;
        private Label LblFirstName;
        private Label LblBirthDate;
        private Label LblLastname;
        private Label LblPhoneNumberMobile;
        private Button CmdChangeStatus;
        private Button CmdCancel;
        private Button CmdSave;
        private Button CmdProtocol;
        private Button CmdShowCustomerNotes;
        private TextBox TxtCompanyAddress;
        private Label LblCompanyAddress;
        private ErrorProvider CustomerErrorProvider;
        internal ComboBox CmbSalutation;
        internal TextBox TxtFaxNumber;
        internal TextBox TxtPhoneNumberBusiness;
        internal TextBox TxtPhoneNumberPrivate;
        internal TextBox TxtEMailAddress;
        internal TextBox TxtCity;
        internal TextBox TxtStreetName;
        internal MaskedTextBox MTxtAHV13;
        internal TextBox TxtFirstName;
        internal TextBox TxtLastname;
        internal DateTimePicker DateTimePickerDateOfBirth;
        internal TextBox TxtPhoneNumberMobile;
        internal TextBox TxtZipCode;
    }
}
