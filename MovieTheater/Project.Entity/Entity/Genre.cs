using Project.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entity.Entity
{
    public class Genre:BaseEntity
    {
        public string GenreName { get; set; }

        //Relational Poperties
        public virtual List<Movie> Movies { get; set; }
    }
}
