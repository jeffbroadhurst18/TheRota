using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheRota.ViewModels
{
    public class PersonViewModel
    {
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string LastName { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 5)]
        public string IdNumber { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    }
}
