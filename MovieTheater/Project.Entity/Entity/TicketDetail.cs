using Project.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entity.Entity
{
    public class TicketDetail:BaseEntity
    {
        public decimal? UnitPrice { get; set; }
        public short Quantity { get; set; }
        public int MovieId { get; set; }
        public int TicketId { get; set; }
        public string HallNo { get; set; }
        public string? SeatLetter { get; set; }
        public string? SeatNo { get; set; }
        public DateTime ShowTime { get; set; }

        //Relational Properties
        public virtual Movie Movie { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}
