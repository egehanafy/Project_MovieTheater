using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Project.MVC.Models.ViewModels
{
    public class LoginVM
    {
        //Username
        [Required(ErrorMessage = "Kullanici adi bos gecilemez")]
        [Display(Name = "Kullanici Adi")]
        public string Username { get; set; }

        //Password
        [Required(ErrorMessage = "Sifre bos gecilemez")]
        [Display(Name = "Sifre")]
        public string Password { get; set; }
    }
}
