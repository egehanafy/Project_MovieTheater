using Project.Entity.Entity;
using System;

namespace Project.MVC.Areas.Dashboard.ViewModels
{
    public class MovieVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
        public string Year { get; set; }
        public double Rating { get; set; }
        public string ImagePath { get; set; }
        public Genre Genre { get; set; }
    }
}
