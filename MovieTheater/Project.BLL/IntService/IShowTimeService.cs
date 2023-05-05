using Project.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.IntService
{
    public interface IShowTimeService
    {
        IEnumerable<ShowTime> GetAllShowTime();
        string CreateShowTime(ShowTime showTime);
        string DeleteShowTime(ShowTime showTime);
        string UpdateShowTime(ShowTime showTime);
        ShowTime FindShowTime(int id);
    }
}
