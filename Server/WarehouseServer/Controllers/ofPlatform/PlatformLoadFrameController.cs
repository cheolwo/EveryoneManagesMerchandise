using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofWarehouse.ofPlatform;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployee;
using BusinessData.ofWarehouse.ofInterface.ofPlatform;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoadFrameServer.Controllers.ofPlatform
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformLoadFrameController : ControllerBase
    {
        private readonly ILogger<PlatformLoadFrameController> _logger;
        private readonly IPlatformLoadFrameManager _PlatformLoadFrameManager;
        private readonly IPlatformLoadFrameRepository _PlatformLoadFrameRepository;

        public PlatformLoadFrameController(ILogger<PlatformLoadFrameController> logger,
            IPlatformLoadFrameManager PlatformLoadFrameManager, 
            IPlatformLoadFrameRepository PlatformLoadFrameRepository)
        {
            _logger = logger;
            _PlatformLoadFrameRepository = PlatformLoadFrameRepository;
            _PlatformLoadFrameManager = PlatformLoadFrameManager;
        }
        // GET: api/<PlatformLoadFrameController>
        [HttpGet("{id}")]
        public async Task<ActionResult<PlatformLoadFrame>> GetLoadFrame(string id)
        {
            var LoadFrame = await _PlatformLoadFrameRepository.GetByIdAsync(id);

            if (LoadFrame == null)
            {
                return NotFound();
            }
            var GetPlatformLoadFrame = ModelToDTO<LoadFrame, PlatformLoadFrame>.ConvertToDTO(LoadFrame, new PlatformLoadFrame());
            return GetPlatformLoadFrame;
        }

        [HttpPost]
        public async Task<ActionResult<PlatformLoadFrame>> PostLoadFrame(PlatformLoadFrame PlatformLoadFrame)
        {
            var model = DTOToModel<PlatformLoadFrame, LoadFrame>.ConvertToModel(PlatformLoadFrame, new());
            var newLoadFrame = await _PlatformLoadFrameManager.CreateAsync(model);

            //return CreatedAtAction("GetLoadFrame", new { id = LoadFrame.Id }, LoadFrame);
            return CreatedAtAction(nameof(GetLoadFrame), new { id = newLoadFrame.Id }, newLoadFrame);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoadFrame(string id, PlatformLoadFrame PlatformLoadFrame)
        {
            var model = DTOToModel<PlatformLoadFrame, LoadFrame>.ConvertToModel(PlatformLoadFrame, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _PlatformLoadFrameManager.UpdateAsync(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLoadFrame(string id)
        {
            var LoadFrame = await _PlatformLoadFrameRepository.GetByIdAsync(id);
            if (LoadFrame == null)
            {
                return NotFound();
            }
            await _PlatformLoadFrameRepository.DeleteByIdAsync(LoadFrame.Id);

            return NoContent();
        }
    }
}
