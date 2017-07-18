using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheRota.ViewModels;

namespace TheRota.Models
{
    public class RotaRepository : IRotaRepository
    {
        private RotaContext _context;
        private ILogger<RotaRepository> _logger;

        public RotaRepository(RotaContext context, ILogger<RotaRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IEnumerable<Role> GetRoles()
        {
            var roles = _context.Roles.OrderBy(o => o.Name);
            return roles;
        }

        public IEnumerable<Picture> GetPictures(int id)
        {
            var total = _context.Pictures.Count();
            var pics = _context.Pictures.OrderBy(x => Guid.NewGuid()).Take(total < id ? total : id);
            return pics;
        }

        public IEnumerable<Person> GetPersons()
        {
            var people = _context.Persons.OrderBy(p => p.LastName);
            return people;
        }

        public int SavePerson(Person person)
        {
             _context.Add(person);
            return _context.SaveChanges();
        }

        public IEnumerable<PersonRoleViewModel> GetPersonRoles(int personId)
        {
            var person = _context.Persons.Include(p => p.PersonRoles).Where(y => y.Id == personId).First();
            var personRoleViewModelList = new List<PersonRoleViewModel>();

            foreach(var pr in person.PersonRoles)
            {
                var roles = _context.Roles.Include(p => p.PersonRoles);

                foreach (var role in roles)
                {
                    foreach(var rpr in role.PersonRoles)
                    {
                        if (pr.Id == rpr.Id)
                        {
                            var prvm = new PersonRoleViewModel
                            {
                                PersonId = person.Id,
                                PersonName = person.FirstName + " " + person.LastName,
                                RoleId = role.Id,
                                RoleName = role.Name
                            };
                            personRoleViewModelList.Add(prvm);
                        }
                    }
                }
                
            }

            return personRoleViewModelList;
        }
    }
}
