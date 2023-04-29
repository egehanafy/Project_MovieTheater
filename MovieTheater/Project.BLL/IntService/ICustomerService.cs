using Project.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.IntService
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomers();
        string CreateCustomer(Customer customer);
        string DeleteCustomer(Customer customer);
        string UpdateCustomer(Customer customer);
        Customer FindCustomer(int id);
    }
}
