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
    public class EmployerSWCommodityController : ControllerBase
    {
        private readonly ILogger<EmployerSWCommodityController> _logger;
        private readonly IEmployerSWCommodityManager _employerSWCommodityManager;
        private readonly IEmployerSWCommodityRepository _employerSWCommodityRepository;
        private readonly ModelToDTO<SWCommodity, EmployerSWCommodity> _modelToDTO;

        public EmployerSWCommodityController(ILogger<EmployerSWCommodityController> logger, IEmployerSWCommodityManager employerSWCommodityManager, IEmployerSWCommodityRepository employerSWCommodityRepository, ModelToDTO<SWCommodity, EmployerSWCommodity> modelToDTO)
        {
            _logger = logger;
            _employerSWCommodityManager = employerSWCommodityManager;
            _employerSWCommodityRepository = employerSWCommodityRepository;
            _modelToDTO = modelToDTO;
        }
        // GET: api/<EmployerSWCommodityController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmployerSWCommodityController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployerSWCommodityController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployerSWCommodityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployerSWCommodityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
