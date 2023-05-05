using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.BLL.IntService;
using Project.BLL.Service;
using Project.Entity.Entity;
using Project.MVC.Areas.Dashboard.ViewModels;
using System.Linq;

namespace Project.MVC.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public IActionResult Index()
        {
            return View(_employeeService.GetAllEmployees().ToList());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeVM employeeVM)
        {
            Employee employee = new Employee
            {
                Name = employeeVM.EmployeeName,
                Surname = employeeVM.EmployeeSurname,
                Title = employeeVM.Title
            };

            TempData["result"] = _employeeService.CreateEmployee(employee);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var deleted = _employeeService.FindEmployee(id);

            if (deleted != null)
            {
                TempData["result"] = _employeeService.DeleteEmployee(deleted);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var updated = _employeeService.FindEmployee(id);
            return View(updated);
        }

        [HttpPost]
        public IActionResult Update(Employee employee)
        {
            TempData["result"] = _employeeService.UpdateEmployee(employee);
            return RedirectToAction("Index");
        }
    }
}
