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
    public class EmployeeLoadFrameController : ControllerBase
    {
        private readonly ILogger<EmployeeLoadFrameController> _logger;
        private readonly IEntityManager<LoadFrame> _employeeLoadFrameManager;
        private readonly IEntityDataRepository<LoadFrame> _employeeLoadFrameRepository;
        private readonly ModelToDTO<LoadFrame, EmployeeLoadFrame> _modelToDTO;

        public EmployeeLoadFrameController(ILogger<EmployeeLoadFrameController> logger, IEntityManager<LoadFrame> employeeLoadFrameManager, IEntityDataRepository<LoadFrame> employeeLoadFrameRepository, ModelToDTO<LoadFrame, EmployeeLoadFrame> modelToDTO)
        {
            _logger = logger;
            _employeeLoadFrameManager = employeeLoadFrameManager;
            _employeeLoadFrameRepository = employeeLoadFrameRepository;
            _modelToDTO = modelToDTO;
        }
        // GET: api/<EmployeeLoadFrameController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmployeeLoadFrameController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployeeLoadFrameController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeLoadFrameController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeLoadFrameController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
