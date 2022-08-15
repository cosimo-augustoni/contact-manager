using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using contact_manager.Model.Customers;
using contact_manager.Model.Employees;
using contact_manager.View;

namespace contact_manager.Controller
{
    public class DashboardController
    {
        private readonly IDashboardForm dashboardForm;

        public DashboardController(IDashboardForm dashboardForm)
        {
            this.dashboardForm = dashboardForm;
        }

        public void LoadView()
        {
            this.dashboardForm.SetController(this);
            this.dashboardForm.ShowDialog();
        }

        public List<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public void OpenCreateNewEmployeeDialog()
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public void OpenCreateNewCustomerDialog()
        {
            throw new NotImplementedException();
        }
    }
}
