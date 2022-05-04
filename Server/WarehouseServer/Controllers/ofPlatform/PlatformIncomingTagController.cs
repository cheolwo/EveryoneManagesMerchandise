using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployee;
using BusinessData.ofWarehouse.ofInterface.ofPlatform;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IncomingTagServer.Controllers.ofPlatform
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformIncomingTagController : ControllerBase
    {
        private readonly ILogger<PlatformIncomingTagController> _logger;
        private readonly IPlatformIncomingTagManager _PlatformIncomingTagManager;
        private readonly IPlatformIncomingTagRepository _PlatformIncomingTagRepository;

        public PlatformIncomingTagController(ILogger<PlatformIncomingTagController> logger,
            IPlatformIncomingTagManager PlatformIncomingTagManager, 
            IPlatformIncomingTagRepository PlatformIncomingTagRepository)
        {
            _logger = logger;
            _PlatformIncomingTagRepository = PlatformIncomingTagRepository;
            _PlatformIncomingTagManager = PlatformIncomingTagManager;
        }
        // GET: api/<PlatformIncomingTagController>
        [HttpGet("{id}")]
        public async Task<ActionResult<PlatformIncomingTag>> GetIncomingTag(string id)
        {
            var IncomingTag = await _PlatformIncomingTagRepository.GetByIdAsync(id);

            if (IncomingTag == null)
            {
                return NotFound();
            }
            var GetPlatformIncomingTag = ModelToDTO<IncomingTag, PlatformIncomingTag>.ConvertToDTO(IncomingTag, new PlatformIncomingTag());
            return GetPlatformIncomingTag;
        }

        [HttpPost]
        public async Task<ActionResult<PlatformIncomingTag>> PostIncomingTag(PlatformIncomingTag PlatformIncomingTag)
        {
            var model = DTOToModel<PlatformIncomingTag, IncomingTag>.ConvertToModel(PlatformIncomingTag, new());
            var newIncomingTag = await _PlatformIncomingTagManager.CreateAsync(model);

            //return CreatedAtAction("GetIncomingTag", new { id = IncomingTag.Id }, IncomingTag);
            return CreatedAtAction(nameof(GetIncomingTag), new { id = newIncomingTag.Id }, newIncomingTag);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutIncomingTag(string id, PlatformIncomingTag PlatformIncomingTag)
        {
            var model = DTOToModel<PlatformIncomingTag, IncomingTag>.ConvertToModel(PlatformIncomingTag, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _PlatformIncomingTagManager.UpdateAsync(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIncomingTag(string id)
        {
            var IncomingTag = await _PlatformIncomingTagRepository.GetByIdAsync(id);
            if (IncomingTag == null)
            {
                return NotFound();
            }
            await _PlatformIncomingTagRepository.DeleteByIdAsync(IncomingTag.Id);

            return NoContent();
        }
    }
}
