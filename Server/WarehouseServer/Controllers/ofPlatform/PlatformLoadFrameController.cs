using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofPlatform;
using BusinessData.ofWarehouse.ofInterface.ofPlatform;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployee;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehouseServer.Controllers.ofPlatform
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
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlatformLoadFrame>>> Gets()
        {
            var LoadFrames = await _PlatformLoadFrameRepository.GetToListAsync();
            if (LoadFrames.Count == 0)
            {
                return new List<PlatformLoadFrame>();
            }
            List<PlatformLoadFrame> PlatformLoadFrames = new List<PlatformLoadFrame>();
            foreach (var LoadFrame in LoadFrames)
            {
                PlatformLoadFrames.Add(ModelToDTO<LoadFrame, PlatformLoadFrame>.ConvertToDTO(LoadFrame, new PlatformLoadFrame()));
            }
            return PlatformLoadFrames;
        }
        [HttpGet("User")]
        public async Task<ActionResult<IEnumerable<PlatformLoadFrame>>> GetsAsyncByUserId(string userid)
        {
            var LoadFrames = await _PlatformLoadFrameRepository.GetToListByUserIdAsync(userid);
            if (LoadFrames.Count == 0)
            {
                return new List<PlatformLoadFrame>();
            }
            List<PlatformLoadFrame> PlatformLoadFrames = new List<PlatformLoadFrame>();
            foreach (var LoadFrame in LoadFrames)
            {
                PlatformLoadFrames.Add(ModelToDTO<LoadFrame, PlatformLoadFrame>.ConvertToDTO(LoadFrame, new PlatformLoadFrame()));
            }
            return PlatformLoadFrames;
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
