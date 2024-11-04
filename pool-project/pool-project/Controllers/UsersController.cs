using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using pool_project.Entities;
using pool_project.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pool_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly UsersService usersService;
        private object result;
        // GET: api/<UsersController>
        [HttpGet]
        public ActionResult<List<Users>> Get()
        {
            List<Users> result = usersService.GetAll();
            if (result == null)
                return NotFound();
            return result;
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public ActionResult<Users> Get(int id)
        {
            if (id == null) return NotFound();
            Users result = usersService.GetById(id);
            if (result == null)
                return NotFound();
            return result;
        }

        // POST api/<UsersController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Users users)
        {
            return usersService.Post(users);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Users users)
        {
            return usersService.Put(id, users);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return usersService.Delete(id);
        }
    }
}
