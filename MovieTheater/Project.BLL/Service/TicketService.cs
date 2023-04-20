using Project.BLL.IntAbstract;
using Project.BLL.IntService;
using Project.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.Service
{
    public class TicketService : ITicketService
    {
        private IRepository<Ticket> _ticketRepo;

        public TicketService(IRepository<Ticket> ticketRepository)
        {
            _ticketRepo = ticketRepository;
        }

        public string CreateTicket(Ticket ticket)
        {
            try
            {
                return _ticketRepo.Create(ticket);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            return _ticketRepo.GetAll();
        }

    }
}
