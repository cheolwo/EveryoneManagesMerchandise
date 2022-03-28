using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofRepository;
using BusinessLogic.ofManager.ofWarehouse;
using Microsoft.AspNetCore.Mvc;

namespace WarehouseServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly IWarehouseManager _WarehouseManager;
        private readonly IWarehouseRepository _WarehouseRepository;
        public WarehouseController(
            IWarehouseManager WarehouseManager,
            IWarehouseRepository WarehuoseRepository
          )
        {
            _WarehouseManager = WarehouseManager;
            _WarehouseRepository = WarehuoseRepository;               
        }
        // GET: api/Warehouse
        // 데이터를 받아오면 싱글톤으로 기억을 한 다음에 다음 Get을 할 때 이용할 수 있도록 한다.
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Warehouse>>> GetWarehouses()
        {
            return  await _WarehouseRepository.GetToListAsync();
        }
        // GET: api/Warehouses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Warehouse>> GetWarehouse(string id)
        {
            var Warehouse = await _WarehouseRepository.GetByIdAsync(id);

            if (Warehouse == null)
            {
                return NotFound();
            }

            return Warehouse;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateWarehouse(string id, Warehouse warehouse)
        {
            // 역직렬화 코드
            if (id != warehouse.Id)
            {
                return BadRequest();
            }

            var Warehouse = await _WarehouseRepository.GetByIdAsync(id);
            if (Warehouse == null)
            {
                return NotFound();
            }

            Warehouse.Name = Warehouse.Name;
             await _WarehouseRepository.UpdateAsync(Warehouse);


            return NoContent();
        }
        // POST: api/Warehouses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Warehouse>> CreateWarehouse(Warehouse warehouse)
        {

            var Warehouse = new Warehouse
            {
                Name = warehouse.Name
            };

            var newWarehouse = await _WarehouseManager.CreateAsync(Warehouse);

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
