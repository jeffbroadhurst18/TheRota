using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TheRota.ViewModels
{
    public class PersonRoleViewModel
    {
        public int Id { get; set; }

        [Required]
        public int PersonId {get;set;}

        public string PersonName { get; set; }

        [Required]
        public int RoleId { get; set;}

        public string RoleName { get; set; }
    }
}
