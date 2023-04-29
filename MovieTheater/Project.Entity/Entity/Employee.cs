using Project.Entity.Base;
using Project.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entity.Entity
{
    public class Employee:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Title Title { get; set; }
    }
}
