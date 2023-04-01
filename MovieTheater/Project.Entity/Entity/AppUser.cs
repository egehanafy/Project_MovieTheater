using Microsoft.AspNetCore.Identity;
using System;

namespace Project.Entity.Entity
{
    public class AppUser:IdentityUser<int>
    {
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }

    }
}
