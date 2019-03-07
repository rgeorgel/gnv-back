using System;
using System.Linq;
using System.Collections.Generic;
using gnv_back.Models;
using gnv_back.Repository;
using gnv_back.Repository.Generic;

namespace gnv_back.Business.Implementations
{
    public class NotificationBusinessImpl : INotificationBusiness
    {
        private IRepository<Notification> _repository;

        public NotificationBusinessImpl(IRepository<Notification> repository) {
            _repository = repository;
        }

        public Notification Create(Notification notification)
        {
            return _repository.Create(notification);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Notification> FindAll()
        {
            return _repository.FindAll();
        }

        public Notification FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Notification Update(Notification notification)
        {
            return _repository.Update(notification);
        }
    }
}