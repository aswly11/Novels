using mynovel.Data;
using mynovel.Infrastructure;
using mynovel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mynovel.Service
{
    public class NotificationRepository:INotification
    {
        private DBContext _context;

        public NotificationRepository(DBContext context)
        {
            _context = context;
        }

        public void Delete(Notification notification)
        {
            _context.Notifications.Remove(notification);
        }

        public List<Notification> GetAll()
        {
            return _context.Notifications.ToList();
        }

        public Notification GetById(int Id)
        {
            return _context.Notifications.Where(x => x.Id == Id).FirstOrDefault();
        }

        public void Insert(Notification notification)
        {
            _context.Notifications.Add(notification);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Notification notification)
        {
            _context.Notifications.Update(notification);
        }
    }
}
