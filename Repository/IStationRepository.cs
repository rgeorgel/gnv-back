using System.Collections.Generic;
using gnv_back.Models;

namespace gnv_back.Repository
{
    public interface IStationRepository
    {
        Station Create(Station station);
        Station FindById(long id);
        List<Station> FindAll();
        Station Update(Station station);
        void Delete(long id);
        bool Exist(long? id);
    }
}