using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contact_manager.Models.Customers.Data
{
    internal interface ICustomerRepository
    {
        List<Customer> GetAll();

        Customer GetById(long customerId);

        void Save(Customer customer);

        void Delete(long customerId);
    }
}
