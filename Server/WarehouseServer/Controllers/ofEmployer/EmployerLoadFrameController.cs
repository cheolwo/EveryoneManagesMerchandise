using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofManager.ofGeneric;
using BusinessView.ofGeneric;
using BusinessView.ofWarehouse.ofEmployer;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehouseServer.Controllers.ofEmployer
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerLoadFrameController : ControllerBase
    {
        private readonly ILogger<EmployerLoadFrameController> _logger;
        private readonly IEntityManager<LoadFrame> _employerLoadFrameManager;
        private readonly IEntityDataRepository<LoadFrame> _employerLoadFrameRepository;
        private readonly ModelToDTO<LoadFrame, EmployerLoadFrame> _modelToDTO;

        public EmployerLoadFrameController(ILogger<EmployerLoadFrameController> logger, IEntityManager<LoadFrame> employerLoadFrameManager, IEntityDataRepository<LoadFrame> employerLoadFrameRepository, ModelToDTO<LoadFrame, EmployerLoadFrame> modelToDTO)
        {
            _logger = logger;
            _employerLoadFrameManager = employerLoadFrameManager;
            _employerLoadFrameRepository = employerLoadFrameRepository;
            _modelToDTO = modelToDTO;
        }
        // GET: api/<EmployerLoadFrameController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmployerLoadFrameController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployerLoadFrameController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployerLoadFrameController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployerLoadFrameController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
