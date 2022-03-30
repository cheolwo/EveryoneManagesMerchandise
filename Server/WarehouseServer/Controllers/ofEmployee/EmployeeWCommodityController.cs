using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployee;
using BusinessView.ofGeneric;
using BusinessView.ofWarehouse.ofEmployee;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehouseServer.Controllers.ofEmployee
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeWCommodityController : ControllerBase
    {
        private readonly ILogger<EmployeeWCommodityController> _logger;
        private readonly IEmployeeWCommodityManager _employeeWCommodityManager;
        private readonly IEmployeeWCommodityRepository _employeeWCommodityRepository;
        private readonly ModelToDTO<WCommodity, EmployeeWCommodity> _modelToDTO;

        public EmployeeWCommodityController(ILogger<EmployeeWCommodityController> logger, IEmployeeWCommodityManager employeeWCommodityManager, IEmployeeWCommodityRepository employeeWCommodityRepository, ModelToDTO<WCommodity, EmployeeWCommodity> modelToDTO)
        {
            _logger = logger;
            _employeeWCommodityManager = employeeWCommodityManager;
            _employeeWCommodityRepository = employeeWCommodityRepository;
            _modelToDTO = modelToDTO;
        }

        // GET: api/<EmployeeWCommodityController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmployeeWCommodityController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployeeWCommodityController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeWCommodityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeWCommodityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
