using Project.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Entity.Entity
{
    public class Ticket:BaseEntity
    {
        public Ticket()
        {
            TicketDetails = new List<TicketDetail>();
        }

        public int AppUserId { get; set; }
        public string TicketNo { get; set; }

        //Relational Properties
        public virtual AppUser AppUser { get; set; }
        public virtual List<TicketDetail> TicketDetails { get; set; }

    }
}
