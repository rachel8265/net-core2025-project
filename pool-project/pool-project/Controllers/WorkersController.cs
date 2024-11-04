using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using pool_project.Entities;
using pool_project.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pool_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkersController : ControllerBase
    {
        readonly WorkersService workersService;
        private object result;
        // GET: api/<WorkersController>
        [HttpGet]
        public ActionResult<List<Workers>> Get()
        {
            List<Workers> result = workersService.GetAll();
            if (result == null)
                return NotFound();
            return result;
        }

        // GET api/<WorkersController>/5
        [HttpGet("{id}")]
        public ActionResult<Workers> Get(int id)
        {
            if (id == null) return NotFound();
            Workers result = workersService.GetById(id);
            if (result == null)
                return NotFound();
            return result;
        }

        // POST api/<WorkersController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Workers workers)
        {
            return workersService.Post(workers);
        }

        // PUT api/<WorkersController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Workers workers)
        {
            return workersService.Put(id, workers);
        }

        // DELETE api/<WorkersController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return workersService.Delete(id);
        }
    }
}
