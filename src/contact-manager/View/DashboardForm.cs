using contact_manager.Controller;
using contact_manager.Model.Employees;

namespace contact_manager.View
{
    public partial class DashboardForm : Form, IDashboardForm
    {
        private DashboardController? controller;

        public DashboardForm()
        {
            InitializeComponent();
        }

        public void SetController(DashboardController dashboardController)
        {
            this.controller = dashboardController;
        }

        public void SetEmployeeList(List<Employee> employees)
        {
            throw new NotImplementedException();
        }
    }
}