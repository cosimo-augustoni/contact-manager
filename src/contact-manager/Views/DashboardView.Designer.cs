namespace contact_manager.Views
{
    partial class DashboardView
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
      this.CmdCreateNewEmployee = new System.Windows.Forms.Button();
      this.CmdCreateNewCustomer = new System.Windows.Forms.Button();
      this.TcPerson = new System.Windows.Forms.TabControl();
      this.TpCustomer = new System.Windows.Forms.TabPage();
      this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
      this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.TxtSearchCustomer = new System.Windows.Forms.TextBox();
      this.TpEmployee = new System.Windows.Forms.TabPage();
      this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
      this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.TxtSearchEmployee = new System.Windows.Forms.TextBox();
      this.employeeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.entranceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.exitDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cadreLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TcPerson.SuspendLayout();
      this.TpCustomer.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
      this.TpEmployee.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // CmdCreateNewEmployee
      // 
      this.CmdCreateNewEmployee.Location = new System.Drawing.Point(6, 6);
      this.CmdCreateNewEmployee.Name = "CmdCreateNewEmployee";
      this.CmdCreateNewEmployee.Size = new System.Drawing.Size(156, 23);
      this.CmdCreateNewEmployee.TabIndex = 0;
      this.CmdCreateNewEmployee.Text = "Create New Employee";
      this.CmdCreateNewEmployee.UseVisualStyleBackColor = true;
      this.CmdCreateNewEmployee.Click += new System.EventHandler(this.CmdCreateNewEmployee_Click);
      // 
      // CmdCreateNewCustomer
      // 
      this.CmdCreateNewCustomer.Location = new System.Drawing.Point(6, 6);
      this.CmdCreateNewCustomer.Name = "CmdCreateNewCustomer";
      this.CmdCreateNewCustomer.Size = new System.Drawing.Size(156, 23);
      this.CmdCreateNewCustomer.TabIndex = 1;
      this.CmdCreateNewCustomer.Text = "Create New Customer";
      this.CmdCreateNewCustomer.UseVisualStyleBackColor = true;
      this.CmdCreateNewCustomer.Click += new System.EventHandler(this.CmdCreateNewCustomer_Click);
      // 
      // TcPerson
      // 
      this.TcPerson.Controls.Add(this.TpCustomer);
      this.TcPerson.Controls.Add(this.TpEmployee);
      this.TcPerson.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TcPerson.Location = new System.Drawing.Point(0, 0);
      this.TcPerson.Multiline = true;
      this.TcPerson.Name = "TcPerson";
      this.TcPerson.SelectedIndex = 0;
      this.TcPerson.Size = new System.Drawing.Size(875, 535);
      this.TcPerson.TabIndex = 19;
      // 
      // TpCustomer
      // 
      this.TpCustomer.Controls.Add(this.dataGridViewCustomer);
      this.TpCustomer.Controls.Add(this.TxtSearchCustomer);
      this.TpCustomer.Controls.Add(this.CmdCreateNewCustomer);
      this.TpCustomer.Location = new System.Drawing.Point(4, 24);
      this.TpCustomer.Name = "TpCustomer";
      this.TpCustomer.Padding = new System.Windows.Forms.Padding(3);
      this.TpCustomer.Size = new System.Drawing.Size(867, 507);
      this.TpCustomer.TabIndex = 0;
      this.TpCustomer.Text = "Kunden";
      this.TpCustomer.UseVisualStyleBackColor = true;
      // 
      // dataGridViewCustomer
      // 
      this.dataGridViewCustomer.AllowUserToAddRows = false;
      this.dataGridViewCustomer.AllowUserToDeleteRows = false;
      this.dataGridViewCustomer.AutoGenerateColumns = false;
      this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stateDataGridViewTextBoxColumn,
            this.customerNumberDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.customerTypeDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn});
      this.dataGridViewCustomer.DataSource = this.customerBindingSource;
      this.dataGridViewCustomer.Location = new System.Drawing.Point(8, 35);
      this.dataGridViewCustomer.Name = "dataGridViewCustomer";
      this.dataGridViewCustomer.ReadOnly = true;
      this.dataGridViewCustomer.RowTemplate.Height = 25;
      this.dataGridViewCustomer.Size = new System.Drawing.Size(859, 464);
      this.dataGridViewCustomer.TabIndex = 3;
      // 
      // stateDataGridViewTextBoxColumn
      // 
      this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
      this.stateDataGridViewTextBoxColumn.HeaderText = "Status";
      this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
      this.stateDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // customerNumberDataGridViewTextBoxColumn
      // 
      this.customerNumberDataGridViewTextBoxColumn.DataPropertyName = "CustomerNumber";
      this.customerNumberDataGridViewTextBoxColumn.HeaderText = "Kunden-Nr.";
      this.customerNumberDataGridViewTextBoxColumn.Name = "customerNumberDataGridViewTextBoxColumn";
      this.customerNumberDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // companyNameDataGridViewTextBoxColumn
      // 
      this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
      this.companyNameDataGridViewTextBoxColumn.HeaderText = "Firmenname";
      this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
      this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // customerTypeDataGridViewTextBoxColumn
      // 
      this.customerTypeDataGridViewTextBoxColumn.DataPropertyName = "CustomerType";
      this.customerTypeDataGridViewTextBoxColumn.HeaderText = "Kundentyp";
      this.customerTypeDataGridViewTextBoxColumn.Name = "customerTypeDataGridViewTextBoxColumn";
      this.customerTypeDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // firstNameDataGridViewTextBoxColumn
      // 
      this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
      this.firstNameDataGridViewTextBoxColumn.HeaderText = "Vorname";
      this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
      this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // lastNameDataGridViewTextBoxColumn
      // 
      this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
      this.lastNameDataGridViewTextBoxColumn.HeaderText = "Nachname";
      this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
      this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // dateOfBirthDataGridViewTextBoxColumn
      // 
      this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
      this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Geburtsdatum";
      this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
      this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // sexDataGridViewTextBoxColumn
      // 
      this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
      this.sexDataGridViewTextBoxColumn.HeaderText = "Geschlecht";
      this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
      this.sexDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // customerBindingSource
      // 
      this.customerBindingSource.DataSource = typeof(contact_manager.Models.Data.Customer.Customer);
      // 
      // TxtSearchCustomer
      // 
      this.TxtSearchCustomer.Location = new System.Drawing.Point(619, 6);
      this.TxtSearchCustomer.Name = "TxtSearchCustomer";
      this.TxtSearchCustomer.PlaceholderText = "Seach text";
      this.TxtSearchCustomer.Size = new System.Drawing.Size(248, 23);
      this.TxtSearchCustomer.TabIndex = 2;
      // 
      // TpEmployee
      // 
      this.TpEmployee.Controls.Add(this.dataGridViewEmployee);
      this.TpEmployee.Controls.Add(this.TxtSearchEmployee);
      this.TpEmployee.Controls.Add(this.CmdCreateNewEmployee);
      this.TpEmployee.Location = new System.Drawing.Point(4, 24);
      this.TpEmployee.Name = "TpEmployee";
      this.TpEmployee.Padding = new System.Windows.Forms.Padding(3);
      this.TpEmployee.Size = new System.Drawing.Size(867, 507);
      this.TpEmployee.TabIndex = 1;
      this.TpEmployee.Text = "Mitarbeiter";
      this.TpEmployee.UseVisualStyleBackColor = true;
      // 
      // dataGridViewEmployee
      // 
      this.dataGridViewEmployee.AllowUserToAddRows = false;
      this.dataGridViewEmployee.AllowUserToDeleteRows = false;
      this.dataGridViewEmployee.AutoGenerateColumns = false;
      this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeNumberDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.entranceDateDataGridViewTextBoxColumn,
            this.exitDateDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.cadreLevelDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1});
      this.dataGridViewEmployee.DataSource = this.employeeBindingSource;
      this.dataGridViewEmployee.Location = new System.Drawing.Point(6, 36);
      this.dataGridViewEmployee.Name = "dataGridViewEmployee";
      this.dataGridViewEmployee.ReadOnly = true;
      this.dataGridViewEmployee.RowTemplate.Height = 25;
      this.dataGridViewEmployee.Size = new System.Drawing.Size(859, 464);
      this.dataGridViewEmployee.TabIndex = 5;
      // 
      // employeeBindingSource
      // 
      this.employeeBindingSource.DataSource = typeof(contact_manager.Models.Data.Employee.Employee);
      // 
      // TxtSearchEmployee
      // 
      this.TxtSearchEmployee.Location = new System.Drawing.Point(617, 7);
      this.TxtSearchEmployee.Name = "TxtSearchEmployee";
      this.TxtSearchEmployee.PlaceholderText = "Seach text";
      this.TxtSearchEmployee.Size = new System.Drawing.Size(248, 23);
      this.TxtSearchEmployee.TabIndex = 4;
      // 
      // employeeNumberDataGridViewTextBoxColumn
      // 
      this.employeeNumberDataGridViewTextBoxColumn.DataPropertyName = "EmployeeNumber";
      this.employeeNumberDataGridViewTextBoxColumn.HeaderText = "Mitarbeiter-Nr.";
      this.employeeNumberDataGridViewTextBoxColumn.Name = "employeeNumberDataGridViewTextBoxColumn";
      this.employeeNumberDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // departmentDataGridViewTextBoxColumn
      // 
      this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
      this.departmentDataGridViewTextBoxColumn.HeaderText = "Abteilung";
      this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
      this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // entranceDateDataGridViewTextBoxColumn
      // 
      this.entranceDateDataGridViewTextBoxColumn.DataPropertyName = "EntranceDate";
      this.entranceDateDataGridViewTextBoxColumn.HeaderText = "Eintrittsdatum";
      this.entranceDateDataGridViewTextBoxColumn.Name = "entranceDateDataGridViewTextBoxColumn";
      this.entranceDateDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // exitDateDataGridViewTextBoxColumn
      // 
      this.exitDateDataGridViewTextBoxColumn.DataPropertyName = "ExitDate";
      this.exitDateDataGridViewTextBoxColumn.HeaderText = "Austrittsdatum";
      this.exitDateDataGridViewTextBoxColumn.Name = "exitDateDataGridViewTextBoxColumn";
      this.exitDateDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // roleDataGridViewTextBoxColumn
      // 
      this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
      this.roleDataGridViewTextBoxColumn.HeaderText = "Rolle";
      this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
      this.roleDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // cadreLevelDataGridViewTextBoxColumn
      // 
      this.cadreLevelDataGridViewTextBoxColumn.DataPropertyName = "CadreLevel";
      this.cadreLevelDataGridViewTextBoxColumn.HeaderText = "Kaderstufe";
      this.cadreLevelDataGridViewTextBoxColumn.Name = "cadreLevelDataGridViewTextBoxColumn";
      this.cadreLevelDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // firstNameDataGridViewTextBoxColumn1
      // 
      this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
      this.firstNameDataGridViewTextBoxColumn1.HeaderText = "Vorname";
      this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
      this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // lastNameDataGridViewTextBoxColumn1
      // 
      this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
      this.lastNameDataGridViewTextBoxColumn1.HeaderText = "Nachname";
      this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
      this.lastNameDataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // DashboardView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(875, 535);
      this.Controls.Add(this.TcPerson);
      this.Name = "DashboardView";
      this.Text = "DashboardView";
      this.TcPerson.ResumeLayout(false);
      this.TpCustomer.ResumeLayout(false);
      this.TpCustomer.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
      this.TpEmployee.ResumeLayout(false);
      this.TpEmployee.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private Button CmdCreateNewEmployee;
        private Button CmdCreateNewCustomer;
    private TabControl TcPerson;
    private TabPage TpCustomer;
    private TabPage TpEmployee;
    private DataGridView dataGridViewCustomer;
    private TextBox TxtSearchCustomer;
    private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn customerNumberDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn customerTypeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
    private BindingSource customerBindingSource;
    private DataGridView dataGridViewEmployee;
    private BindingSource employeeBindingSource;
    private TextBox TxtSearchEmployee;
    private DataGridViewTextBoxColumn employeeNumberDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn entranceDateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn exitDateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cadreLevelDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
  }
}