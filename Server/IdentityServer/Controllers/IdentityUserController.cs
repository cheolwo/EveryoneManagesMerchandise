using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IdentityServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityUserController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _UserManager;
     
        public IdentityUserController(UserManager<IdentityUser> userManager)
        {
            _UserManager = userManager;
        }
        // GET: api/<IdentityUserController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<IdentityUserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<IdentityUserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<IdentityUserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<IdentityUserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
