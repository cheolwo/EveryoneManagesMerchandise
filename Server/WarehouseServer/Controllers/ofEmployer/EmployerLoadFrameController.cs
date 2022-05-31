using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployee;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehouseServer.Controllers.ofEmployer
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerLoadFrameController : ControllerBase
    {
        private readonly ILogger<EmployerLoadFrameController> _logger;
        private readonly IEmployerLoadFrameManager _EmployerLoadFrameManager;
        private readonly IEmployerLoadFrameRepository _EmployerLoadFrameRepository;

        public EmployerLoadFrameController(ILogger<EmployerLoadFrameController> logger,
            IEmployerLoadFrameManager EmployerLoadFrameManager, 
            IEmployerLoadFrameRepository EmployerLoadFrameRepository)
        {
            _logger = logger;
            _EmployerLoadFrameRepository = EmployerLoadFrameRepository;
            _EmployerLoadFrameManager = EmployerLoadFrameManager;
        }
        // GET: api/<EmployerLoadFrameController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployerLoadFrame>> GetLoadFrame(string id)
        {
            var LoadFrame = await _EmployerLoadFrameRepository.GetByIdAsync(id);

            if (LoadFrame == null)
            {
                return NotFound();
            }
            var GetEmployerLoadFrame = ModelToDTO<LoadFrame, EmployerLoadFrame>.ConvertToDTO(LoadFrame, new EmployerLoadFrame());
            return GetEmployerLoadFrame;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployerLoadFrame>>> Gets()
        {
            var LoadFrames = await _EmployerLoadFrameRepository.GetToListAsync();
            if (LoadFrames.Count == 0)
            {
                return new List<EmployerLoadFrame>();
            }
            List<EmployerLoadFrame> EmployerLoadFrames = new List<EmployerLoadFrame>();
            foreach (var LoadFrame in LoadFrames)
            {
                EmployerLoadFrames.Add(ModelToDTO<LoadFrame, EmployerLoadFrame>.ConvertToDTO(LoadFrame, new EmployerLoadFrame()));
            }
            return EmployerLoadFrames;
        }
        [HttpGet("User")]
        public async Task<ActionResult<IEnumerable<EmployerLoadFrame>>> GetsAsyncByUserId(string userid)
        {
            var LoadFrames = await _EmployerLoadFrameRepository.GetToListByUserIdAsync(userid);
            if (LoadFrames.Count == 0)
            {
                return new List<EmployerLoadFrame>();
            }
            List<EmployerLoadFrame> EmployerLoadFrames = new List<EmployerLoadFrame>();
            foreach (var LoadFrame in LoadFrames)
            {
                EmployerLoadFrames.Add(ModelToDTO<LoadFrame, EmployerLoadFrame>.ConvertToDTO(LoadFrame, new EmployerLoadFrame()));
            }
            return EmployerLoadFrames;
        }

        [HttpPost]
        public async Task<ActionResult<EmployerLoadFrame>> PostLoadFrame(EmployerLoadFrame EmployerLoadFrame)
        {
            var model = DTOToModel<EmployerLoadFrame, LoadFrame>.ConvertToModel(EmployerLoadFrame, new());
            var newLoadFrame = await _EmployerLoadFrameManager.CreateAsync(model);

            //return CreatedAtAction("GetLoadFrame", new { id = LoadFrame.Id }, LoadFrame);
            return CreatedAtAction(nameof(GetLoadFrame), new { id = newLoadFrame.Id }, newLoadFrame);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoadFrame(string id, EmployerLoadFrame EmployerLoadFrame)
        {
            var model = DTOToModel<EmployerLoadFrame, LoadFrame>.ConvertToModel(EmployerLoadFrame, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _EmployerLoadFrameManager.UpdateAsync(model);
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
            var LoadFrame = await _EmployerLoadFrameRepository.GetByIdAsync(id);
            if (LoadFrame == null)
            {
                return NotFound();
            }
            await _EmployerLoadFrameRepository.DeleteByIdAsync(LoadFrame.Id);

            return NoContent();
        }
    }
}
