using System.ComponentModel.DataAnnotations;

namespace Project.MVC.Areas.Dashboard.ViewModels
{
    public class HallVM
    {
        [Required(ErrorMessage = "Salon adi bos gecilemez")]
        public string HallName { get; set; }
    }
}
