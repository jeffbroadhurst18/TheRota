using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheRota.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TheRota.Controllers
{
    public class RoleController : Controller
    {
        private IRotaRepository _repository;

        public RoleController(IRotaRepository repository)
        {
            _repository = repository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var data = _repository.GetRoles();
            return View(data);
        }
    }
}
