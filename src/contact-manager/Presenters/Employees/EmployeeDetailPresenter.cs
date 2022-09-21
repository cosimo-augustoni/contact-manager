using contact_manager.Models.Data;
using contact_manager.Models.Data.History;
using contact_manager.Models.Domain;
using contact_manager.Models.Domain.Authentication;
using contact_manager.Models.Domain.History;
using contact_manager.Views.Employees;

namespace contact_manager.Presenters.Employees
{
    public class EmployeeDetailPresenter : EmployeeDetailPresenterBase<Employee, IEmployeeDetailDialog>
    {
        protected override EntityType PersonType => EntityType.Employee;

        public EmployeeDetailPresenter(IEmployeeDetailDialog dialog, IEmployeeService<Employee> employeeService, User user, bool isNewMode, IHistoryService historyService, IUserService userService) 
            : base(dialog, employeeService, user, isNewMode, historyService, userService)
        {
        }

        public override void Init()
        {
            this.Dialog.SetPresenter(this);
        }
    }
}
