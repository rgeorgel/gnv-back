using System.Collections.Generic;
using gnv_back.Models;

namespace gnv_back.Business
{
    public interface INotificationBusiness
    {
        Notification Create(Notification notification);
        Notification FindById(long id);
        List<Notification> FindAll();
        Notification Update(Notification notification);
        void Delete(long id);
    }
}