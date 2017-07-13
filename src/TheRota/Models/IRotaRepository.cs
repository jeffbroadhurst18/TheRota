using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheRota.Models;

namespace TheRota.Models
{
    public interface IRotaRepository
    {
        IEnumerable<Role> GetRoles();
        IEnumerable<Picture> GetPictures(int id);
        IEnumerable<Person> GetPersons();
        int SavePerson(Person person);
    }
}
