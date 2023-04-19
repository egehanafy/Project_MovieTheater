using Project.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.IntService
{
    public interface ISeatService
    {
        IEnumerable<Seat> GetAllSeats();
        string CreateSeat(Seat seat);
        string DeleteSeat(Seat seat);
        string UpdateSeat(Seat seat);
        Seat FindSeat(int id);
    }
}
