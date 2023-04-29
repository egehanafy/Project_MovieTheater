using Project.BLL.IntAbstract;
using Project.BLL.IntService;
using Project.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Employee> _employeeRepository;

        public EmployeeService(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public string CreateEmployee(Employee employee)
        {
            try
            {
                return _employeeRepository.Create(employee);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteEmployee(Employee employee)
        {
            try
            {
                return _employeeRepository.Delete(employee);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Employee FindEmployee(int id)
        {
            return _employeeRepository.GetById(id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAll();
        }

        public string UpdateEmployee(Employee employee)
        {
            try
            {
                employee.Status = Entity.Enum.Status.Updated;
                return _employeeRepository.Update(employee);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
