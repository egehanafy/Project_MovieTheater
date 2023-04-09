using System.ComponentModel.DataAnnotations;

namespace Project.MVC.Areas.Dashboard.ViewModels
{
    public class GenreVM
    {
        [Required(ErrorMessage ="Tur adi bos gecilemez")]
        public string GenreName { get; set; }
    }
}
