using System.ComponentModel.DataAnnotations;

namespace Project.MVC.Models.ViewModels
{
    public class RegisterVM
    {
        //Username
        [Required(ErrorMessage = "Kullanici adi bos gecilemez")]
        [Display(Name = "Kullanici Adi")]
        public string Username { get; set; }

        //Email
        [Required(ErrorMessage = "Email bos gecilemez")]
        [Display(Name = "E-posta")]
        [EmailAddress(ErrorMessage = "Email adresi formatinda olmali")]
        public string Email { get; set; }
        
        //Password
        [Required(ErrorMessage = "Sifre bos gecilemez")]
        [Display(Name = "Sifre")]
        public string Password { get; set; }

        //ConfirmPassword
        [Required(ErrorMessage = "Sifre tekrari bos gecilemez")]
        [Display(Name = "Sifre (Tekrar)")]
        [Compare("Password",ErrorMessage = "Sifreler uyusmuyor")]
        public string ConfirmPassword { get; set; }

    }
}
