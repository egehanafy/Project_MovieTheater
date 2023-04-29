using Project.BLL.IntAbstract;
using Project.BLL.IntService;
using Project.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer> _customerRepo;

        public CustomerService(IRepository<Customer> customerRepository)
        {
            _customerRepo = customerRepository;
        }
        public string CreateCustomer(Customer customer)
        {
            try
            {
                return _customerRepo.Create(customer);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteCustomer(Customer customer)
        {
            try
            {
                return _customerRepo.Delete(customer);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Customer FindCustomer(int id)
        {
            return _customerRepo.GetById(id);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _customerRepo.GetAll();
        }

        public string UpdateCustomer(Customer customer)
        {
            try
            {
                customer.Status = Entity.Enum.Status.Updated;
                return _customerRepo.Update(customer);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
