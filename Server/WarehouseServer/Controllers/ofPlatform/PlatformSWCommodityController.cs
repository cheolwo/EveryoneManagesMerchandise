using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployee;
using BusinessData.ofWarehouse.ofInterface.ofPlatform;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofPlatform;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehouseServer.Controllers.ofPlatform
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformSWCommodityController : ControllerBase
    {
        private readonly ILogger<PlatformSWCommodityController> _logger;
        private readonly IPlatformSWCommodityManager _PlatformSWCommodityManager;
        private readonly IPlatformSWCommodityRepository _PlatformSWCommodityRepository;

        public PlatformSWCommodityController(ILogger<PlatformSWCommodityController> logger,
            IPlatformSWCommodityManager PlatformSWCommodityManager, 
            IPlatformSWCommodityRepository PlatformSWCommodityRepository)
        {
            _logger = logger;
            _PlatformSWCommodityRepository = PlatformSWCommodityRepository;
            _PlatformSWCommodityManager = PlatformSWCommodityManager;
        }
        // GET: api/<PlatformSWCommodityController>
        [HttpGet("{id}")]
        public async Task<ActionResult<PlatformSWCommodity>> GetSWCommodity(string id)
        {
            var SWCommodity = await _PlatformSWCommodityRepository.GetByIdAsync(id);

            if (SWCommodity == null)
            {
                return NotFound();
            }
            var GetPlatformSWCommodity = ModelToDTO<SWCommodity, PlatformSWCommodity>.ConvertToDTO(SWCommodity, new PlatformSWCommodity());
            return GetPlatformSWCommodity;
        }

        [HttpPost]
        public async Task<ActionResult<PlatformSWCommodity>> PostSWCommodity(PlatformSWCommodity PlatformSWCommodity)
        {
            var model = DTOToModel<PlatformSWCommodity, SWCommodity>.ConvertToModel(PlatformSWCommodity, new());
            var newSWCommodity = await _PlatformSWCommodityManager.CreateAsync(model);

            //return CreatedAtAction("GetSWCommodity", new { id = SWCommodity.Id }, SWCommodity);
            return CreatedAtAction(nameof(GetSWCommodity), new { id = newSWCommodity.Id }, newSWCommodity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSWCommodity(string id, PlatformSWCommodity PlatformSWCommodity)
        {
            var model = DTOToModel<PlatformSWCommodity, SWCommodity>.ConvertToModel(PlatformSWCommodity, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _PlatformSWCommodityManager.UpdateAsync(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSWCommodity(string id)
        {
            var SWCommodity = await _PlatformSWCommodityRepository.GetByIdAsync(id);
            if (SWCommodity == null)
            {
                return NotFound();
            }
            await _PlatformSWCommodityRepository.DeleteByIdAsync(SWCommodity.Id);

            return NoContent();
        }
    }
}
