using System.Collections.Generic;
using System.Linq;
using ATS.Domain.Models;
using ATS.Infra.Context;

namespace ATS.Infra.Repositories
{
    public class TruckRepository : Repository<Truck>
    {
        public TruckRepository(AppDbContext context) : base(context)
        {}

        public override Truck GetById(int id)
        {
            var query = _context.Set<Truck>().Where(e => e.Id == id);

            if(query.Any())
                return query.First();

            return null;
        }

        public override IEnumerable<Truck> GetAll()
        {
            var query = _context.Set<Truck>();

            return query.Any() ? query.ToList() : new List<Truck>();
        }
 

    }
}