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
    public class EmployerDotBarcodeController : ControllerBase
    {
        private readonly ILogger<EmployerDotBarcodeController> _logger;
        private readonly IEntityManager<DotBarcode> _employerDotBarcodeManager;
        private readonly IEntityDataRepository<DotBarcode> _employerDotBarcodeRepository;
        private readonly ModelToDTO<DotBarcode, EmployerDotBarcode> _modelToDTO;

        public EmployerDotBarcodeController(ILogger<EmployerDotBarcodeController> logger, IEntityManager<DotBarcode> employerDotBarcodeManager, IEntityDataRepository<DotBarcode> employerDotBarcodeRepository, ModelToDTO<DotBarcode, EmployerDotBarcode> modelToDTO)
        {
            _logger = logger;
            _employerDotBarcodeManager = employerDotBarcodeManager;
            _employerDotBarcodeRepository = employerDotBarcodeRepository;
            _modelToDTO = modelToDTO;
        }
        // GET: api/<EmployerDotBarcodeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmployerDotBarcodeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployerDotBarcodeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployerDotBarcodeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployerDotBarcodeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
