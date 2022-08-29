using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using contact_manager.Models;
using contact_manager.Models.Data;
using contact_manager.Models.Data.Customer;
using contact_manager.Models.Data.Employee;
using contact_manager.Models.Domain.Customer;
using contact_manager.Models.Domain.Employee;
using contact_manager.Presenters;

namespace contact_manager.Views
{
    public partial class LoginForm : Form
    {
        private readonly IUserStore _userStore;

        public LoginForm(IUserStore userStore)
        {
            this._userStore = userStore;
            this.InitializeComponent();
        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {
            // todo resx-datei erstellen und die texte hier darin ablegen
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var user = _userStore.GetUser(TxtUserName.Text, TxtPassword.Text);

                if (user == null)
                {
                    LoginErrorProvider.SetError(TxtUserName, "Benutzername und/oder Passwort ist falsch");
                    return;
                }

                // todo: separate methode für den wechsel auf die übersicht
                // Todo: dashboardview umbenennen
                var dashboardView = new DashboardView();
                var customerRepository = new PersonRepository<Customer>(new FilePersonStore<Customer>());
                var customerService = new CustomerService(customerRepository);
                var employeeRepository = new PersonRepository<Employee>(new FilePersonStore<Employee>());
                var employeeService = new EmployeeService(employeeRepository);
                var dashboardPresenter = new DashboardPresenter(dashboardView, customerService, employeeService, user);
                dashboardPresenter.LoadAllCustomers();
                dashboardView.Show();
                dashboardView.FormClosed += (s, args) => this.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kontrollieren Sie die Benutzereingaben", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(TxtUserName.Text))
            {
                e.Cancel = true;
                TxtUserName.Focus();
                LoginErrorProvider.SetError(TxtUserName, "Geben Sie einen Benutzernamen an");
            }
            else
            {
                e.Cancel = false;
                LoginErrorProvider.SetError(TxtUserName, null);
            }
        }

        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(TxtPassword.Text))
            {
                e.Cancel = true;
                TxtPassword.Focus();
                LoginErrorProvider.SetError(TxtPassword, "Geben Sie ein Passwort ein");
            }
            else
            {
                LoginErrorProvider.SetError(TxtPassword, null);
            }
        }
    }
}
