using Project.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entity.Entity
{
    public class Hall:BaseEntity
    {
        public string No { get; set; }

        //Relational Properties
        public virtual List<Movie> Movies { get; set; }
        public virtual List<Seat> Seats { get; set; }
    }
}
