using Project.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entity.Entity
{
    public class Movie:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
        public string Year { get; set; }
        public double Rating { get; set; }
        public string ImagePath { get; set; }
        public int GenreId { get; set; }

        //Relational Properties
        public virtual Genre Genre { get; set; }

    }
}
