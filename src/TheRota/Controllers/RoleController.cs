using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheRota.Models;
using Newtonsoft.Json;

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

        // GET: api/values
        [HttpGet("roles")]
        public IActionResult Get()
        {
            var data = _repository.GetRoles();
            return new JsonResult(data, DefaultJsonSettings);
        }

        private JsonSerializerSettings DefaultJsonSettings
        {
            get
            {
                return new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented
                };
            }
        }
    }
}
