using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using pool_project.Entities;
using pool_project.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pool_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly ProductsService productsService;
        private object result;
        // GET: api/<ProductsController>
        [HttpGet]
        public ActionResult<List<Products>> Get()
        {
            List<Products> result = productsService.GetAll();
            if (result == null)
                return NotFound();
            return result;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public ActionResult<Products> Get(int id)
        {
            if (id == null) return NotFound();
            Products result = productsService.GetById(id);
            if (result == null)
                return NotFound();
            return result;
        }

        // POST api/<ProductsController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Products products)
        {
            return productsService.Post(products);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Products products)
        {
            return productsService.Put(id, products);
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return productsService.Delete(id);
        }
    }
}
