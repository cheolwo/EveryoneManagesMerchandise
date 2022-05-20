using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployee;
using BusinessData.ofWarehouse.ofInterface.ofEmployee;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehouseServer.Controllers.ofEmployee
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeWarehouseController : ControllerBase
    {
        private readonly ILogger<EmployeeWarehouseController> _logger;
        private readonly IEmployeeWarehouseManager _EmployeeWarehouseManager;
        private readonly IEmployeeWarehouseRepository _EmployeeWarehouseRepository;

        public EmployeeWarehouseController(ILogger<EmployeeWarehouseController> logger,
            IEmployeeWarehouseManager EmployeeWarehouseManager, 
            IEmployeeWarehouseRepository EmployeeWarehouseRepository)
        {
            _logger = logger;
            _EmployeeWarehouseRepository = EmployeeWarehouseRepository;
            _EmployeeWarehouseManager = EmployeeWarehouseManager;
        }
        // GET: api/<EmployeeWarehouseController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeWarehouse>> GetWarehouse(string id)
        {
            var Warehouse = await _EmployeeWarehouseRepository.GetByIdAsync(id);

            if (Warehouse == null)
            {
                return NotFound();
            }
            var GetEmployeeWarehouse = ModelToDTO<Warehouse, EmployeeWarehouse>.ConvertToDTO(Warehouse, new EmployeeWarehouse());
            return GetEmployeeWarehouse;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeWarehouse>>> Gets()
        {
            var Warehouses = await _EmployeeWarehouseRepository.GetToListAsync();
            if (Warehouses.Count == 0)
            {
                return new List<EmployeeWarehouse>();
            }
            List<EmployeeWarehouse> EmployeeWarehouses = new List<EmployeeWarehouse>();
            foreach (var Warehouse in Warehouses)
            {
                EmployeeWarehouses.Add(ModelToDTO<Warehouse, EmployeeWarehouse>.ConvertToDTO(Warehouse, new EmployeeWarehouse()));
            }
            return EmployeeWarehouses;
        }
        [HttpGet("User")]
        public async Task<ActionResult<IEnumerable<EmployeeWarehouse>>> GetsAsyncByUserId(string userid)
        {
            var Warehouses = await _EmployeeWarehouseRepository.GetToListByUserId(userid);
            if (Warehouses.Count == 0)
            {
                return new List<EmployeeWarehouse>();
            }
            List<EmployeeWarehouse> EmployeeWarehouses = new List<EmployeeWarehouse>();
            foreach (var Warehouse in Warehouses)
            {
                EmployeeWarehouses.Add(ModelToDTO<Warehouse, EmployeeWarehouse>.ConvertToDTO(Warehouse, new EmployeeWarehouse()));
            }
            return EmployeeWarehouses;
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeWarehouse>> PostWarehouse(EmployeeWarehouse EmployeeWarehouse)
        {
            var model = DTOToModel<EmployeeWarehouse, Warehouse>.ConvertToModel(EmployeeWarehouse, new());
            var newWarehouse = await _EmployeeWarehouseManager.CreateAsync(model);

            //return CreatedAtAction("GetWarehouse", new { id = Warehouse.Id }, Warehouse);
            return CreatedAtAction(nameof(GetWarehouse), new { id = newWarehouse.Id }, newWarehouse);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutWarehouse(string id, EmployeeWarehouse EmployeeWarehouse)
        {
            var model = DTOToModel<EmployeeWarehouse, Warehouse>.ConvertToModel(EmployeeWarehouse, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _EmployeeWarehouseManager.UpdateAsync(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWarehouse(string id)
        {
            var Warehouse = await _EmployeeWarehouseRepository.GetByIdAsync(id);
            if (Warehouse == null)
            {
                return NotFound();
            }
            await _EmployeeWarehouseRepository.DeleteByIdAsync(Warehouse.Id);

            return NoContent();
        }
    }
}
