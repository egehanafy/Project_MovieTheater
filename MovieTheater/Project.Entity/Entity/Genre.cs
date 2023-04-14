using Project.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Entity.Entity
{
    public class Genre:BaseEntity
    {
        [Required]
        public string GenreName { get; set; }

        //Relational Poperties
        public virtual List<Movie> Movies { get; set; }
    }
}
