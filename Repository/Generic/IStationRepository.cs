using System.Collections.Generic;
using gnv_back.Models;

namespace gnv_back.Repository.Generic
{
    public interface IStationRepository : IRepository<Station>
    {
        List<Station> FindByState(string state);
    }
}