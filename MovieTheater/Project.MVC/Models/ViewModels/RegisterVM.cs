using System.ComponentModel.DataAnnotations;

namespace Project.MVC.Models.ViewModels
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Email bos gecilemez")]
        [EmailAddress(ErrorMessage = "Email adresi formatinda olmali")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Sifre bos gecilemez")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Sifre tekrari bos gecilemez")]
        [Compare("Password",ErrorMessage = "Sifreler uyusmuyor")]
        public string ConfirmPassword { get; set; }

    }
}
