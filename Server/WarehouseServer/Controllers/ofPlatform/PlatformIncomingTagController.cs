using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehouseServer.Controllers.ofPlatform
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformIncomingTagController : ControllerBase
    {
        // GET: api/<PlatformIncomingTagController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PlatformIncomingTagController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PlatformIncomingTagController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PlatformIncomingTagController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PlatformIncomingTagController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
