using Project.BLL.IntAbstract;
using Project.BLL.IntService;
using Project.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.Service
{
    public class SeatService:ISeatService
    {
        private readonly IRepository<Seat> _seatRepository;

        public SeatService(IRepository<Seat> seatRepository)
        {
            _seatRepository = seatRepository;
        }

        public string CreateSeat(Seat seat)
        {
            try
            {
                return _seatRepository.Create(seat);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteSeat(Seat seat)
        {
            try
            {
                return _seatRepository.Delete(seat);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Seat FindSeat(int id)
        {
            return _seatRepository.GetById(id);
        }

        public IEnumerable<Seat> GetAllSeats()
        {
            return _seatRepository.GetAll();
        }

        public string UpdateSeat(Seat seat)
        {
            try
            {
                seat.Status = Entity.Enum.Status.Updated;
                return _seatRepository.Update(seat);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
