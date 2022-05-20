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
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlatformEWCommodity>>> Gets()
        {
            var EWCommoditys = await _PlatformEWCommodityRepository.GetToListAsync();
            if (EWCommoditys.Count == 0)
            {
                return new List<PlatformEWCommodity>();
            }
            List<PlatformEWCommodity> PlatformEWCommoditys = new List<PlatformEWCommodity>();
            foreach (var EWCommodity in EWCommoditys)
            {
                PlatformEWCommoditys.Add(ModelToDTO<EWCommodity, PlatformEWCommodity>.ConvertToDTO(EWCommodity, new PlatformEWCommodity()));
            }
            return PlatformEWCommoditys;
        }
        [HttpGet("User")]
        public async Task<ActionResult<IEnumerable<PlatformEWCommodity>>> GetsAsyncByUserId(string userid)
        {
            var EWCommoditys = await _PlatformEWCommodityRepository.GetToListByUserId(userid);
            if (EWCommoditys.Count == 0)
            {
                return new List<PlatformEWCommodity>();
            }
            List<PlatformEWCommodity> PlatformEWCommoditys = new List<PlatformEWCommodity>();
            foreach (var EWCommodity in EWCommoditys)
            {
                PlatformEWCommoditys.Add(ModelToDTO<EWCommodity, PlatformEWCommodity>.ConvertToDTO(EWCommodity, new PlatformEWCommodity()));
            }
            return PlatformEWCommoditys;
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
