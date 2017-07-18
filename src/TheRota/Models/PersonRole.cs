using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheRota.Models
{
    [Table("personroles")]
    public class PersonRole
    {
        public int Id { get; set; }
    }
}
