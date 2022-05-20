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
    public class PlatformDividedTagController : ControllerBase
    {
        private readonly ILogger<PlatformDividedTagController> _logger;
        private readonly IPlatformDividedTagManager _PlatformDividedTagManager;
        private readonly IPlatformDividedTagRepository _PlatformDividedTagRepository;

        public PlatformDividedTagController(ILogger<PlatformDividedTagController> logger,
            IPlatformDividedTagManager PlatformDividedTagManager, 
            IPlatformDividedTagRepository PlatformDividedTagRepository)
        {
            _logger = logger;
            _PlatformDividedTagRepository = PlatformDividedTagRepository;
            _PlatformDividedTagManager = PlatformDividedTagManager;
        }
        // GET: api/<PlatformDividedTagController>
        [HttpGet("{id}")]
        public async Task<ActionResult<PlatformDividedTag>> GetDividedTag(string id)
        {
            var DividedTag = await _PlatformDividedTagRepository.GetByIdAsync(id);

            if (DividedTag == null)
            {
                return NotFound();
            }
            var GetPlatformDividedTag = ModelToDTO<DividedTag, PlatformDividedTag>.ConvertToDTO(DividedTag, new PlatformDividedTag());
            return GetPlatformDividedTag;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlatformDividedTag>>> Gets()
        {
            var DividedTags = await _PlatformDividedTagRepository.GetToListAsync();
            if (DividedTags.Count == 0)
            {
                return new List<PlatformDividedTag>();
            }
            List<PlatformDividedTag> PlatformDividedTags = new List<PlatformDividedTag>();
            foreach (var DividedTag in DividedTags)
            {
                PlatformDividedTags.Add(ModelToDTO<DividedTag, PlatformDividedTag>.ConvertToDTO(DividedTag, new PlatformDividedTag()));
            }
            return PlatformDividedTags;
        }
        [HttpGet("User")]
        public async Task<ActionResult<IEnumerable<PlatformDividedTag>>> GetsAsyncByUserId(string userid)
        {
            var DividedTags = await _PlatformDividedTagRepository.GetToListByUserId(userid);
            if (DividedTags.Count == 0)
            {
                return new List<PlatformDividedTag>();
            }
            List<PlatformDividedTag> PlatformDividedTags = new List<PlatformDividedTag>();
            foreach (var DividedTag in DividedTags)
            {
                PlatformDividedTags.Add(ModelToDTO<DividedTag, PlatformDividedTag>.ConvertToDTO(DividedTag, new PlatformDividedTag()));
            }
            return PlatformDividedTags;
        }

        [HttpPost]
        public async Task<ActionResult<PlatformDividedTag>> PostDividedTag(PlatformDividedTag PlatformDividedTag)
        {
            var model = DTOToModel<PlatformDividedTag, DividedTag>.ConvertToModel(PlatformDividedTag, new());
            var newDividedTag = await _PlatformDividedTagManager.CreateAsync(model);

            //return CreatedAtAction("GetDividedTag", new { id = DividedTag.Id }, DividedTag);
            return CreatedAtAction(nameof(GetDividedTag), new { id = newDividedTag.Id }, newDividedTag);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDividedTag(string id, PlatformDividedTag PlatformDividedTag)
        {
            var model = DTOToModel<PlatformDividedTag, DividedTag>.ConvertToModel(PlatformDividedTag, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _PlatformDividedTagManager.UpdateAsync(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDividedTag(string id)
        {
            var DividedTag = await _PlatformDividedTagRepository.GetByIdAsync(id);
            if (DividedTag == null)
            {
                return NotFound();
            }
            await _PlatformDividedTagRepository.DeleteByIdAsync(DividedTag.Id);

            return NoContent();
        }
    }
}
