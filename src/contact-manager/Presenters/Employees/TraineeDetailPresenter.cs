using contact_manager.Models.Data;
using contact_manager.Models.Data.History;
using contact_manager.Models.Domain;
using contact_manager.Models.Domain.Authentication;
using contact_manager.Models.Domain.History;
using contact_manager.Views.Employees;

namespace contact_manager.Presenters.Employees;

public class TraineeDetailPresenter : EmployeeDetailPresenterBase<Trainee, ITraineeDetailDialog>
{
    protected override EntityType PersonType => EntityType.Trainee;

    public TraineeDetailPresenter(ITraineeDetailDialog dialog, IEmployeeService<Trainee> employeeService, IHistoryService historyService, IUserService userService, User user, bool isNewMode) 
        : base(dialog, employeeService, historyService, userService, user, isNewMode)
    {
    }

    public override void Init()
    {
        this.Dialog.SetPresenter(this);
    }

    protected override Trainee ReadFromDialog()
    {
        var trainee = base.ReadFromDialog();
        trainee.YearsOfApprenticeship = this.Dialog.YearsOfApprenticeship;
        trainee.CurrentYearOfApprenticeship = this.Dialog.CurrentYearOfApprenticeship;
        return trainee;
    }

    protected override void WriteToDialog(Trainee employee)
    {
        base.WriteToDialog(employee);
        this.Dialog.YearsOfApprenticeship = employee.YearsOfApprenticeship;
        this.Dialog.CurrentYearOfApprenticeship = employee.CurrentYearOfApprenticeship;
    }
}
