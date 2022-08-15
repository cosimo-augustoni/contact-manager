using contact_manager.Model.Employees;

namespace contact_manager.Controller.Employees
{
    internal class EmployeeDetailController : IPersonDetailController
    {
        public Employee? Employee { get; set; }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Load()
        {
            throw new NotImplementedException();
        }
    }
}
