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
            this.CmdChangeStatus = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdProtocol = new System.Windows.Forms.Button();
            this.CmdShowCustomerNotes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerNoteBindingSource)).BeginInit();
            this.GrpCustomerData.SuspendLayout();
            this.GrpContactData.SuspendLayout();
            this.GrpAddress.SuspendLayout();
            this.GrpPersonalData.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerNoteBindingSource
            // 
            this.customerNoteBindingSource.DataSource = typeof(contact_manager.Models.Data.Customer.CustomerNote);
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
            this.GrpCustomerData.Location = new System.Drawing.Point(1797, 153);
            this.GrpCustomerData.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.GrpCustomerData.Name = "GrpCustomerData";
            this.GrpCustomerData.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.GrpCustomerData.Size = new System.Drawing.Size(848, 374);
            this.GrpCustomerData.TabIndex = 16;
            this.GrpCustomerData.TabStop = false;
            this.GrpCustomerData.Text = "Kunde";
            // 
            // TxtCompanyAddress
            // 
            this.TxtCompanyAddress.Location = new System.Drawing.Point(367, 282);
            this.TxtCompanyAddress.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtCompanyAddress.Name = "TxtCompanyAddress";
            this.TxtCompanyAddress.Size = new System.Drawing.Size(439, 47);
            this.TxtCompanyAddress.TabIndex = 20;
            // 
            // LblCompanyAddress
            // 
            this.LblCompanyAddress.AutoSize = true;
            this.LblCompanyAddress.Location = new System.Drawing.Point(15, 290);
            this.LblCompanyAddress.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblCompanyAddress.Name = "LblCompanyAddress";
            this.LblCompanyAddress.Size = new System.Drawing.Size(247, 41);
            this.LblCompanyAddress.TabIndex = 30;
            this.LblCompanyAddress.Text = "Geschäftsadresse";
            // 
            // TxtCompanyContact
            // 
            this.TxtCompanyContact.Location = new System.Drawing.Point(367, 202);
            this.TxtCompanyContact.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtCompanyContact.Name = "TxtCompanyContact";
            this.TxtCompanyContact.Size = new System.Drawing.Size(439, 47);
            this.TxtCompanyContact.TabIndex = 19;
            // 
            // CmbCustomerType
            // 
            this.CmbCustomerType.FormattingEnabled = true;
            this.CmbCustomerType.ItemHeight = 41;
            this.CmbCustomerType.Location = new System.Drawing.Point(367, 123);
            this.CmbCustomerType.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmbCustomerType.Name = "CmbCustomerType";
            this.CmbCustomerType.Size = new System.Drawing.Size(439, 49);
            this.CmbCustomerType.TabIndex = 18;
            // 
            // LblCompanyContact
            // 
            this.LblCompanyContact.AutoSize = true;
            this.LblCompanyContact.Location = new System.Drawing.Point(15, 210);
            this.LblCompanyContact.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblCompanyContact.Name = "LblCompanyContact";
            this.LblCompanyContact.Size = new System.Drawing.Size(209, 41);
            this.LblCompanyContact.TabIndex = 28;
            this.LblCompanyContact.Text = "Firmenkontakt";
            // 
            // LblCustomerType
            // 
            this.LblCustomerType.AutoSize = true;
            this.LblCustomerType.Location = new System.Drawing.Point(15, 131);
            this.LblCustomerType.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblCustomerType.Name = "LblCustomerType";
            this.LblCustomerType.Size = new System.Drawing.Size(163, 41);
            this.LblCustomerType.TabIndex = 26;
            this.LblCustomerType.Text = "Kundentyp";
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.Location = new System.Drawing.Point(367, 44);
            this.TxtCompanyName.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.Size = new System.Drawing.Size(439, 47);
            this.TxtCompanyName.TabIndex = 17;
            // 
            // LblCompanyName
            // 
            this.LblCompanyName.AutoSize = true;
            this.LblCompanyName.Location = new System.Drawing.Point(15, 52);
            this.LblCompanyName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblCompanyName.Name = "LblCompanyName";
            this.LblCompanyName.Size = new System.Drawing.Size(183, 41);
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
            this.GrpContactData.Location = new System.Drawing.Point(1797, 544);
            this.GrpContactData.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.GrpContactData.Name = "GrpContactData";
            this.GrpContactData.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.GrpContactData.Size = new System.Drawing.Size(848, 446);
            this.GrpContactData.TabIndex = 21;
            this.GrpContactData.TabStop = false;
            this.GrpContactData.Text = "Kontaktangaben";
            // 
            // TxtPhoneNumberMobile
            // 
            this.TxtPhoneNumberMobile.Location = new System.Drawing.Point(367, 202);
            this.TxtPhoneNumberMobile.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtPhoneNumberMobile.Name = "TxtPhoneNumberMobile";
            this.TxtPhoneNumberMobile.Size = new System.Drawing.Size(439, 47);
            this.TxtPhoneNumberMobile.TabIndex = 24;
            // 
            // LblPhoneNumberMobile
            // 
            this.LblPhoneNumberMobile.AutoSize = true;
            this.LblPhoneNumberMobile.Location = new System.Drawing.Point(15, 210);
            this.LblPhoneNumberMobile.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblPhoneNumberMobile.Name = "LblPhoneNumberMobile";
            this.LblPhoneNumberMobile.Size = new System.Drawing.Size(162, 41);
            this.LblPhoneNumberMobile.TabIndex = 34;
            this.LblPhoneNumberMobile.Text = "Mobile-Nr.";
            // 
            // TxtFaxNumber
            // 
            this.TxtFaxNumber.Location = new System.Drawing.Point(367, 361);
            this.TxtFaxNumber.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtFaxNumber.Name = "TxtFaxNumber";
            this.TxtFaxNumber.Size = new System.Drawing.Size(439, 47);
            this.TxtFaxNumber.TabIndex = 26;
            // 
            // LblFaxBusiness
            // 
            this.LblFaxBusiness.AutoSize = true;
            this.LblFaxBusiness.Location = new System.Drawing.Point(15, 369);
            this.LblFaxBusiness.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblFaxBusiness.Name = "LblFaxBusiness";
            this.LblFaxBusiness.Size = new System.Drawing.Size(184, 41);
            this.LblFaxBusiness.TabIndex = 32;
            this.LblFaxBusiness.Text = "Fax Geschäft";
            // 
            // TxtPhoneNumberBusiness
            // 
            this.TxtPhoneNumberBusiness.Location = new System.Drawing.Point(367, 282);
            this.TxtPhoneNumberBusiness.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtPhoneNumberBusiness.Name = "TxtPhoneNumberBusiness";
            this.TxtPhoneNumberBusiness.Size = new System.Drawing.Size(439, 47);
            this.TxtPhoneNumberBusiness.TabIndex = 25;
            // 
            // LblPhoneBusiness
            // 
            this.LblPhoneBusiness.AutoSize = true;
            this.LblPhoneBusiness.Location = new System.Drawing.Point(15, 290);
            this.LblPhoneBusiness.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblPhoneBusiness.Name = "LblPhoneBusiness";
            this.LblPhoneBusiness.Size = new System.Drawing.Size(184, 41);
            this.LblPhoneBusiness.TabIndex = 30;
            this.LblPhoneBusiness.Text = "Tel. Geschäft";
            // 
            // TxtPhoneNumberPrivate
            // 
            this.TxtPhoneNumberPrivate.Location = new System.Drawing.Point(367, 123);
            this.TxtPhoneNumberPrivate.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtPhoneNumberPrivate.Name = "TxtPhoneNumberPrivate";
            this.TxtPhoneNumberPrivate.Size = new System.Drawing.Size(439, 47);
            this.TxtPhoneNumberPrivate.TabIndex = 23;
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
            this.TxtEMailAddress.Location = new System.Drawing.Point(367, 44);
            this.TxtEMailAddress.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtEMailAddress.Name = "TxtEMailAddress";
            this.TxtEMailAddress.Size = new System.Drawing.Size(439, 47);
            this.TxtEMailAddress.TabIndex = 22;
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
            this.GrpAddress.Location = new System.Drawing.Point(29, 618);
            this.GrpAddress.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.GrpAddress.Name = "GrpAddress";
            this.GrpAddress.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.GrpAddress.Size = new System.Drawing.Size(1673, 265);
            this.GrpAddress.TabIndex = 11;
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
            this.TxtCity.TabIndex = 15;
            // 
            // TxtZipCode
            // 
            this.TxtZipCode.Location = new System.Drawing.Point(391, 123);
            this.TxtZipCode.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtZipCode.Name = "TxtZipCode";
            this.TxtZipCode.Size = new System.Drawing.Size(439, 47);
            this.TxtZipCode.TabIndex = 14;
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
            this.TxtStreetNumber.TabIndex = 13;
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
            this.TxtStreetName.TabIndex = 12;
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
            this.GrpPersonalData.Size = new System.Drawing.Size(1668, 454);
            this.GrpPersonalData.TabIndex = 0;
            this.GrpPersonalData.TabStop = false;
            this.GrpPersonalData.Text = "Person";
            // 
            // TxtNationality
            // 
            this.TxtNationality.Location = new System.Drawing.Point(1195, 361);
            this.TxtNationality.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtNationality.Name = "TxtNationality";
            this.TxtNationality.Size = new System.Drawing.Size(439, 47);
            this.TxtNationality.TabIndex = 10;
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
            this.MTxtAHV13.TabIndex = 8;
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(391, 361);
            this.TxtTitle.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(439, 47);
            this.TxtTitle.TabIndex = 5;
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
            this.TxtCustomerNumber.TabIndex = 1;
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
            this.CmbSex.TabIndex = 7;
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
            this.TxtFirstName.TabIndex = 3;
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
            this.CmbState.Enabled = false;
            this.CmbState.FormattingEnabled = true;
            this.CmbState.Location = new System.Drawing.Point(1195, 44);
            this.CmbState.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmbState.Name = "CmbState";
            this.CmbState.Size = new System.Drawing.Size(439, 49);
            this.CmbState.TabIndex = 6;
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
            this.TxtLastname.TabIndex = 4;
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
            this.DateTimePickerDateOfBirth.TabIndex = 9;
            // 
            // CmbSalutation
            // 
            this.CmbSalutation.FormattingEnabled = true;
            this.CmbSalutation.Location = new System.Drawing.Point(391, 123);
            this.CmbSalutation.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmbSalutation.Name = "CmbSalutation";
            this.CmbSalutation.Size = new System.Drawing.Size(439, 49);
            this.CmbSalutation.TabIndex = 2;
            // 
            // CmdChangeStatus
            // 
            this.CmdChangeStatus.Image = global::contact_manager.Properties.Resources.EditLabel;
            this.CmdChangeStatus.Location = new System.Drawing.Point(544, 33);
            this.CmdChangeStatus.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmdChangeStatus.Name = "CmdChangeStatus";
            this.CmdChangeStatus.Size = new System.Drawing.Size(243, 82);
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
            this.CmdCancel.Location = new System.Drawing.Point(287, 33);
            this.CmdCancel.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(243, 82);
            this.CmdCancel.TabIndex = 33;
            this.CmdCancel.TabStop = false;
            this.CmdCancel.Text = "Abbrechen";
            this.CmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CmdCancel.UseVisualStyleBackColor = true;
            // 
            // CmdSave
            // 
            this.CmdSave.Image = global::contact_manager.Properties.Resources.Save;
            this.CmdSave.Location = new System.Drawing.Point(29, 33);
            this.CmdSave.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(243, 82);
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
            this.CmdProtocol.Location = new System.Drawing.Point(1059, 33);
            this.CmdProtocol.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmdProtocol.Name = "CmdProtocol";
            this.CmdProtocol.Size = new System.Drawing.Size(243, 82);
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
            this.CmdShowCustomerNotes.Location = new System.Drawing.Point(801, 33);
            this.CmdShowCustomerNotes.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmdShowCustomerNotes.Name = "CmdShowCustomerNotes";
            this.CmdShowCustomerNotes.Size = new System.Drawing.Size(243, 82);
            this.CmdShowCustomerNotes.TabIndex = 36;
            this.CmdShowCustomerNotes.TabStop = false;
            this.CmdShowCustomerNotes.Text = "Notizen";
            this.CmdShowCustomerNotes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdShowCustomerNotes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CmdShowCustomerNotes.UseVisualStyleBackColor = true;
            this.CmdShowCustomerNotes.Click += new System.EventHandler(this.CmdShowCustomerNotes_Click);
            // 
            // CustomerDetailDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2671, 1503);
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
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
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
        private TextBox TxtPhoneNumberMobile;
        private Label LblPhoneNumberMobile;
        private Button CmdChangeStatus;
        private Button CmdCancel;
        private Button CmdSave;
        private Button CmdProtocol;
        private Button CmdShowCustomerNotes;
        private TextBox TxtCompanyAddress;
        private Label LblCompanyAddress;
    }
}
