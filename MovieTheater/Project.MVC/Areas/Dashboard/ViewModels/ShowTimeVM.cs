using Project.Entity.Entity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Project.MVC.Areas.Dashboard.ViewModels
{
    public class ShowTimeVM
    {
        [Required(ErrorMessage = "Zaman bos gecilemez")]
        public DateTime Time { get; set; }
        [Required(ErrorMessage = "Film bos gecilemez")]
        public Movie Movie { get; set; }
        [Required(ErrorMessage = "Salon bos gecilemez")]
        public Hall Hall { get; set; }
    }
}
