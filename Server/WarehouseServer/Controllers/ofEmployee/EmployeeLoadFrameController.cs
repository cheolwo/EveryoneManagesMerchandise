using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployee;
using BusinessData.ofWarehouse.ofInterface.ofEmployee;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehouseServer.Controllers.ofEmployee
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeLoadFrameController : ControllerBase
    {
        private readonly ILogger<EmployeeLoadFrameController> _logger;
        private readonly IEmployeeLoadFrameManager _EmployeeLoadFrameManager;
        private readonly IEmployeeLoadFrameRepository _EmployeeLoadFrameRepository;

        public EmployeeLoadFrameController(ILogger<EmployeeLoadFrameController> logger,
            IEmployeeLoadFrameManager EmployeeLoadFrameManager, 
            IEmployeeLoadFrameRepository EmployeeLoadFrameRepository)
        {
            _logger = logger;
            _EmployeeLoadFrameRepository = EmployeeLoadFrameRepository;
            _EmployeeLoadFrameManager = EmployeeLoadFrameManager;
        }
        // GET: api/<EmployeeLoadFrameController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeLoadFrame>> GetLoadFrame(string id)
        {
            var LoadFrame = await _EmployeeLoadFrameRepository.GetByIdAsync(id);

            if (LoadFrame == null)
            {
                return NotFound();
            }
            var GetEmployeeLoadFrame = ModelToDTO<LoadFrame, EmployeeLoadFrame>.ConvertToDTO(LoadFrame, new EmployeeLoadFrame());
            return GetEmployeeLoadFrame;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeLoadFrame>>> Gets()
        {
            var LoadFrames = await _EmployeeLoadFrameRepository.GetToListAsync();
            if (LoadFrames.Count == 0)
            {
                return new List<EmployeeLoadFrame>();
            }
            List<EmployeeLoadFrame> EmployeeLoadFrames = new List<EmployeeLoadFrame>();
            foreach (var LoadFrame in LoadFrames)
            {
                EmployeeLoadFrames.Add(ModelToDTO<LoadFrame, EmployeeLoadFrame>.ConvertToDTO(LoadFrame, new EmployeeLoadFrame()));
            }
            return EmployeeLoadFrames;
        }
        [HttpGet("User")]
        public async Task<ActionResult<IEnumerable<EmployeeLoadFrame>>> GetsAsyncByUserId(string userid)
        {
            var LoadFrames = await _EmployeeLoadFrameRepository.GetToListByUserIdAsync(userid);
            if (LoadFrames.Count == 0)
            {
                return new List<EmployeeLoadFrame>();
            }
            List<EmployeeLoadFrame> EmployeeLoadFrames = new List<EmployeeLoadFrame>();
            foreach (var LoadFrame in LoadFrames)
            {
                EmployeeLoadFrames.Add(ModelToDTO<LoadFrame, EmployeeLoadFrame>.ConvertToDTO(LoadFrame, new EmployeeLoadFrame()));
            }
            return EmployeeLoadFrames;
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeLoadFrame>> PostLoadFrame(EmployeeLoadFrame EmployeeLoadFrame)
        {
            var model = DTOToModel<EmployeeLoadFrame, LoadFrame>.ConvertToModel(EmployeeLoadFrame, new());
            var newLoadFrame = await _EmployeeLoadFrameManager.CreateAsync(model);

            //return CreatedAtAction("GetLoadFrame", new { id = LoadFrame.Id }, LoadFrame);
            return CreatedAtAction(nameof(GetLoadFrame), new { id = newLoadFrame.Id }, newLoadFrame);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoadFrame(string id, EmployeeLoadFrame EmployeeLoadFrame)
        {
            var model = DTOToModel<EmployeeLoadFrame, LoadFrame>.ConvertToModel(EmployeeLoadFrame, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _EmployeeLoadFrameManager.UpdateAsync(model);
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
            var LoadFrame = await _EmployeeLoadFrameRepository.GetByIdAsync(id);
            if (LoadFrame == null)
            {
                return NotFound();
            }
            await _EmployeeLoadFrameRepository.DeleteByIdAsync(LoadFrame.Id);

            return NoContent();
        }
    }
}
