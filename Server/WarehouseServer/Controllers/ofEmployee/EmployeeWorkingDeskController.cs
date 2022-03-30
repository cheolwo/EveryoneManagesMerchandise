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
    public class EmployeeWorkingDeskController : ControllerBase
    {
        private readonly ILogger<EmployeeWorkingDeskController> _logger;
        private readonly IEntityManager<WorkingDesk> _employeeWorkingDeskManager;
        private readonly IEntityDataRepository<WorkingDesk> _employeeWorkingDeskRepository;
        private readonly ModelToDTO<WorkingDesk, EmployeeWorkingDesk> _modelToDTO;

        public EmployeeWorkingDeskController(ILogger<EmployeeWorkingDeskController> logger, IEntityManager<WorkingDesk> employeeWorkingDeskManager, IEntityDataRepository<WorkingDesk> employeeWorkingDeskRepository, ModelToDTO<WorkingDesk, EmployeeWorkingDesk> modelToDTO)
        {
            _logger = logger;
            _employeeWorkingDeskManager = employeeWorkingDeskManager;
            _employeeWorkingDeskRepository = employeeWorkingDeskRepository;
            _modelToDTO = modelToDTO;
        }
        // GET: api/<EmployeeWorkingDeskController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmployeeWorkingDeskController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployeeWorkingDeskController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeWorkingDeskController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeWorkingDeskController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
