using Project.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.IntService
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployees();
        string CreateEmployee(Employee employee);
        string DeleteEmployee(Employee employee);
        string UpdateEmployee(Employee employee);
        Employee FindEmployee(int id);
    }
}
