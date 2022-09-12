namespace contact_manager.Views
{
    partial class OverviewView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CmdCreateNewCustomer = new System.Windows.Forms.Button();
            this.TcPerson = new System.Windows.Forms.TabControl();
            this.TpCustomer = new System.Windows.Forms.TabPage();
            this.CmbSearchScopeCustomer = new System.Windows.Forms.ComboBox();
            this.CmdImportCustomer = new System.Windows.Forms.Button();
            this.CmdDeleteCustomer = new System.Windows.Forms.Button();
            this.CmdEditCustomer = new System.Windows.Forms.Button();
            this.PnlSearchCustomer = new System.Windows.Forms.Panel();
            this.CmdResetSearchCustomer = new System.Windows.Forms.Button();
            this.CmdSearchCustomer = new System.Windows.Forms.Button();
            this.TxtSearchCustomer = new System.Windows.Forms.TextBox();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.customerNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TpEmployee = new System.Windows.Forms.TabPage();
            this.CmbSearchScopeEmployee = new System.Windows.Forms.ComboBox();
            this.CmdImportEmployee = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CmdResetSearchEmployee = new System.Windows.Forms.Button();
            this.CmdSearchEmployee = new System.Windows.Forms.Button();
            this.TxtSearchEmployee = new System.Windows.Forms.TextBox();
            this.CmdDeleteEmployee = new System.Windows.Forms.Button();
            this.CmdEditEmployee = new System.Windows.Forms.Button();
            this.CmdCreateNewEmployee = new System.Windows.Forms.Button();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.employeeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CadreLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TcPerson.SuspendLayout();
            this.TpCustomer.SuspendLayout();
            this.PnlSearchCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.TpEmployee.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdCreateNewCustomer
            // 
            this.CmdCreateNewCustomer.Image = global::contact_manager.Properties.Resources.NewItem;
            this.CmdCreateNewCustomer.Location = new System.Drawing.Point(19, 16);
            this.CmdCreateNewCustomer.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmdCreateNewCustomer.Name = "CmdCreateNewCustomer";
            this.CmdCreateNewCustomer.Size = new System.Drawing.Size(243, 82);
            this.CmdCreateNewCustomer.TabIndex = 1;
            this.CmdCreateNewCustomer.Text = "Neu";
            this.CmdCreateNewCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdCreateNewCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CmdCreateNewCustomer.UseVisualStyleBackColor = true;
            this.CmdCreateNewCustomer.Click += new System.EventHandler(this.CmdCreateNewCustomer_Click);
            // 
            // TcPerson
            // 
            this.TcPerson.Controls.Add(this.TpCustomer);
            this.TcPerson.Controls.Add(this.TpEmployee);
            this.TcPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TcPerson.Location = new System.Drawing.Point(0, 0);
            this.TcPerson.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TcPerson.Multiline = true;
            this.TcPerson.Name = "TcPerson";
            this.TcPerson.SelectedIndex = 0;
            this.TcPerson.Size = new System.Drawing.Size(2744, 1484);
            this.TcPerson.TabIndex = 19;
            this.TcPerson.Selected += new System.Windows.Forms.TabControlEventHandler(this.TcPerson_Selected);
            // 
            // TpCustomer
            // 
            this.TpCustomer.Controls.Add(this.CmbSearchScopeCustomer);
            this.TpCustomer.Controls.Add(this.CmdImportCustomer);
            this.TpCustomer.Controls.Add(this.CmdDeleteCustomer);
            this.TpCustomer.Controls.Add(this.CmdEditCustomer);
            this.TpCustomer.Controls.Add(this.PnlSearchCustomer);
            this.TpCustomer.Controls.Add(this.dataGridViewCustomer);
            this.TpCustomer.Controls.Add(this.CmdCreateNewCustomer);
            this.TpCustomer.Location = new System.Drawing.Point(10, 58);
            this.TpCustomer.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TpCustomer.Name = "TpCustomer";
            this.TpCustomer.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TpCustomer.Size = new System.Drawing.Size(2724, 1416);
            this.TpCustomer.TabIndex = 0;
            this.TpCustomer.Text = "Kunden";
            this.TpCustomer.UseVisualStyleBackColor = true;
            // 
            // CmbSearchScopeCustomer
            // 
            this.CmbSearchScopeCustomer.FormattingEnabled = true;
            this.CmbSearchScopeCustomer.Location = new System.Drawing.Point(1597, 28);
            this.CmbSearchScopeCustomer.Name = "CmbSearchScopeCustomer";
            this.CmbSearchScopeCustomer.Size = new System.Drawing.Size(370, 49);
            this.CmbSearchScopeCustomer.TabIndex = 8;
            // 
            // CmdImportCustomer
            // 
            this.CmdImportCustomer.Image = global::contact_manager.Properties.Resources.Import;
            this.CmdImportCustomer.Location = new System.Drawing.Point(792, 16);
            this.CmdImportCustomer.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmdImportCustomer.Name = "CmdImportCustomer";
            this.CmdImportCustomer.Size = new System.Drawing.Size(243, 82);
            this.CmdImportCustomer.TabIndex = 7;
            this.CmdImportCustomer.Text = "Import";
            this.CmdImportCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdImportCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CmdImportCustomer.UseVisualStyleBackColor = true;
            this.CmdImportCustomer.Click += new System.EventHandler(this.CmdImportCustomer_Click);
            // 
            // CmdDeleteCustomer
            // 
            this.CmdDeleteCustomer.Image = global::contact_manager.Properties.Resources.Delete;
            this.CmdDeleteCustomer.Location = new System.Drawing.Point(534, 16);
            this.CmdDeleteCustomer.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmdDeleteCustomer.Name = "CmdDeleteCustomer";
            this.CmdDeleteCustomer.Size = new System.Drawing.Size(243, 82);
            this.CmdDeleteCustomer.TabIndex = 6;
            this.CmdDeleteCustomer.Text = "Löschen";
            this.CmdDeleteCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdDeleteCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CmdDeleteCustomer.UseVisualStyleBackColor = true;
            this.CmdDeleteCustomer.Click += new System.EventHandler(this.CmdDeleteCustomer_Click);
            // 
            // CmdEditCustomer
            // 
            this.CmdEditCustomer.Image = global::contact_manager.Properties.Resources.Edit;
            this.CmdEditCustomer.Location = new System.Drawing.Point(277, 16);
            this.CmdEditCustomer.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmdEditCustomer.Name = "CmdEditCustomer";
            this.CmdEditCustomer.Size = new System.Drawing.Size(243, 82);
            this.CmdEditCustomer.TabIndex = 5;
            this.CmdEditCustomer.Text = "Bearbeiten";
            this.CmdEditCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdEditCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CmdEditCustomer.UseVisualStyleBackColor = true;
            this.CmdEditCustomer.Click += new System.EventHandler(this.CmdEditCustomer_Click);
            // 
            // PnlSearchCustomer
            // 
            this.PnlSearchCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PnlSearchCustomer.Controls.Add(this.CmdResetSearchCustomer);
            this.PnlSearchCustomer.Controls.Add(this.CmdSearchCustomer);
            this.PnlSearchCustomer.Controls.Add(this.TxtSearchCustomer);
            this.PnlSearchCustomer.Location = new System.Drawing.Point(1970, 16);
            this.PnlSearchCustomer.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.PnlSearchCustomer.Name = "PnlSearchCustomer";
            this.PnlSearchCustomer.Size = new System.Drawing.Size(736, 82);
            this.PnlSearchCustomer.TabIndex = 4;
            // 
            // CmdResetSearchCustomer
            // 
            this.CmdResetSearchCustomer.Image = global::contact_manager.Properties.Resources.Cancel;
            this.CmdResetSearchCustomer.Location = new System.Drawing.Point(670, 14);
            this.CmdResetSearchCustomer.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.CmdResetSearchCustomer.Name = "CmdResetSearchCustomer";
            this.CmdResetSearchCustomer.Size = new System.Drawing.Size(61, 63);
            this.CmdResetSearchCustomer.TabIndex = 8;
            this.CmdResetSearchCustomer.UseVisualStyleBackColor = true;
            this.CmdResetSearchCustomer.Click += new System.EventHandler(this.CmdResetSearchCustomer_Click);
            // 
            // CmdSearchCustomer
            // 
            this.CmdSearchCustomer.Image = global::contact_manager.Properties.Resources.Search;
            this.CmdSearchCustomer.Location = new System.Drawing.Point(610, 14);
            this.CmdSearchCustomer.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.CmdSearchCustomer.Name = "CmdSearchCustomer";
            this.CmdSearchCustomer.Size = new System.Drawing.Size(61, 63);
            this.CmdSearchCustomer.TabIndex = 7;
            this.CmdSearchCustomer.UseVisualStyleBackColor = true;
            this.CmdSearchCustomer.Click += new System.EventHandler(this.CmdSearchCustomer_Click);
            // 
            // TxtSearchCustomer
            // 
            this.TxtSearchCustomer.Location = new System.Drawing.Point(7, 14);
            this.TxtSearchCustomer.Margin = new System.Windows.Forms.Padding(7, 8, 0, 8);
            this.TxtSearchCustomer.Name = "TxtSearchCustomer";
            this.TxtSearchCustomer.PlaceholderText = "Suchtext";
            this.TxtSearchCustomer.Size = new System.Drawing.Size(597, 47);
            this.TxtSearchCustomer.TabIndex = 2;
            this.TxtSearchCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearchCustomer_KeyDown);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AllowUserToAddRows = false;
            this.dataGridViewCustomer.AllowUserToDeleteRows = false;
            this.dataGridViewCustomer.AutoGenerateColumns = false;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNumberDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.customerTypeDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.streetNameDataGridViewTextBoxColumn,
            this.streetNumberDataGridViewTextBoxColumn,
            this.zipCodeDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dataGridViewCustomer.DataSource = this.customerBindingSource;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(19, 109);
            this.dataGridViewCustomer.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.ReadOnly = true;
            this.dataGridViewCustomer.RowHeadersWidth = 102;
            this.dataGridViewCustomer.RowTemplate.Height = 25;
            this.dataGridViewCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(2686, 1268);
            this.dataGridViewCustomer.TabIndex = 3;
            this.dataGridViewCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellDoubleClick);
            // 
            // customerNumberDataGridViewTextBoxColumn
            // 
            this.customerNumberDataGridViewTextBoxColumn.DataPropertyName = "CustomerNumber";
            this.customerNumberDataGridViewTextBoxColumn.HeaderText = "Kunden-Nr.";
            this.customerNumberDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.customerNumberDataGridViewTextBoxColumn.Name = "customerNumberDataGridViewTextBoxColumn";
            this.customerNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNumberDataGridViewTextBoxColumn.Width = 250;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Nachname";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "Status";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            this.stateDataGridViewTextBoxColumn.Width = 60;
            // 
            // customerTypeDataGridViewTextBoxColumn
            // 
            this.customerTypeDataGridViewTextBoxColumn.DataPropertyName = "CustomerType";
            this.customerTypeDataGridViewTextBoxColumn.HeaderText = "Kundentyp";
            this.customerTypeDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.customerTypeDataGridViewTextBoxColumn.Name = "customerTypeDataGridViewTextBoxColumn";
            this.customerTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerTypeDataGridViewTextBoxColumn.Width = 250;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dateOfBirthDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Geburtstag";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 250;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Geschlecht";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexDataGridViewTextBoxColumn.Width = 250;
            // 
            // streetNameDataGridViewTextBoxColumn
            // 
            this.streetNameDataGridViewTextBoxColumn.DataPropertyName = "StreetName";
            this.streetNameDataGridViewTextBoxColumn.HeaderText = "Strasse";
            this.streetNameDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.streetNameDataGridViewTextBoxColumn.Name = "streetNameDataGridViewTextBoxColumn";
            this.streetNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // streetNumberDataGridViewTextBoxColumn
            // 
            this.streetNumberDataGridViewTextBoxColumn.DataPropertyName = "StreetNumber";
            this.streetNumberDataGridViewTextBoxColumn.HeaderText = "Nr.";
            this.streetNumberDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.streetNumberDataGridViewTextBoxColumn.Name = "streetNumberDataGridViewTextBoxColumn";
            this.streetNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetNumberDataGridViewTextBoxColumn.Width = 40;
            // 
            // zipCodeDataGridViewTextBoxColumn
            // 
            this.zipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.HeaderText = "PLZ";
            this.zipCodeDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.zipCodeDataGridViewTextBoxColumn.Name = "zipCodeDataGridViewTextBoxColumn";
            this.zipCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.zipCodeDataGridViewTextBoxColumn.Width = 60;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "Ort";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn.Width = 120;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(contact_manager.Models.Data.Customer.Customer);
            // 
            // TpEmployee
            // 
            this.TpEmployee.Controls.Add(this.CmbSearchScopeEmployee);
            this.TpEmployee.Controls.Add(this.CmdImportEmployee);
            this.TpEmployee.Controls.Add(this.panel1);
            this.TpEmployee.Controls.Add(this.CmdDeleteEmployee);
            this.TpEmployee.Controls.Add(this.CmdEditEmployee);
            this.TpEmployee.Controls.Add(this.CmdCreateNewEmployee);
            this.TpEmployee.Controls.Add(this.dataGridViewEmployee);
            this.TpEmployee.Location = new System.Drawing.Point(10, 58);
            this.TpEmployee.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TpEmployee.Name = "TpEmployee";
            this.TpEmployee.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TpEmployee.Size = new System.Drawing.Size(2724, 1416);
            this.TpEmployee.TabIndex = 1;
            this.TpEmployee.Text = "Mitarbeiter";
            this.TpEmployee.UseVisualStyleBackColor = true;
            // 
            // CmbSearchScopeEmployee
            // 
            this.CmbSearchScopeEmployee.FormattingEnabled = true;
            this.CmbSearchScopeEmployee.Location = new System.Drawing.Point(1597, 30);
            this.CmbSearchScopeEmployee.Name = "CmbSearchScopeEmployee";
            this.CmbSearchScopeEmployee.Size = new System.Drawing.Size(370, 49);
            this.CmbSearchScopeEmployee.TabIndex = 12;
            // 
            // CmdImportEmployee
            // 
            this.CmdImportEmployee.Image = global::contact_manager.Properties.Resources.Import;
            this.CmdImportEmployee.Location = new System.Drawing.Point(792, 16);
            this.CmdImportEmployee.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmdImportEmployee.Name = "CmdImportEmployee";
            this.CmdImportEmployee.Size = new System.Drawing.Size(243, 82);
            this.CmdImportEmployee.TabIndex = 11;
            this.CmdImportEmployee.Text = "Import";
            this.CmdImportEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdImportEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CmdImportEmployee.UseVisualStyleBackColor = true;
            this.CmdImportEmployee.Click += new System.EventHandler(this.CmdImportEmployee_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.CmdResetSearchEmployee);
            this.panel1.Controls.Add(this.CmdSearchEmployee);
            this.panel1.Controls.Add(this.TxtSearchEmployee);
            this.panel1.Location = new System.Drawing.Point(1970, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 82);
            this.panel1.TabIndex = 10;
            // 
            // CmdResetSearchEmployee
            // 
            this.CmdResetSearchEmployee.Image = global::contact_manager.Properties.Resources.Cancel;
            this.CmdResetSearchEmployee.Location = new System.Drawing.Point(670, 14);
            this.CmdResetSearchEmployee.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.CmdResetSearchEmployee.Name = "CmdResetSearchEmployee";
            this.CmdResetSearchEmployee.Size = new System.Drawing.Size(61, 63);
            this.CmdResetSearchEmployee.TabIndex = 8;
            this.CmdResetSearchEmployee.UseVisualStyleBackColor = true;
            this.CmdResetSearchEmployee.Click += new System.EventHandler(this.CmdResetSearchEmployee_Click);
            // 
            // CmdSearchEmployee
            // 
            this.CmdSearchEmployee.Image = global::contact_manager.Properties.Resources.Search;
            this.CmdSearchEmployee.Location = new System.Drawing.Point(610, 14);
            this.CmdSearchEmployee.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.CmdSearchEmployee.Name = "CmdSearchEmployee";
            this.CmdSearchEmployee.Size = new System.Drawing.Size(61, 63);
            this.CmdSearchEmployee.TabIndex = 7;
            this.CmdSearchEmployee.UseVisualStyleBackColor = true;
            this.CmdSearchEmployee.Click += new System.EventHandler(this.CmdSearchEmployee_Click);
            // 
            // TxtSearchEmployee
            // 
            this.TxtSearchEmployee.Location = new System.Drawing.Point(7, 14);
            this.TxtSearchEmployee.Margin = new System.Windows.Forms.Padding(7, 8, 0, 8);
            this.TxtSearchEmployee.Name = "TxtSearchEmployee";
            this.TxtSearchEmployee.PlaceholderText = "Suchtext";
            this.TxtSearchEmployee.Size = new System.Drawing.Size(597, 47);
            this.TxtSearchEmployee.TabIndex = 2;
            this.TxtSearchEmployee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearchEmployee_KeyDown);
            // 
            // CmdDeleteEmployee
            // 
            this.CmdDeleteEmployee.Image = global::contact_manager.Properties.Resources.Delete;
            this.CmdDeleteEmployee.Location = new System.Drawing.Point(534, 16);
            this.CmdDeleteEmployee.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmdDeleteEmployee.Name = "CmdDeleteEmployee";
            this.CmdDeleteEmployee.Size = new System.Drawing.Size(243, 82);
            this.CmdDeleteEmployee.TabIndex = 9;
            this.CmdDeleteEmployee.Text = "Löschen";
            this.CmdDeleteEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdDeleteEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CmdDeleteEmployee.UseVisualStyleBackColor = true;
            this.CmdDeleteEmployee.Click += new System.EventHandler(this.CmdDeleteEmployee_Click);
            // 
            // CmdEditEmployee
            // 
            this.CmdEditEmployee.Image = global::contact_manager.Properties.Resources.Edit;
            this.CmdEditEmployee.Location = new System.Drawing.Point(277, 16);
            this.CmdEditEmployee.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmdEditEmployee.Name = "CmdEditEmployee";
            this.CmdEditEmployee.Size = new System.Drawing.Size(243, 82);
            this.CmdEditEmployee.TabIndex = 8;
            this.CmdEditEmployee.Text = "Bearbeiten";
            this.CmdEditEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdEditEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CmdEditEmployee.UseVisualStyleBackColor = true;
            this.CmdEditEmployee.Click += new System.EventHandler(this.CmdEditEmployee_Click);
            // 
            // CmdCreateNewEmployee
            // 
            this.CmdCreateNewEmployee.Image = global::contact_manager.Properties.Resources.NewItem;
            this.CmdCreateNewEmployee.Location = new System.Drawing.Point(19, 16);
            this.CmdCreateNewEmployee.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmdCreateNewEmployee.Name = "CmdCreateNewEmployee";
            this.CmdCreateNewEmployee.Size = new System.Drawing.Size(243, 82);
            this.CmdCreateNewEmployee.TabIndex = 7;
            this.CmdCreateNewEmployee.Text = "Neu";
            this.CmdCreateNewEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdCreateNewEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CmdCreateNewEmployee.UseVisualStyleBackColor = true;
            this.CmdCreateNewEmployee.Click += new System.EventHandler(this.CmdCreateNewEmployee_Click);
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.AllowUserToDeleteRows = false;
            this.dataGridViewEmployee.AutoGenerateColumns = false;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeNumberDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.stateDataGridViewTextBoxColumn1,
            this.CadreLevel,
            this.dateOfBirthDataGridViewTextBoxColumn1,
            this.sexDataGridViewTextBoxColumn1,
            this.streetNameDataGridViewTextBoxColumn1,
            this.streetNumberDataGridViewTextBoxColumn1,
            this.zipCodeDataGridViewTextBoxColumn1,
            this.cityDataGridViewTextBoxColumn1});
            this.dataGridViewEmployee.DataSource = this.employeeBindingSource;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(19, 109);
            this.dataGridViewEmployee.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.RowHeadersWidth = 102;
            this.dataGridViewEmployee.RowTemplate.Height = 25;
            this.dataGridViewEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(2686, 1268);
            this.dataGridViewEmployee.TabIndex = 5;
            this.dataGridViewEmployee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployee_CellDoubleClick);
            // 
            // employeeNumberDataGridViewTextBoxColumn
            // 
            this.employeeNumberDataGridViewTextBoxColumn.DataPropertyName = "EmployeeNumber";
            this.employeeNumberDataGridViewTextBoxColumn.HeaderText = "Mitarbeiter-Nr.";
            this.employeeNumberDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.employeeNumberDataGridViewTextBoxColumn.Name = "employeeNumberDataGridViewTextBoxColumn";
            this.employeeNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeNumberDataGridViewTextBoxColumn.Width = 250;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "Vorname";
            this.firstNameDataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn1.Width = 250;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "Nachname";
            this.lastNameDataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn1.Width = 250;
            // 
            // stateDataGridViewTextBoxColumn1
            // 
            this.stateDataGridViewTextBoxColumn1.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.stateDataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.stateDataGridViewTextBoxColumn1.Name = "stateDataGridViewTextBoxColumn1";
            this.stateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.stateDataGridViewTextBoxColumn1.Width = 60;
            // 
            // CadreLevel
            // 
            this.CadreLevel.DataPropertyName = "CadreLevel";
            this.CadreLevel.HeaderText = "Kaderstufe";
            this.CadreLevel.MinimumWidth = 12;
            this.CadreLevel.Name = "CadreLevel";
            this.CadreLevel.ReadOnly = true;
            this.CadreLevel.Width = 250;
            // 
            // dateOfBirthDataGridViewTextBoxColumn1
            // 
            this.dateOfBirthDataGridViewTextBoxColumn1.DataPropertyName = "DateOfBirth";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dateOfBirthDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dateOfBirthDataGridViewTextBoxColumn1.HeaderText = "Geburtstag";
            this.dateOfBirthDataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.dateOfBirthDataGridViewTextBoxColumn1.Name = "dateOfBirthDataGridViewTextBoxColumn1";
            this.dateOfBirthDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dateOfBirthDataGridViewTextBoxColumn1.Width = 250;
            // 
            // sexDataGridViewTextBoxColumn1
            // 
            this.sexDataGridViewTextBoxColumn1.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn1.HeaderText = "Geschlecht";
            this.sexDataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.sexDataGridViewTextBoxColumn1.Name = "sexDataGridViewTextBoxColumn1";
            this.sexDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sexDataGridViewTextBoxColumn1.Width = 250;
            // 
            // streetNameDataGridViewTextBoxColumn1
            // 
            this.streetNameDataGridViewTextBoxColumn1.DataPropertyName = "StreetName";
            this.streetNameDataGridViewTextBoxColumn1.HeaderText = "Strasse";
            this.streetNameDataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.streetNameDataGridViewTextBoxColumn1.Name = "streetNameDataGridViewTextBoxColumn1";
            this.streetNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.streetNameDataGridViewTextBoxColumn1.Width = 120;
            // 
            // streetNumberDataGridViewTextBoxColumn1
            // 
            this.streetNumberDataGridViewTextBoxColumn1.DataPropertyName = "StreetNumber";
            this.streetNumberDataGridViewTextBoxColumn1.HeaderText = "Nr.";
            this.streetNumberDataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.streetNumberDataGridViewTextBoxColumn1.Name = "streetNumberDataGridViewTextBoxColumn1";
            this.streetNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            this.streetNumberDataGridViewTextBoxColumn1.Width = 40;
            // 
            // zipCodeDataGridViewTextBoxColumn1
            // 
            this.zipCodeDataGridViewTextBoxColumn1.DataPropertyName = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn1.HeaderText = "PLZ";
            this.zipCodeDataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.zipCodeDataGridViewTextBoxColumn1.Name = "zipCodeDataGridViewTextBoxColumn1";
            this.zipCodeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.zipCodeDataGridViewTextBoxColumn1.Width = 60;
            // 
            // cityDataGridViewTextBoxColumn1
            // 
            this.cityDataGridViewTextBoxColumn1.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn1.HeaderText = "Ort";
            this.cityDataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.cityDataGridViewTextBoxColumn1.Name = "cityDataGridViewTextBoxColumn1";
            this.cityDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn1.Width = 120;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(contact_manager.Models.Data.Employee.Employee);
            // 
            // OverviewView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2744, 1484);
            this.Controls.Add(this.TcPerson);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OverviewView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "contact manager";
            this.TcPerson.ResumeLayout(false);
            this.TpCustomer.ResumeLayout(false);
            this.PnlSearchCustomer.ResumeLayout(false);
            this.PnlSearchCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.TpEmployee.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button CmdCreateNewCustomer;
        private TabControl TcPerson;
        private TabPage TpCustomer;
        private TabPage TpEmployee;
        private DataGridView dataGridViewCustomer;
        private TextBox TxtSearchCustomer;
        private DataGridView dataGridViewEmployee;
        private BindingSource customerBindingSource;
        private BindingSource employeeBindingSource;
        private Panel PnlSearchCustomer;
        private Button CmdDeleteCustomer;
        private Button CmdEditCustomer;
        private Button CmdSearchCustomer;
        private Button CmdResetSearchCustomer;
        private Panel panel1;
        private Button CmdResetSearchEmployee;
        private Button CmdSearchEmployee;
        private TextBox TxtSearchEmployee;
        private Button CmdDeleteEmployee;
        private Button CmdEditEmployee;
        private Button CmdCreateNewEmployee;
        private Button CmdImportCustomer;
        private Button CmdImportEmployee;
        private DataGridViewTextBoxColumn employeeNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn CadreLevel;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn streetNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn streetNumberDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn zipCodeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn customerNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn streetNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn streetNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn zipCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private ComboBox CmbSearchScopeCustomer;
        private ComboBox CmbSearchScopeEmployee;
    }
}
