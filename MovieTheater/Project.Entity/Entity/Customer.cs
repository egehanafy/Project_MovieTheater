using Project.Entity.Base;
using Project.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entity.Entity
{
    public class Customer:BaseEntity
    {
        public Customer()
        {
            Qualification = Qualification.None;
        }
        public DateTime BirthDate { get; set; }
        public Qualification Qualification { get; set; }

        //Relational Properties
        public virtual List<Ticket> Tickets { get; set; }

    }
}
