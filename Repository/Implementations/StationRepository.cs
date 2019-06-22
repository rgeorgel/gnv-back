using System.Linq;
using System.Collections.Generic;
using gnv_back.Models.Context;
using gnv_back.Repository.Generic;
using gnv_back.Models;

namespace gnv_back.Repository.Implementations
{
    public class StationRepository : GenericRepository<Station>, IStationRepository
    {
        public StationRepository(PostgresContext context) : base(context) {}

        public List<Station> FindByState(string state)
        {
            return _context.Stations.Where(s => s.State == state).ToList();
        }
    }
}