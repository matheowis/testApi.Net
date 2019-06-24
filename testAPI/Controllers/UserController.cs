using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testAPI.Repository;

namespace testAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        [HttpGet]
        [Route("test")]
        public ActionResult Action()
        {
            var repo = new UserRepository();
            var people = repo.GetPeople();
            return Ok(people);
        }

        [HttpGet("(id)")]
        [Route("Person/{id}")]
        public ActionResult Person(int id)
        {
            var repo = new UserRepository();
            var user = repo.GetById(id);
            if (user == null)
            {
                return BadRequest("brak osoby");
            }
            return Ok(user);
        }

        [HttpPost()]
        [Route("PostPerson")]
        public ActionResult PostPerson([FromBody] int id)
        {
            var repo = new UserRepository();
            var user = repo.GetById(id);
            if (user == null)
            {
                return BadRequest("brak osoby");
            }
            return Ok(user);
        }
    }
}