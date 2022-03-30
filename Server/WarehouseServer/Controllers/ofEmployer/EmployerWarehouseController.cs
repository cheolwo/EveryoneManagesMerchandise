using BusinessData.ofHumanResource.ofInterface.ofEmployer;
using BusinessData.ofJournal.ofInterface.ofEmployer;
using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofHumanResouce.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofJournal.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployer;
using BusinessView.ofGeneric;
using BusinessView.ofWarehouse.ofEmployer;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehouseServer.Controllers.ofEmployer
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerWarehouseController : ControllerBase
    {
        private readonly ILogger<EmployerWarehouseController> _logger;
        private readonly IEmployerWarehouseManager _employerWarehouseManager;
        private readonly IEmployerJournalCenterManager _employerJournalCenterManager;
        private readonly IEmployerHRCenterManager _employerHRCenterManager;

        private readonly IEmployerWarehouseRepository _employerWarehouseRepository;
        private readonly IEmployerHRCenterRepository _employerHRCenterRepository;
        private readonly IEmployerJournalCenterRepository _employerJounralCenterRepository;

        private readonly ModelToDTO<Warehouse, EmployerWarehouse> _modelToDTO;

        public EmployerWarehouseController(ILogger<EmployerWarehouseController> logger, IEmployerWarehouseManager employerWarehouseManager, IEmployerJournalCenterManager employerJournalCenterManager, IEmployerHRCenterManager employerHRCenterManager, IEmployerWarehouseRepository employerWarehouseRepository, IEmployerHRCenterRepository employerHRCenterRepository, IEmployerJournalCenterRepository employerJounralCenterRepository, ModelToDTO<Warehouse, EmployerWarehouse> modelToDTO)
        {
            _logger = logger;
            _employerWarehouseManager = employerWarehouseManager;
            _employerJournalCenterManager = employerJournalCenterManager;
            _employerHRCenterManager = employerHRCenterManager;
            _employerWarehouseRepository = employerWarehouseRepository;
            _employerHRCenterRepository = employerHRCenterRepository;
            _employerJounralCenterRepository = employerJounralCenterRepository;
            _modelToDTO = modelToDTO;
        }
        // GET: api/<EmployerWarehouseController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmployerWarehouseController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployerWarehouseController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployerWarehouseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployerWarehouseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
