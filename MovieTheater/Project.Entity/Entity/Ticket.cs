using Project.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Entity.Entity
{
    public class Ticket:BaseEntity
    {
        [Required]
        public decimal UnitPrice { get; set; }
        public int? MovieId { get; set; }

        //Relational Properties
        public virtual Movie Movie { get; set; }
    }
}
