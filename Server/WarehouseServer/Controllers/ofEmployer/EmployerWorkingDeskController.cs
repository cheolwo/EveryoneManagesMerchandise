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
    public class EmployerWorkingDeskController : ControllerBase
    {
        private readonly ILogger<EmployerWorkingDeskController> _logger;
        private readonly IEntityManager<WorkingDesk> _employerWorkingDeskManager;
        private readonly IEntityDataRepository<WorkingDesk> _employerWorkingDeskRepository;
        private readonly ModelToDTO<WorkingDesk, EmployerWorkingDesk> _modelToDTO;

        public EmployerWorkingDeskController(ILogger<EmployerWorkingDeskController> logger, IEntityManager<WorkingDesk> employerWorkingDeskManager, IEntityDataRepository<WorkingDesk> employerWorkingDeskRepository, ModelToDTO<WorkingDesk, EmployerWorkingDesk> modelToDTO)
        {
            _logger = logger;
            _employerWorkingDeskManager = employerWorkingDeskManager;
            _employerWorkingDeskRepository = employerWorkingDeskRepository;
            _modelToDTO = modelToDTO;
        }
        // GET: api/<EmployerWorkingDeskController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmployerWorkingDeskController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployerWorkingDeskController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployerWorkingDeskController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployerWorkingDeskController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
