using Microsoft.AspNetCore.Mvc;
using Dresses.API.Entities;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dresses.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IDataContext _usersContext;
        public UsersController(IDataContext usersContext)
        {
            _usersContext = usersContext;
        }
        // GET: api/<UsersController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_usersContext.Users);
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var user = _usersContext.Users.Find(x=> x.user_id == id);
            if( user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // POST api/<UsersController>
        [HttpPost]
        public ActionResult Post([FromBody] Users value)
        {
            var user = _usersContext.Users.Find(x => x.user_id == value.user_id);
            if( user == null)
            {
                _usersContext.Users.Add(value);
                return Ok(value);
            }
            return Conflict();
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Users value)
        {
            var index =_usersContext.Users.FindIndex ( x => x.user_id == id);
            _usersContext.Users[index].username = value.username;
            _usersContext.Users[index].password_hash = value.password_hash;
            _usersContext.Users[index].is_lender = value.is_lender;
            _usersContext.Users[index].email = value.email;
            _usersContext.Users[index].phone_number = value.phone_number;

        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
