using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofManager.ofGeneric;
using BusinessView.ofGeneric;
using BusinessView.ofWarehouse.ofEmployee;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehouseServer.Controllers.ofEmployee
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeIncomingTagController : ControllerBase
    {
        private readonly ILogger<EmployeeIncomingTagController> _logger;
        private readonly IEntityManager<IncomingTag> _employeeIncomingTagManager;
        private readonly IEntityDataRepository<IncomingTag> _employeeIncomingTagRepository;
        private readonly ModelToDTO<IncomingTag, EmployeeIncomingTag> _modelToDTO;

        public EmployeeIncomingTagController(ILogger<EmployeeIncomingTagController> logger, IEntityManager<IncomingTag> employeeIncomingTagManager, IEntityDataRepository<IncomingTag> employeeIncomingTagRepository, ModelToDTO<IncomingTag, EmployeeIncomingTag> modelToDTO)
        {
            _logger = logger;
            _employeeIncomingTagManager = employeeIncomingTagManager;
            _employeeIncomingTagRepository = employeeIncomingTagRepository;
            _modelToDTO = modelToDTO;
        } 
        // GET: api/<EmployeeIncomingTagController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmployeeIncomingTagController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployeeIncomingTagController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeIncomingTagController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeIncomingTagController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
