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
        public virtual List<Seat> Seats { get; set; }
        public virtual List<ShowTime> ShowTimes { get; set; }
    }
}
