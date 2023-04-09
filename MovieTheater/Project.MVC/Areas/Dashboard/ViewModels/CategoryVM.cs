using System.ComponentModel.DataAnnotations;

namespace Project.MVC.Areas.Dashboard.ViewModels
{
    public class CategoryVM
    {
        [Required(ErrorMessage ="Kategori adi bos gecilemez")]
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
