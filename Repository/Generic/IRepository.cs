using System.Collections.Generic;
using gnv_back.Models.Base;

namespace gnv_back.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T FindById(long id);
        List<T> FindAll();
        T Update(T item);
        void Delete(long id);
        bool Exist(long? id);
    }
}