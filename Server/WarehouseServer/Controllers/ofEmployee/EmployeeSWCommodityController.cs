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
    public class EmployeeSWCommodityController : ControllerBase
    {
        private readonly ILogger<EmployeeSWCommodityController> _logger;
        private readonly IEmployeeSWCommodityManager _employeeSWCommodityManager;
        private readonly IEmployeeSWCommodityRepository _employeeSWCommodityRepository;
        private readonly ModelToDTO<SWCommodity, EmployeeSWCommodity> _modelToDTO;

        public EmployeeSWCommodityController(ILogger<EmployeeSWCommodityController> logger, IEmployeeSWCommodityManager employeeSWCommodityManager, IEmployeeSWCommodityRepository employeeSWCommodityRepository, ModelToDTO<SWCommodity, EmployeeSWCommodity> modelToDTO)
        {
            _logger = logger;
            _employeeSWCommodityManager = employeeSWCommodityManager;
            _employeeSWCommodityRepository = employeeSWCommodityRepository;
            _modelToDTO = modelToDTO;
        }
        // GET: api/<EmployeeSWCommodityController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmployeeSWCommodityController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployeeSWCommodityController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeSWCommodityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeSWCommodityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
