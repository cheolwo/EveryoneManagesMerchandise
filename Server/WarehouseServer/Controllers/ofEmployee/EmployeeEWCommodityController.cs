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
    public class EmployeeEWCommodityController : ControllerBase
    {
        private readonly ILogger<EmployeeEWCommodityController> _logger;
        private readonly IEmployeeEWCommodityManager _employeeEWCommodityManager;
        private readonly IEmployeeEWCommodityRepository _employeeEWCommodityRepository;
        private readonly ModelToDTO<EWCommodity, EmployeeEWCommodity> _modelToDTO;

        public EmployeeEWCommodityController(ILogger<EmployeeEWCommodityController> logger, IEmployeeEWCommodityManager employeeEWCommodityManager, IEmployeeEWCommodityRepository employeeEWCommodityRepository, ModelToDTO<EWCommodity, EmployeeEWCommodity> modelToDTO)
        {
            _logger = logger;
            _employeeEWCommodityManager = employeeEWCommodityManager;
            _employeeEWCommodityRepository = employeeEWCommodityRepository;
            _modelToDTO = modelToDTO;
        }
        // GET: api/<EmployeeEWCommodityController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmployeeEWCommodityController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployeeEWCommodityController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeEWCommodityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeEWCommodityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
