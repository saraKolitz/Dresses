using Microsoft.AspNetCore.Mvc;
using Dresses.Core.Entities;
using Dresses.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dresses.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DressesController : ControllerBase
    {
        private readonly IDressService _dressService;
        public DressesController(IDressService dressService)
        {
            _dressService = dressService;
        }

        // GET: api/<DressesController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_dressService.GetDresses());
        }

        // GET api/<DressesController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok();
        }

        // POST api/<DressesController>
        [HttpPost]
        public ActionResult Post([FromBody] Dress value)
        {
            return Conflict();
        }

        // PUT api/<DressesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DressesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
