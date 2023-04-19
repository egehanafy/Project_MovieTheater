using Project.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entity.Entity
{
    public class Seat:BaseEntity
    {
        public string Letter { get; set; }
        public int No { get; set; }
        public int? HallId { get; set; }

        //Relational Properties
        public virtual Hall Hall { get; set; }
    }
}
