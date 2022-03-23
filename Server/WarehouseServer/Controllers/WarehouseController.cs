using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofWarehouse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WarehouseServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly IEntityManager<Warehouse> _EntityManager;
        private readonly IEntityDataRepository<Warehouse> _EntityDataRepository;
        private readonly IWarehouseManager _WarehouseManager;
        private readonly IWarehouseRepository _WarehouseRepository;
        public WarehouseController(IEntityManager<Warehouse> entityManager,
            IEntityDataRepository<Warehouse> entityDataRepository, 
            IWarehouseManager warehouseManager,
            IWarehouseRepository warehouseRepository)
        {
            _EntityManager = entityManager;
            _EntityDataRepository = entityDataRepository;
            _WarehouseManager = warehouseManager;
            _WarehouseRepository = warehouseRepository;
        }
        // GET: api/Warehouse
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Warehouse>>> GetWarehouses()
        {
            return await _WarehouseRepository.GetToListAsync();
        }
        // GET: api/Warehouses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Warehouse>> GetWarehouse(string id)
        {
            var warehouse = await _WarehouseRepository.GetByIdAsync(id);

            if (warehouse == null)
            {
                return NotFound();
            }

            return warehouse;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateWarehouse(string id, Warehouse warehouse)
        {
            if (id != warehouse.Id)
            {
                return BadRequest();
            }

            var Warehouse = await _WarehouseRepository.GetByIdAsync(id);
            if (Warehouse == null)
            {
                return NotFound();
            }

            warehouse.Name = warehouse.Name;
             await _WarehouseRepository.UpdateAsync(warehouse);


            return NoContent();
        }
        // POST: api/Warehouses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Warehouse>> CreateWarehouse(Warehouse Warehouse)
        {
            var warehouse = new Warehouse
            {
                Name = Warehouse.Name
            };

            var newWarehouse = await _WarehouseManager.CreateAsync(warehouse);

            return newWarehouse;
        }

        // DELETE: api/Warehouses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWarehouse(string id)
        {
            var Warehouse = await _WarehouseManager.GetByIdAsync(id);

            if (Warehouse == null)
            {
                return NotFound();
            }

            await _WarehouseManager.DeleteByIdAsync(id);

            return NoContent();
        }

        // ViewModel 에서 Model로 바뀌는 개념이구나.
        //private static Warehouse ItemToDTO(Warehouse Warehouse) =>
        //    new Warehouse
        //    {
        //        Id = Warehouse.Id,
        //        Name = Warehouse.Name,
        //        IsComplete = Warehouse.IsComplete
        //    };

    }
}
