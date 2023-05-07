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

        public int? AppUserId { get; set; }
        public int? CustomerId { get; set; }
        public string TicketNo { get; set; }
        public int? ShowTimeId { get; set; }

        //Relational Properties
        public virtual ShowTime ShowTime { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual List<TicketDetail> TicketDetails { get; set; }

    }
}
