using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployer;
using BusinessView.ofGeneric;
using BusinessView.ofWarehouse.ofEmployer;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehouseServer.Controllers.ofEmployer
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerMWCommodityController : ControllerBase
    {
        private readonly ILogger<EmployerMWCommodityController> _logger;
        private readonly IEmployerMWCommodityManager _employerMWCommodityManager;
        private readonly IEmployerMWCommodityRepository _employerMWCommodityRepository;

        public EmployerMWCommodityController(ILogger<EmployerMWCommodityController> logger, 
            IEmployerMWCommodityManager employerMWCommodityManager,
            IEmployerMWCommodityRepository employerMWCommodityRepository)
        {
            _logger = logger;
            _employerMWCommodityManager = employerMWCommodityManager;
            _employerMWCommodityRepository = employerMWCommodityRepository;
        }
        // GET: api/<EmployerMWCommodityController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmployerMWCommodityController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployerMWCommodityController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployerMWCommodityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployerMWCommodityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
