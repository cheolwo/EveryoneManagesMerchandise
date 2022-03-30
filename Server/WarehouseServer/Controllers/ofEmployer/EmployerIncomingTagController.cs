using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofManager.ofGeneric;
using BusinessView.ofGeneric;
using BusinessView.ofWarehouse.ofEmployer;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehouseServer.Controllers.ofEmployer
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerIncomingTagController : ControllerBase
    {
        private readonly ILogger<EmployerIncomingTagController> _logger;
        private readonly IEntityManager<IncomingTag> _employerIncomingTagManager;
        private readonly IEntityDataRepository<IncomingTag> _employerIncomingTagRepository;
        private readonly ModelToDTO<IncomingTag, EmployerIncomingTag> _modelToDTO;

        public EmployerIncomingTagController(ILogger<EmployerIncomingTagController> logger, IEntityManager<IncomingTag> employerIncomingTagManager, IEntityDataRepository<IncomingTag> employerIncomingTagRepository, ModelToDTO<IncomingTag, EmployerIncomingTag> modelToDTO)
        {
            _logger = logger;
            _employerIncomingTagManager = employerIncomingTagManager;
            _employerIncomingTagRepository = employerIncomingTagRepository;
            _modelToDTO = modelToDTO;
        } 
        // GET: api/<EmployerIncomingTagController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmployerIncomingTagController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployerIncomingTagController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployerIncomingTagController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployerIncomingTagController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
