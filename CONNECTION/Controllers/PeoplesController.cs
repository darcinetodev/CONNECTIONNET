using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONNECTION.Models;
using CONNECTION.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CONNECTION.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class PeoplesController : ControllerBase
    {

        private readonly IRepository _irepository;

        public PeoplesController(IRepository irepository)
        {
            _irepository = irepository;
        }

        // GET v1/peoples
        [HttpGet]
        public ActionResult Get()
        {
            return Ok( _irepository.GetAll());
        }

        // GET v1/peoples/id
        [HttpGet("{id}")]
        public ActionResult Get(Guid id)
        {
            return Ok(_irepository.Get(id));
        }

        // POST v1/peoples
        [HttpPost]
        public void Post([FromBody] Peoples peoples)
        {
            _irepository.Post(peoples);
        }

        // PUT v1/peoples/id
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] Peoples peoples)
        {
            var people = _irepository.Get(id);

            if (people == null)
            {
                return NotFound();
            }
            people.Name = peoples.Name;
            people.Email = peoples.Email;
            people.Phone = peoples.Phone;

            _irepository.Put(people);
            return Ok(people);
        }

        // DELETE v1/peoples/id
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            var people = _irepository.Get(id);

            if(people == null)
            {
                return NotFound();
            }

            _irepository.Delete(people);
            return Ok(people);
        }
    }
}
