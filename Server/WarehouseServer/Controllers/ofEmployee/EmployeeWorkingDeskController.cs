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
    public class EmployeeWorkingDeskController : ControllerBase
    {
        private readonly ILogger<EmployeeWorkingDeskController> _logger;
        private readonly IEmployeeWorkingDeskManager _EmployeeWorkingDeskManager;
        private readonly IEmployeeWorkingDeskRepository _EmployeeWorkingDeskRepository;

        public EmployeeWorkingDeskController(ILogger<EmployeeWorkingDeskController> logger,
            IEmployeeWorkingDeskManager EmployeeWorkingDeskManager, 
            IEmployeeWorkingDeskRepository EmployeeWorkingDeskRepository)
        {
            _logger = logger;
            _EmployeeWorkingDeskRepository = EmployeeWorkingDeskRepository;
            _EmployeeWorkingDeskManager = EmployeeWorkingDeskManager;
        }
        // GET: api/<EmployeeWorkingDeskController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeWorkingDesk>> GetWorkingDesk(string id)
        {
            var WorkingDesk = await _EmployeeWorkingDeskRepository.GetByIdAsync(id);

            if (WorkingDesk == null)
            {
                return NotFound();
            }
            var GetEmployeeWorkingDesk = ModelToDTO<WorkingDesk, EmployeeWorkingDesk>.ConvertToDTO(WorkingDesk, new EmployeeWorkingDesk());
            return GetEmployeeWorkingDesk;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeWorkingDesk>>> Gets()
        {
            var WorkingDesks = await _EmployeeWorkingDeskRepository.GetToListAsync();
            if (WorkingDesks.Count == 0)
            {
                return new List<EmployeeWorkingDesk>();
            }
            List<EmployeeWorkingDesk> EmployeeWorkingDesks = new List<EmployeeWorkingDesk>();
            foreach (var WorkingDesk in WorkingDesks)
            {
                EmployeeWorkingDesks.Add(ModelToDTO<WorkingDesk, EmployeeWorkingDesk>.ConvertToDTO(WorkingDesk, new EmployeeWorkingDesk()));
            }
            return EmployeeWorkingDesks;
        }
        [HttpGet("User")]
        public async Task<ActionResult<IEnumerable<EmployeeWorkingDesk>>> GetsAsyncByUserId(string userid)
        {
            var WorkingDesks = await _EmployeeWorkingDeskRepository.GetToListByUserId(userid);
            if (WorkingDesks.Count == 0)
            {
                return new List<EmployeeWorkingDesk>();
            }
            List<EmployeeWorkingDesk> EmployeeWorkingDesks = new List<EmployeeWorkingDesk>();
            foreach (var WorkingDesk in WorkingDesks)
            {
                EmployeeWorkingDesks.Add(ModelToDTO<WorkingDesk, EmployeeWorkingDesk>.ConvertToDTO(WorkingDesk, new EmployeeWorkingDesk()));
            }
            return EmployeeWorkingDesks;
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeWorkingDesk>> PostWorkingDesk(EmployeeWorkingDesk EmployeeWorkingDesk)
        {
            var model = DTOToModel<EmployeeWorkingDesk, WorkingDesk>.ConvertToModel(EmployeeWorkingDesk, new());
            var newWorkingDesk = await _EmployeeWorkingDeskManager.CreateAsync(model);

            //return CreatedAtAction("GetWorkingDesk", new { id = WorkingDesk.Id }, WorkingDesk);
            return CreatedAtAction(nameof(GetWorkingDesk), new { id = newWorkingDesk.Id }, newWorkingDesk);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkingDesk(string id, EmployeeWorkingDesk EmployeeWorkingDesk)
        {
            var model = DTOToModel<EmployeeWorkingDesk, WorkingDesk>.ConvertToModel(EmployeeWorkingDesk, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _EmployeeWorkingDeskManager.UpdateAsync(model);
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
            var WorkingDesk = await _EmployeeWorkingDeskRepository.GetByIdAsync(id);
            if (WorkingDesk == null)
            {
                return NotFound();
            }
            await _EmployeeWorkingDeskRepository.DeleteByIdAsync(WorkingDesk.Id);

            return NoContent();
        }
    }
}
