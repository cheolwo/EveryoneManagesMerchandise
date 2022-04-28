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
    public class EmployerDividedTagController : ControllerBase
    {
        private readonly ILogger<EmployerDividedTagController> _logger;
        private readonly IEntityManager<DividedTag> _employerDividedTagManager;
        private readonly IEntityDataRepository<DividedTag> _employerDividedTagRepository;
        private readonly ModelToDTO<DividedTag, EmployerDividedTag> _modelToDTO;

        public EmployerDividedTagController(ILogger<EmployerDividedTagController> logger, IEntityManager<DividedTag> employerDividedTagManager, IEntityDataRepository<DividedTag> employerDividedTagRepository, ModelToDTO<DividedTag, EmployerDividedTag> modelToDTO)
        {
            _logger = logger;
            _employerDividedTagManager = employerDividedTagManager;
            _employerDividedTagRepository = employerDividedTagRepository;
            _modelToDTO = modelToDTO;
        }
        //// GET: api/<EmployerDividedController>
        //[HttpGet("{id}")]
        //public async Task<ActionResult<EmployerDividedTag>> GetTodoItem(long id)
        //{
        //    throw new NotImplementedException();
        //}

        // GET api/<EmployerDividedController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployerDividedController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployerDividedController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployerDividedController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
