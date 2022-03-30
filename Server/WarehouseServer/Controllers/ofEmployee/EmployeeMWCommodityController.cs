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
    public class EmployeeMWCommodityController : ControllerBase
    {
        private readonly ILogger<EmployeeMWCommodityController> _logger;
        private readonly IEmployeeMWCommodityManager _employeeMWCommodityManager;
        private readonly IEmployeeMWCommodityRepository _employeeMWCommodityRepository;
        private readonly ModelToDTO<MWCommodity, EmployeeMWCommodity> _modelToDTO;

        public EmployeeMWCommodityController(ILogger<EmployeeMWCommodityController> logger, IEmployeeMWCommodityManager employeeMWCommodityManager, IEmployeeMWCommodityRepository employeeMWCommodityRepository, ModelToDTO<MWCommodity, EmployeeMWCommodity> modelToDTO)
        {
            _logger = logger;
            _employeeMWCommodityManager = employeeMWCommodityManager;
            _employeeMWCommodityRepository = employeeMWCommodityRepository;
            _modelToDTO = modelToDTO;
        }
        // GET: api/<EmployeeMWCommodityController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmployeeMWCommodityController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployeeMWCommodityController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeMWCommodityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeMWCommodityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
