using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofPlatform;
using BusinessData.ofWarehouse.ofInterface.ofPlatform;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehouseServer.Controllers.ofPlatform
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformWarehouseController : ControllerBase
    {
        private readonly ILogger<PlatformWarehouseController> _logger;
        private readonly IPlatformWarehouseManager _PlatformWarehouseManager;
        private readonly IPlatformWarehouseRepository _PlatformWarehouseRepository;

        public PlatformWarehouseController(ILogger<PlatformWarehouseController> logger,
            IPlatformWarehouseManager PlatformWarehouseManager, 
            IPlatformWarehouseRepository PlatformWarehouseRepository)
        {
            _logger = logger;
            _PlatformWarehouseRepository = PlatformWarehouseRepository;
            _PlatformWarehouseManager = PlatformWarehouseManager;
        }
        // GET: api/<PlatformWarehouseController>
        [HttpGet("{id}")]
        public async Task<ActionResult<PlatformWarehouse>> GetWarehouse(string id)
        {
            var Warehouse = await _PlatformWarehouseRepository.GetByIdAsync(id);

            if (Warehouse == null)
            {
                return NotFound();
            }
            var GetPlatformWarehouse = ModelToDTO<Warehouse, PlatformWarehouse>.ConvertToDTO(Warehouse, new PlatformWarehouse());
            return GetPlatformWarehouse;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlatformWarehouse>>> Gets()
        {
            var Warehouses = await _PlatformWarehouseRepository.GetToListAsync();
            if (Warehouses.Count == 0)
            {
                return new List<PlatformWarehouse>();
            }
            List<PlatformWarehouse> PlatformWarehouses = new List<PlatformWarehouse>();
            foreach (var Warehouse in Warehouses)
            {
                PlatformWarehouses.Add(ModelToDTO<Warehouse, PlatformWarehouse>.ConvertToDTO(Warehouse, new PlatformWarehouse()));
            }
            return PlatformWarehouses;
        }
        [HttpGet("User")]
        public async Task<ActionResult<IEnumerable<PlatformWarehouse>>> GetsAsyncByUserId(string userid)
        {
            var Warehouses = await _PlatformWarehouseRepository.GetToListByUserIdAsync(userid);
            if (Warehouses.Count == 0)
            {
                return new List<PlatformWarehouse>();
            }
            List<PlatformWarehouse> PlatformWarehouses = new List<PlatformWarehouse>();
            foreach (var Warehouse in Warehouses)
            {
                PlatformWarehouses.Add(ModelToDTO<Warehouse, PlatformWarehouse>.ConvertToDTO(Warehouse, new PlatformWarehouse()));
            }
            return PlatformWarehouses;
        }

        [HttpPost]
        public async Task<ActionResult<PlatformWarehouse>> PostWarehouse(PlatformWarehouse PlatformWarehouse)
        {
            var model = DTOToModel<PlatformWarehouse, Warehouse>.ConvertToModel(PlatformWarehouse, new());
            var newWarehouse = await _PlatformWarehouseManager.CreateAsync(model);

            //return CreatedAtAction("GetWarehouse", new { id = Warehouse.Id }, Warehouse);
            return CreatedAtAction(nameof(GetWarehouse), new { id = newWarehouse.Id }, newWarehouse);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutWarehouse(string id, PlatformWarehouse PlatformWarehouse)
        {
            var model = DTOToModel<PlatformWarehouse, Warehouse>.ConvertToModel(PlatformWarehouse, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _PlatformWarehouseManager.UpdateAsync(model);
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
            var Warehouse = await _PlatformWarehouseRepository.GetByIdAsync(id);
            if (Warehouse == null)
            {
                return NotFound();
            }
            await _PlatformWarehouseRepository.DeleteByIdAsync(Warehouse.Id);

            return NoContent();
        }
    }
}
