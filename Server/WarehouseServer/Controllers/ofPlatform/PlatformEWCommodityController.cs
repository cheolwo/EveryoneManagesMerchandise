using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofWarehouse.ofPlatform;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployee;
using BusinessData.ofWarehouse.ofInterface.ofPlatform;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofPlatform;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EWCommodityServer.Controllers.ofPlatform
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformEWCommodityController : ControllerBase
    {
        private readonly ILogger<PlatformEWCommodityController> _logger;
        private readonly IPlatformEWCommodityManager _PlatformEWCommodityManager;
        private readonly IPlatformEWCommodityRepository _PlatformEWCommodityRepository;

        public PlatformEWCommodityController(ILogger<PlatformEWCommodityController> logger,
            IPlatformEWCommodityManager PlatformEWCommodityManager, 
            IPlatformEWCommodityRepository PlatformEWCommodityRepository)
        {
            _logger = logger;
            _PlatformEWCommodityRepository = PlatformEWCommodityRepository;
            _PlatformEWCommodityManager = PlatformEWCommodityManager;
        }
        // GET: api/<PlatformEWCommodityController>
        [HttpGet("{id}")]
        public async Task<ActionResult<PlatformEWCommodity>> GetEWCommodity(string id)
        {
            var EWCommodity = await _PlatformEWCommodityRepository.GetByIdAsync(id);

            if (EWCommodity == null)
            {
                return NotFound();
            }
            var GetPlatformEWCommodity = ModelToDTO<EWCommodity, PlatformEWCommodity>.ConvertToDTO(EWCommodity, new PlatformEWCommodity());
            return GetPlatformEWCommodity;
        }

        [HttpPost]
        public async Task<ActionResult<PlatformEWCommodity>> PostEWCommodity(PlatformEWCommodity PlatformEWCommodity)
        {
            var model = DTOToModel<PlatformEWCommodity, EWCommodity>.ConvertToModel(PlatformEWCommodity, new());
            var newEWCommodity = await _PlatformEWCommodityManager.CreateAsync(model);

            //return CreatedAtAction("GetEWCommodity", new { id = EWCommodity.Id }, EWCommodity);
            return CreatedAtAction(nameof(GetEWCommodity), new { id = newEWCommodity.Id }, newEWCommodity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEWCommodity(string id, PlatformEWCommodity PlatformEWCommodity)
        {
            var model = DTOToModel<PlatformEWCommodity, EWCommodity>.ConvertToModel(PlatformEWCommodity, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _PlatformEWCommodityManager.UpdateAsync(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEWCommodity(string id)
        {
            var EWCommodity = await _PlatformEWCommodityRepository.GetByIdAsync(id);
            if (EWCommodity == null)
            {
                return NotFound();
            }
            await _PlatformEWCommodityRepository.DeleteByIdAsync(EWCommodity.Id);

            return NoContent();
        }
    }
}
