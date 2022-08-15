using contact_manager.Controller;
using contact_manager.Model.Employees;

namespace contact_manager.View;

public interface IDashboardForm
{
    void SetEmployeeList(List<Employee> employees);
    void SetController(DashboardController dashboardController);
    DialogResult ShowDialog();
}