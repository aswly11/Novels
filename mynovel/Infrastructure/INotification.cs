using mynovel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mynovel.Infrastructure
{
    public interface INotification
    {

        List<Notification> GetAll();
        Notification GetById(int Id);
        void Insert(Notification notification);
        void Update(Notification notification);
        void Delete(Notification notification);
        void Save();
    }
}
