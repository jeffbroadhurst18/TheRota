using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheRota.Models;
using AutoMapper;
using TheRota.ViewModels;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TheRota.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private IRotaRepository _repository;

        public PersonController(IRotaRepository repository)
        {
            _repository = repository;
        }

        // GET: api/values
        [HttpGet("persons")]
        public IActionResult Get()
        {
            try
            {
                var persons = _repository.GetPersons();
                //return Ok(Mapper.Map<IEnumerable<PersonViewModel>>(persons));
                var x = Mapper.Map<IEnumerable<PersonViewModel>>(persons);

                var lst = new List<PersonViewModel>();
                foreach (var i in x)
                {
                    lst.Add(Mapper.Map<PersonViewModel>(i));
                };
                return new JsonResult(lst, DefaultJsonSettings);
                //return new JsonResult(Mapper.Map<IEnumerable<PersonViewModel>>(persons), DefaultJsonSettings);
            }
            catch (Exception ex)
            {
                return BadRequest("Error Occurred in GetPersons");
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost("save")]
        public IActionResult Post([FromBody]PersonViewModel personVm)
        {
            var person = Mapper.Map<Person>(personVm);
            var result = _repository.SavePerson(person);
            return new JsonResult(result);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
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
