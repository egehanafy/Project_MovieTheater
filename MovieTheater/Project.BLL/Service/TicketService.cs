using Project.BLL.Abstract;
using Project.BLL.AbstractService;
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

        public string DeleteTicket(Ticket ticket)
        {
            try
            {
                return _ticketRepo.Delete(ticket);
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

        public Ticket GetById(int id)
        {
            return _ticketRepo.GetById(id);
        }

        public string UpdateTicket(Ticket ticket)
        {
            try
            {
                ticket.Status = Entity.Enum.Status.Updated;
                return _ticketRepo.Update(ticket);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
