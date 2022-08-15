using contact_manager.Model.Customers;

namespace contact_manager.Controller.Customers;

internal class CustomerDetailController : IPersonDetailController
{
    public Customer? Customer { get; set; }

    public void Save()
    {
        throw new NotImplementedException();
    }

    public void Load()
    {
        throw new NotImplementedException();
    }
}