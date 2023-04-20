using Project.BLL.IntAbstract;
using Project.BLL.IntService;
using Project.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Project.BLL.Service
{
    public class TicketDetailService : ITicketDetailService
    {
        private readonly IRepository<TicketDetail> _ticketDetailRepo;

        public TicketDetailService(IRepository<TicketDetail> ticketDetailRepository)
        {
            _ticketDetailRepo = ticketDetailRepository;
        }

        public string CreateTicketDetail(TicketDetail ticketDetail)
        {
            try
            {
                return _ticketDetailRepo.Create(ticketDetail);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public IEnumerable<TicketDetail> GetaAllTicketDetails()
        {
            return _ticketDetailRepo.GetAll();
        }
    }
}
