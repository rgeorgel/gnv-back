using System.Collections.Generic;
using gnv_back.Models;

namespace gnv_back.Business
{
    public interface IStationBusiness
    {
        Station Create(Station station);
        Station FindById(long id);
        List<Station> FindByState(string state);
        List<Station> FindAll();
        Station Update(Station station);
        void Delete(long id);
    }
}