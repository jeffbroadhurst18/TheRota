using System.Collections.Generic;
using TheRota.ViewModels;

namespace TheRota.Models
{
    public interface IRotaRepository
    {
        IEnumerable<Role> GetRoles();
        IEnumerable<Picture> GetPictures(int id);
        IEnumerable<Person> GetPersons();
        int SavePerson(Person person);
        IEnumerable<PersonRoleViewModel> GetPersonRoles(int personId);
    }
}
