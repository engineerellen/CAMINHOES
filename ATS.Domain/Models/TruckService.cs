using ATS.Domain.Interfaces;

namespace ATS.Domain.Models
{
    public class TruckService
    {
        private readonly IRepository<Truck> _atsRepository;

        public TruckService(IRepository<Truck> atsRepository)
        {
            _atsRepository = atsRepository;
        }


    }
}