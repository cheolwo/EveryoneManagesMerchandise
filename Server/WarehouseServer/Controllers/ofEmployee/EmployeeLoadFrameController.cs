using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployee;
using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoadFrameServer.Controllers.ofEmployee
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
        // GET: api/<EmployeeDotBarcodeController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeLoadFrame>> GetLoadFrame(string id)
        {
            var LoadFrame = await _EmployeeLoadFrameRepository.GetByIdAsync(id);

            if (LoadFrame == null)
            {
                return NotFound();
            }
            var GetEmployeeDotBarcode = ModelToDTO<LoadFrame, EmployeeLoadFrame>.ConvertToDTO(LoadFrame, new EmployeeLoadFrame());
            return GetEmployeeDotBarcode;
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
