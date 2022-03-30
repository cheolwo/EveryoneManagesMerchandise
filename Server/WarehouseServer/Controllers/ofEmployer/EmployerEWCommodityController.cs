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
    public class EmployerEWCommodityController : ControllerBase
    {
        private readonly ILogger<EmployerEWCommodityController> _logger;
        private readonly IEmployerEWCommodityManager _employerEWCommodityManager;
        private readonly IEmployerEWCommodityRepository _employerEWCommodityRepository;
        private readonly ModelToDTO<EWCommodity, EmployerEWCommodity> _modelToDTO;

        public EmployerEWCommodityController(ILogger<EmployerEWCommodityController> logger, IEmployerEWCommodityManager employerEWCommodityManager, IEmployerEWCommodityRepository employerEWCommodityRepository, ModelToDTO<EWCommodity, EmployerEWCommodity> modelToDTO)
        {
            _logger = logger;
            _employerEWCommodityManager = employerEWCommodityManager;
            _employerEWCommodityRepository = employerEWCommodityRepository;
            _modelToDTO = modelToDTO;
        }
        // GET: api/<EmployerEWCommodityController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmployerEWCommodityController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployerEWCommodityController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployerEWCommodityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployerEWCommodityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
