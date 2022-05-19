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

        public EmployerWarehouseController(ILogger<EmployerWarehouseController> logger,
            IEmployerWarehouseManager EmployerWarehouseManager, 
            IEmployerWarehouseRepository EmployerWarehouseRepository)
        {
            _logger = logger;
            _EmployerWarehouseRepository = EmployerWarehouseRepository;
            _EmployerWarehouseManager = EmployerWarehouseManager;
        }
        // GET: api/<EmployerWarehouseController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployerWarehouse>> GetWarehouse(string id)
        {
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
            var Warehouses = await _EmployerWarehouseRepository.GetToListByUserId(userid);
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
        public async Task<ActionResult<EmployerWarehouse>> PostWarehouse(EmployerWarehouse EmployerWarehouse)
        {
            var model = DTOToModel<EmployerWarehouse, Warehouse>.ConvertToModel(EmployerWarehouse, new());
            var newWarehouse = await _EmployerWarehouseManager.CreateAsync(model);

            //return CreatedAtAction("GetWarehouse", new { id = Warehouse.Id }, Warehouse);
            return CreatedAtAction(nameof(GetWarehouse), new { id = newWarehouse.Id }, newWarehouse);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutWarehouse(string id, EmployerWarehouse EmployerWarehouse)
        {
            var model = DTOToModel<EmployerWarehouse, Warehouse>.ConvertToModel(EmployerWarehouse, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _EmployerWarehouseManager.UpdateAsync(model);
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
