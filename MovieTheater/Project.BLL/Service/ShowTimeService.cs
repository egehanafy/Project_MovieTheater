using Project.BLL.IntAbstract;
using Project.BLL.IntService;
using Project.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.Service
{
    public class ShowTimeService : IShowTimeService
    {
        private readonly IRepository<ShowTime> _showTimeRepository;

        public ShowTimeService(IRepository<ShowTime> showTimeRepository)
        {
            _showTimeRepository = showTimeRepository;
        }
        public string CreateShowTime(ShowTime showTime)
        {
            try
            {
                return _showTimeRepository.Create(showTime);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteShowTime(ShowTime showTime)
        {
            try
            {
                return _showTimeRepository.Delete(showTime);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public ShowTime FindShowTime(int id)
        {
            return _showTimeRepository.GetById(id);
        }

        public IEnumerable<ShowTime> GetAllShowTime()
        {
            return _showTimeRepository.GetAll();
        }

        public string UpdateShowTime(ShowTime showTime)
        {
            try
            {
                showTime.Status = Entity.Enum.Status.Updated;
                return _showTimeRepository.Update(showTime);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
