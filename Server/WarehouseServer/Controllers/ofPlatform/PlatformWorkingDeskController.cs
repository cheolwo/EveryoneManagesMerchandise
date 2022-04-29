using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofInterface.ofPlatform;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofPlatform;
using BusinessView.ofGeneric;
using BusinessView.ofWarehouse.ofPlatform;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkingDeskServer.Controllers.ofPlatform
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformWorkingDeskController : ControllerBase
    {
        private readonly ILogger<PlatformWorkingDeskController> _logger;
        private readonly IPlatformWorkingDeskManager _PlatformWorkingDeskManager;
        private readonly IPlatformWorkingDeskRepository _PlatformWorkingDeskRepository;

        public PlatformWorkingDeskController(ILogger<PlatformWorkingDeskController> logger,
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
            var WorkingDesk = await _PlatformWorkingDeskRepository.GetByIdAsync(id);

            if (WorkingDesk == null)
            {
                return NotFound();
            }
            var GetPlatformWorkingDesk = ModelToDTO<WorkingDesk, PlatformWorkingDesk>.ConvertToDTO(WorkingDesk, new PlatformWorkingDesk());
            return GetPlatformWorkingDesk;
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
