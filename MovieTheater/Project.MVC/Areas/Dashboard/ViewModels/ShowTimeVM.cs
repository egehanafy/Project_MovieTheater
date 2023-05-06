using Project.Entity.Entity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Project.MVC.Areas.Dashboard.ViewModels
{
    public class ShowTimeVM
    {
        [Required(ErrorMessage = "Zaman bos gecilemez")]
        public DateTime Time { get; set; }
        public Movie Movie { get; set; }
        public Hall Hall { get; set; }
    }
}
