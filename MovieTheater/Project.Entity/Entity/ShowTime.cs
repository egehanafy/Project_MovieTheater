using Project.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entity.Entity
{
    public class ShowTime:BaseEntity
    {
        public DateTime Time { get; set; } //.ToShortTimeString() orn: 21:45
        public int MovieId { get; set; }
        public int HallId { get; set; }

        //Relational Properties
        public virtual List<Ticket> Tickets { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual Hall Hall { get; set; }
    }
}
