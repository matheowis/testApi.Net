using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using testAPI.Repository;

namespace testAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateuszController : ControllerBase
    {
        [HttpGet]
        [Route("act")]
        public ActionResult Action()
        {
            var repo = new PersonRepository();
            var people = repo.GetPeople();
            return Ok(people);
        }
    }
}