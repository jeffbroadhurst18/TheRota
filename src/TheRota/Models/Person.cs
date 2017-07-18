using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheRota.Models
{
    [Table("persons")]
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdNumber { get; set; }
        public DateTime DateCreated { get; set; }
        public ICollection<PersonRole> PersonRoles { get; set; }
    }
}
