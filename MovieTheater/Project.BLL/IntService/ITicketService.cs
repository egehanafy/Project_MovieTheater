using Project.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.IntService
{
    public interface ITicketService
    {
        IEnumerable<Ticket> GetAllTickets();
        string CreateTicket(Ticket ticket);
        string UpdateTicket(Ticket ticket);
    }
}
