using System;
using System.Linq;
using System.Collections.Generic;
using gnv_back.Models;
using gnv_back.Models.context;

namespace gnv_back.Repository.implementations
{
    public class StationRepositoryImpl : IStationRepository
    {
        private MySQLContext _context;

        public StationRepositoryImpl(MySQLContext context) {
            _context = context;
        }

        public Station Create(Station station)
        {
            try {
                _context.Stations.Add(station);
                _context.SaveChanges();
            } catch (Exception ex) {
                throw ex;
            }

            return station;
        }

        public void Delete(long id)
        {
            var result =_context.Stations.SingleOrDefault(p => p.Id.Equals(id));

            if (result != null) {
                _context.Stations.Remove(result);
                _context.SaveChanges();
            }

        }

        public List<Station> FindAll()
        {
            return _context.Stations.ToList();
        }

        public Station FindById(long id)
        {
            return _context.Stations.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Station Update(Station station)
        {
            if (!Exist(station.Id)) {
                return null;
            }

            var result = _context.Stations.SingleOrDefault(p => p.Id.Equals(station.Id));

            try {
                _context.Entry(result).CurrentValues.SetValues(station);
                _context.SaveChanges();
            } catch (Exception ex) {
                throw ex;
            }

            return station;
        }

        public bool Exist(long? id)
        {
            return _context.Stations.Any(p => p.Id.Equals(id));
        }
    }
}