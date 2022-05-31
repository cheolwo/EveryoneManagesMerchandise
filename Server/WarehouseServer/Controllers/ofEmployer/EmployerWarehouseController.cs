using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployer;
using BusinessData.ofWarehouse.ofInterface.ofEmployer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehouseServer.Controllers.ofEmployer
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerWarehouseController : ControllerBase
    {
        private readonly ILogger<EmployerWarehouseController> _logger;
        private readonly IEmployerWarehouseManager _EmployerWarehouseManager;
        private readonly IEmployerWarehouseRepository _EmployerWarehouseRepository;
        private readonly IConfiguration _configuration;

        public EmployerWarehouseController(ILogger<EmployerWarehouseController> logger,
            IEmployerWarehouseManager EmployerWarehouseManager, 
            IEmployerWarehouseRepository EmployerWarehouseRepository,
            IConfiguration configuration)
        {
            _configuration = configuration;
            _logger = logger;
            _EmployerWarehouseRepository = EmployerWarehouseRepository;
            _EmployerWarehouseManager = EmployerWarehouseManager;
        }
        // GET: api/<EmployerWarehouseController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployerWarehouse>> GetWarehouse(string id)
        {
            _logger.LogInformation("Access" + nameof(EmployerWarehouseController.GetWarehouse));
            var Warehouse = await _EmployerWarehouseRepository.GetByIdAsync(id);

            if (Warehouse == null)
            {
                return NotFound();
            }
            var GetEmployerWarehouse = ModelToDTO<Warehouse, EmployerWarehouse>.ConvertToDTO(Warehouse, new EmployerWarehouse());
            return GetEmployerWarehouse;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployerWarehouse>>> Gets()
        {
            _logger.LogInformation("Access" + nameof(EmployerWarehouseController.Gets));
            var Warehouses = await _EmployerWarehouseRepository.GetToListAsync();
            if (Warehouses.Count == 0)
            {
                return new List<EmployerWarehouse>();
            }
            List<EmployerWarehouse> EmployerWarehouses = new List<EmployerWarehouse>();
            foreach (var Warehouse in Warehouses)
            {
                EmployerWarehouses.Add(ModelToDTO<Warehouse, EmployerWarehouse>.ConvertToDTO(Warehouse, new EmployerWarehouse()));
            }
            return EmployerWarehouses;
        }
        [HttpGet("User")]
        public async Task<ActionResult<IEnumerable<EmployerWarehouse>>> GetsAsyncByUserId(string userid)
        {
            _logger.LogInformation("Access" + nameof(EmployerWarehouseController.GetsAsyncByUserId));
            var Warehouses = await _EmployerWarehouseRepository.GetToListByUserIdAsync(userid);
            if (Warehouses.Count == 0)
            {
                return new List<EmployerWarehouse>();
            }
            List<EmployerWarehouse> EmployerWarehouses = new List<EmployerWarehouse>();
            foreach (var Warehouse in Warehouses)
            {
                EmployerWarehouses.Add(ModelToDTO<Warehouse, EmployerWarehouse>.ConvertToDTO(Warehouse, new EmployerWarehouse()));
            }
            return EmployerWarehouses;
        }

        [HttpPost]
        public async Task<ActionResult<EmployerWarehouse>> PostWarehouse([FromBody]EmployerWarehouse EmployerWarehouse)
        {
            
            _logger.LogInformation(nameof(EmployerWarehouseController.PostWarehouse));
            var model = DTOToModel<EmployerWarehouse, Warehouse>.ConvertToModel(EmployerWarehouse, new());
            var newWarehouse = await _EmployerWarehouseManager.CreateAsync(model);
            var dto = ModelToDTO<Warehouse, EmployerWarehouse>.ConvertToDTO(newWarehouse, new());
            //return CreatedAtAction("GetWarehouse", new { id = Warehouse.Id }, Warehouse);
            return CreatedAtAction(nameof(GetWarehouse), new { id = newWarehouse.Id }, dto);
        }

        [HttpPut]
        public async Task<IActionResult> PutWarehouse([FromBody] EmployerWarehouse EmployerWarehouse)
        {
            _logger.LogInformation("Access" + nameof(EmployerWarehouseController.PutWarehouse));
            if (EmployerWarehouse == null)
            {
                return BadRequest();
            }
            try
            {
                var model = DTOToModel<EmployerWarehouse, Warehouse>.ConvertToModel(EmployerWarehouse, new());
                await _EmployerWarehouseManager.UpdateAsync(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteWarehouse(string id)
        {
            _logger.LogInformation("Access" + nameof(EmployerWarehouseController.DeleteWarehouse));
            var Warehouse = await _EmployerWarehouseRepository.GetByIdAsync(id);
            if (Warehouse == null)
            {
                return NotFound();
            }
            await _EmployerWarehouseRepository.DeleteByIdAsync(Warehouse.Id);

            return NoContent();
        }
    }
}
