using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mynovel.Models
{
    public class UserNotification
    {
        public int userId { get; set; }
        public Reader user { get; set; }

        public int notificationId { get; set; }
        public Notification notification { get; set; }
    }
}
