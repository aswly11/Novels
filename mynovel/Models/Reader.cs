using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace mynovel.Models
{
    public class Reader:IdentityUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public string Name { get; set; }
        public string Password { get; set; }
      
        public List<UserNotification> UserNotifications { get; set; }

    }
}