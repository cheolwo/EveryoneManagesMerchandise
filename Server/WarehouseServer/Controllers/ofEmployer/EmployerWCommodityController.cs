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
    public class EmployerWCommodityController : ControllerBase
    {
        private readonly ILogger<EmployerWCommodityController> _logger;
        private readonly IEmployerWCommodityManager _employerWCommodityManager;
        private readonly IEmployerWCommodityRepository _employerWCommodityRepository;
        private readonly ModelToDTO<WCommodity, EmployerWCommodity> _modelToDTO;

        public EmployerWCommodityController(ILogger<EmployerWCommodityController> logger, IEmployerWCommodityManager employerWCommodityManager, IEmployerWCommodityRepository employerWCommodityRepository, ModelToDTO<WCommodity, EmployerWCommodity> modelToDTO)
        {
            _logger = logger;
            _employerWCommodityManager = employerWCommodityManager;
            _employerWCommodityRepository = employerWCommodityRepository;
            _modelToDTO = modelToDTO;
        }
        // GET: api/<EmployerWCommodityController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmployerWCommodityController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployerWCommodityController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployerWCommodityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployerWCommodityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
