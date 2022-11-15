
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mynovel.Models
{
    public class UserRoles: Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>
    {
    }
}
