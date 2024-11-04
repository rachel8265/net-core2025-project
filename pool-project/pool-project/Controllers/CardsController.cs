using Microsoft.AspNetCore.Mvc;
using pool_project.Entities;
using pool_project.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pool_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        readonly CardsService cardsService;
        private object result;
        // GET: api/<CardsController>
        [HttpGet]
        public ActionResult<List<Cards>> Get()
        {
            List<Cards> result = cardsService.GetAll();
            if(result == null)
               return NotFound();
            return result;
        }

        // GET api/<CardsController>/5
        [HttpGet("{id}")]
        public ActionResult<Cards> Get(int id)
        {
            if(id == null) return NotFound();
           Cards result= cardsService.GetById(id);
            if(result == null)
                return NotFound();
            return result;
        }

        // POST api/<CardsController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Cards cards)
        {
            return cardsService.Post(cards);
        }

        // PUT api/<CardsController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Cards cards)
        {
            return cardsService.Put(id,cards);
        }

        // DELETE api/<CardsController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return cardsService.Delete(id);
        }
    }
}
