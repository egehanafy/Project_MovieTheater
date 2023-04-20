using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Project.Entity.Entity
{
    public class AppUser:IdentityUser<int>
    {
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }

        //Relational Properties
        public virtual List<Ticket> Tickets { get; set; }

    }
}
