using BusinessData.ofHumanResource.ofInterface.ofEmployee;
using BusinessData.ofJournal.ofInterface.ofEmployee;
using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofHumanResouce.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofJournal.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployee;
using BusinessView.ofGeneric;
using BusinessView.ofWarehouse.ofEmployee;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
// Controller는 Application 과 DTO로 I/O 한다.

namespace WarehouseServer.Controllers.ofEmployee
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeWarehouseController : ControllerBase
    {
        // GET: api/<EmployeeWarehouseController>
        private readonly ILogger<EmployeeWarehouseController> _logger;
        private readonly IEmployeeWarehouseManager _employeeWarehouseManager;
        private readonly IEmployeeJournalCenterManager _employeeJournalCenterManager;
        private readonly IEmployeeHRCenterManager _employeeHRCenterManager;

        private readonly IEmployeeWarehouseRepository _employeeWarehouseRepository;
        private readonly IEmployeeHRCenterRepository _employeeHRCenterRepository;
        private readonly IEmployeeJournalCenterRepository _employeeJounralCenterRepository;

        private readonly ModelToDTO<Warehouse, EmployeeWarehouse> _modelToDTO;

        public EmployeeWarehouseController(ILogger<EmployeeWarehouseController> logger, IEmployeeWarehouseManager employeeWarehouseManager, IEmployeeJournalCenterManager employeeJournalCenterManager, IEmployeeHRCenterManager employeeHRCenterManager, IEmployeeWarehouseRepository employeeWarehouseRepository, IEmployeeHRCenterRepository employeeHRCenterRepository, IEmployeeJournalCenterRepository employeeJounralCenterRepository, ModelToDTO<Warehouse, EmployeeWarehouse> modelToDTO)
        {
            _logger = logger;
            _employeeWarehouseManager = employeeWarehouseManager;
            _employeeJournalCenterManager = employeeJournalCenterManager;
            _employeeHRCenterManager = employeeHRCenterManager;
            _employeeWarehouseRepository = employeeWarehouseRepository;
            _employeeHRCenterRepository = employeeHRCenterRepository;
            _employeeJounralCenterRepository = employeeJounralCenterRepository;
            _modelToDTO = modelToDTO;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmployeeWarehouseController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployeeWarehouseController>
        [HttpPost]
        public void Post([FromBody] EmployeeWarehouse value)
        {
        }

        // PUT api/<EmployeeWarehouseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeWarehouseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
