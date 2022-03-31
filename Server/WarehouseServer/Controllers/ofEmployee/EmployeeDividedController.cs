using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofManager.ofGeneric;
using BusinessView.ofGeneric;
using BusinessView.ofWarehouse.ofEmployee;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehouseServer.Controllers.ofEmployee
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDividedTagController : ControllerBase
    {
        private readonly ILogger<EmployeeDividedTagController> _logger;
        private readonly IEntityManager<DividedTag> _employeeDividedTagManager;
        private readonly IEntityDataRepository<DividedTag> _employeeDividedTagRepository;
        private readonly ModelToDTO<DividedTag, EmployeeDividedTag> _modelToDTO;

        public EmployeeDividedTagController(ILogger<EmployeeDividedTagController> logger, IEntityManager<DividedTag> employeeDividedTagManager, IEntityDataRepository<DividedTag> employeeDividedTagRepository, ModelToDTO<DividedTag, EmployeeDividedTag> modelToDTO)
        {
            _logger = logger;
            _employeeDividedTagManager = employeeDividedTagManager;
            _employeeDividedTagRepository = employeeDividedTagRepository;
            _modelToDTO = modelToDTO;
        }
        // GET: api/<EmployeeDividedController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeDividedTag>>> Get()
        {
            // Reposirory 를 3등분 해야됨.
            return await _employeeDividedTagRepository.GetToListAsync();
        }

        // GET api/<EmployeeDividedController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployeeDividedController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeDividedController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeDividedController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
