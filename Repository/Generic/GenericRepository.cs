using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using gnv_back.Models.Base;
using gnv_back.Models.Context;

namespace gnv_back.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected PostgresContext _context;
        private DbSet<T> dataset;
        public GenericRepository(PostgresContext context) {
            _context = context;
            dataset = _context.Set<T>();
        }

        public T Create(T item)
        {
            try {
                dataset.Add(item);
                _context.SaveChanges();
            } catch (Exception ex) {
                throw ex;
            }

            return item;
        }

        public void Delete(long id)
        {
            var result = dataset.SingleOrDefault(p => p.Id.Equals(id));

            try {
                if (result != null) {
                    dataset.Remove(result);
                    _context.SaveChanges();
                }
            } catch (Exception ex) {
                throw ex;
            }
        }

        public bool Exist(long? id)
        {
            return dataset.Any(p => p.Id.Equals(id));
        }

        public List<T> FindAll()
        {
            return dataset.ToList();
        }

        public T FindById(long id)
        {
            return dataset.SingleOrDefault(p => p.Id.Equals(id));
        }

        public T Update(T item)
        {
            if (!Exist(item.Id)) {
                return null;
            }

            var result = dataset.SingleOrDefault(p => p.Id.Equals(item.Id));

            try {
                _context.Entry(result).CurrentValues.SetValues(item);
                _context.SaveChanges();
            } catch (Exception ex) {
                throw ex;
            }

            return item;
        }
    }
}