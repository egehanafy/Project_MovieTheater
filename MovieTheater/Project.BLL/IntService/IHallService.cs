using Project.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.IntService
{
    public interface IHallService
    {
        IEnumerable<Hall> GetAllHalls();
        string CreateHall(Hall hall);
        string DeleteHall(Hall hall);
        string UpdateHall(Hall hall);
        Hall GetById(int id);
    }
}
