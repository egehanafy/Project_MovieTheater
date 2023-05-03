using Project.Entity.Entity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Project.MVC.Areas.Dashboard.ViewModels
{
    public class MovieVM
    {
        [Required(ErrorMessage ="Film Adi bos gecilemez")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Aciklama bos gecilemez")]
        public string Description { get; set; }
        [Required(ErrorMessage ="Resim Yolu bos gecilemez")]
        public string ImagePath { get; set; }
        [Required(ErrorMessage ="Tur bos gecilemez")]
        public Genre Genre { get; set; }
    }
}
