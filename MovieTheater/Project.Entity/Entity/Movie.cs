using Project.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entity.Entity
{
    public class Movie:BaseEntity
    {
        public string MovieName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

    }
}
