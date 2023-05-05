using Project.Entity.Entity;
using Project.Entity.Enum;
using System.ComponentModel.DataAnnotations;

namespace Project.MVC.Areas.Dashboard.ViewModels
{
    public class EmployeeVM
    {
        [Required(ErrorMessage = "Name bos gecilemez")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Surname bos gecilemez")]
        public string EmployeeSurname { get; set; }
        [Required(ErrorMessage = "Title bos gecilemez")]
        public Title Title { get; set; }
    }
}
