using System;
using System.Linq;
using System.Collections.Generic;
using gnv_back.Models;
using gnv_back.Repository;
using gnv_back.Repository.Generic;

namespace gnv_back.Business.Implementations
{
    public class StationBusinessImpl : IStationBusiness
    {
        private IStationRepository _repository;

        public StationBusinessImpl(IStationRepository repository) {
            _repository = repository;
        }

        public Station Create(Station station)
        {
            return _repository.Create(station);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Station> FindAll()
        {
            return _repository.FindAll();
        }

        public Station FindById(long id)
        {
            return _repository.FindById(id);
        }

        public List<Station> FindByState(string state)
        {
            return _repository.FindByState(state);
        }

        public Station Update(Station station)
        {
            return _repository.Update(station);
        }
    }
}