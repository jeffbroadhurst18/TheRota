using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheRota.Models
{
    [Table("roles")]
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PersonRole> PersonRoles { get;set;}
    }
}
