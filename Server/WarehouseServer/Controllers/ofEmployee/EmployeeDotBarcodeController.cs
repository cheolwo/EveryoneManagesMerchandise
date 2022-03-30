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
    public class EmployeeDotBarcodeController : ControllerBase
    {
        private readonly ILogger<EmployeeDotBarcodeController> _logger;
        private readonly IEntityManager<DotBarcode> _employeeDotBarcodeManager;
        private readonly IEntityDataRepository<DotBarcode> _employeeDotBarcodeRepository;
        private readonly ModelToDTO<DotBarcode, EmployeeDotBarcode> _modelToDTO;

        public EmployeeDotBarcodeController(ILogger<EmployeeDotBarcodeController> logger, IEntityManager<DotBarcode> employeeDotBarcodeManager, IEntityDataRepository<DotBarcode> employeeDotBarcodeRepository, ModelToDTO<DotBarcode, EmployeeDotBarcode> modelToDTO)
        {
            _logger = logger;
            _employeeDotBarcodeManager = employeeDotBarcodeManager;
            _employeeDotBarcodeRepository = employeeDotBarcodeRepository;
            _modelToDTO = modelToDTO;
        }
        // GET: api/<EmployeeDotBarcodeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmployeeDotBarcodeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployeeDotBarcodeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeDotBarcodeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeDotBarcodeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
