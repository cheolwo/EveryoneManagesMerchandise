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
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlatformIncomingTag>>> Gets()
        {
            var IncomingTags = await _PlatformIncomingTagRepository.GetToListAsync();
            if (IncomingTags.Count == 0)
            {
                return new List<PlatformIncomingTag>();
            }
            List<PlatformIncomingTag> PlatformIncomingTags = new List<PlatformIncomingTag>();
            foreach (var IncomingTag in IncomingTags)
            {
                PlatformIncomingTags.Add(ModelToDTO<IncomingTag, PlatformIncomingTag>.ConvertToDTO(IncomingTag, new PlatformIncomingTag()));
            }
            return PlatformIncomingTags;
        }
        [HttpGet("User")]
        public async Task<ActionResult<IEnumerable<PlatformIncomingTag>>> GetsAsyncByUserId(string userid)
        {
            var IncomingTags = await _PlatformIncomingTagRepository.GetToListByUserIdAsync(userid);
            if (IncomingTags.Count == 0)
            {
                return new List<PlatformIncomingTag>();
            }
            List<PlatformIncomingTag> PlatformIncomingTags = new List<PlatformIncomingTag>();
            foreach (var IncomingTag in IncomingTags)
            {
                PlatformIncomingTags.Add(ModelToDTO<IncomingTag, PlatformIncomingTag>.ConvertToDTO(IncomingTag, new PlatformIncomingTag()));
            }
            return PlatformIncomingTags;
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
