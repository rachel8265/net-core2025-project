using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using pool_project.Entities;
using pool_project.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pool_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        readonly OrdersService ordersService;
        private object result;
        // GET: api/<OrdersController>
        [HttpGet]
        public ActionResult<List<Orders>> Get()
        {
            List<Orders> result = ordersService.GetAll();
            if (result == null)
                return NotFound();
            return result;
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public ActionResult<Orders> Get(int id)
        { 
            if(id == null) return NotFound();   
            Orders result = ordersService.GetById(id);
            if (result == null)
                return NotFound();
            return result;
        }

        // POST api/<OrdersController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Orders orders)
        {
            return ordersService.Post(orders);
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Orders orders)
        {
            return ordersService.Put(id, orders);
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return ordersService.Delete(id);
        }
    }
}
