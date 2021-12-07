using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_project.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Column(TypeName = "Varchar(25)")]
        public string AdminName { get; set; }

        [Column(TypeName = "Varchar(20)")]
        public string AdminPassword { get; set; }
    }
}
