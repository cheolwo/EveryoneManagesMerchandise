using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessLogic.ofEntityManager.ofWarehouse.ofInterface.ofPlatform;
using BusinessData.ofDataAccessLayer.ofWarehouse.ofInterface;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofPlatform;
using BusinessData.ofPresentationLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofWarehouse.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehouseServer.Controllers.ofPlatform
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformWorkingDeskController : ControllerBase
    {
        private readonly ILogger<PlatformWorkingDesk> _logger;
        private readonly IPlatformWorkingDeskManager _PlatformWorkingDeskManager;
        private readonly IPlatformWorkingDeskRepository _PlatformWorkingDeskRepository;

        public PlatformWorkingDeskController(ILogger<PlatformWorkingDesk> logger,
            IPlatformWorkingDeskManager PlatformWorkingDeskManager, 
            IPlatformWorkingDeskRepository PlatformWorkingDeskRepository)
        {
            _logger = logger;
            _PlatformWorkingDeskRepository = PlatformWorkingDeskRepository;
            _PlatformWorkingDeskManager = PlatformWorkingDeskManager;
        }
        // GET: api/<PlatformWorkingDeskController>
        [HttpGet("{id}")]
        public async Task<ActionResult<PlatformWorkingDesk>> GetWorkingDesk(string id)
        {
            var workingDesk = await _PlatformWorkingDeskRepository.GetByIdAsync(id);

            if (workingDesk == null)
            {
                return NotFound();
            }
            var GetPlatformWorkingDesk = ModelToDTO<WorkingDesk, PlatformWorkingDesk>.ConvertToDTO(workingDesk, new PlatformWorkingDesk());
            return GetPlatformWorkingDesk;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlatformWorkingDesk>>> Gets()
        {
            var WorkingDesks = await _PlatformWorkingDeskRepository.GetToListAsync();
            if (WorkingDesks.Count == 0)
            {
                return new List<PlatformWorkingDesk>();
            }
            List<PlatformWorkingDesk> PlatformWorkingDesks = new List<PlatformWorkingDesk>();
            foreach (var WorkingDesk in WorkingDesks)
            {
                PlatformWorkingDesks.Add(ModelToDTO<WorkingDesk, PlatformWorkingDesk>.ConvertToDTO(WorkingDesk, new PlatformWorkingDesk()));
            }
            return PlatformWorkingDesks;
        }
        [HttpGet("User")]
        public async Task<ActionResult<IEnumerable<PlatformWorkingDesk>>> GetsAsyncByUserId(string userid)
        {
            var WorkingDesks = await _PlatformWorkingDeskRepository.GetToListByUserIdAsync(userid);
            if (WorkingDesks.Count == 0)
            {
                return new List<PlatformWorkingDesk>();
            }
            List<PlatformWorkingDesk> PlatformWorkingDesks = new List<PlatformWorkingDesk>();
            foreach (var WorkingDesk in WorkingDesks)
            {
                PlatformWorkingDesks.Add(ModelToDTO<WorkingDesk, PlatformWorkingDesk>.ConvertToDTO(WorkingDesk, new PlatformWorkingDesk()));
            }
            return PlatformWorkingDesks;
        }

        [HttpPost]
        public async Task<ActionResult<PlatformWorkingDesk>> PostWorkingDesk(PlatformWorkingDesk PlatformWorkingDesk)
        {
            var model = DTOToModel<PlatformWorkingDesk, WorkingDesk>.ConvertToModel(PlatformWorkingDesk, new());
            var newWorkingDesk = await _PlatformWorkingDeskManager.CreateAsync(model);

            //return CreatedAtAction("GetWorkingDesk", new { id = WorkingDesk.Id }, WorkingDesk);
            return CreatedAtAction(nameof(GetWorkingDesk), new { id = newWorkingDesk.Id }, newWorkingDesk);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkingDesk(string id, PlatformWorkingDesk PlatformWorkingDesk)
        {
            var model = DTOToModel<PlatformWorkingDesk, WorkingDesk>.ConvertToModel(PlatformWorkingDesk, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _PlatformWorkingDeskManager.UpdateAsync(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkingDesk(string id)
        {
            var WorkingDesk = await _PlatformWorkingDeskRepository.GetByIdAsync(id);
            if (WorkingDesk == null)
            {
                return NotFound();
            }
            await _PlatformWorkingDeskRepository.DeleteByIdAsync(WorkingDesk.Id);

            return NoContent();
        }
    }
}
