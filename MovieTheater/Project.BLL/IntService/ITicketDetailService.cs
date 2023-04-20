using Project.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.IntService
{
    public interface ITicketDetailService
    {
        IEnumerable<TicketDetail> GetaAllTicketDetails();
        string CreateTicketDetail(TicketDetail ticketDetail);
    }
}
