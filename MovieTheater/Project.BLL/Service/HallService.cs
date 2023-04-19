using Project.BLL.Abstract;
using Project.BLL.IntService;
using Project.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.Service
{
    public class HallService : IHallService
    {
        private readonly IRepository<Hall> _hallRepository;

        public HallService(IRepository<Hall> hallRepository)
        {
            _hallRepository = hallRepository;
        }
        public string CreateHall(Hall hall)
        {
            try
            {
                return _hallRepository.Create(hall);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteHall(Hall hall)
        {
            try
            {
                return _hallRepository.Delete(hall);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public IEnumerable<Hall> GetAllHalls()
        {
            return _hallRepository.GetAll();
        }

        public Hall GetById(int id)
        {
            return _hallRepository.GetById(id);
        }

        public string UpdateHall(Hall hall)
        {
            try
            {
                hall.Status = Entity.Enum.Status.Updated;
                return _hallRepository.Update(hall);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
