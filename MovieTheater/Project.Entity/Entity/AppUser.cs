﻿using Microsoft.AspNetCore.Identity;
using Project.Entity.Enum;
using System;
using System.Collections.Generic;

namespace Project.Entity.Entity
{
    public class AppUser:IdentityUser<int>
    {
        public AppUser()
        {
            Qualification = Qualification.None;
        }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public Qualification Qualification { get; set; }

        //Relational Properties
        public virtual List<Ticket> Tickets { get; set; }

    }
}
