using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployer;
using BusinessData.ofWarehouse.ofInterface.ofEmployer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehouseServer.Controllers.ofEmployer
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerWorkingDeskController : ControllerBase
    {
        private readonly ILogger<EmployerWorkingDeskController> _logger;
        private readonly IEmployerWorkingDeskManager _EmployerWorkingDeskManager;
        private readonly IEmployerWorkingDeskRepository _EmployerWorkingDeskRepository;

        public EmployerWorkingDeskController(ILogger<EmployerWorkingDeskController> logger,
            IEmployerWorkingDeskManager EmployerWorkingDeskManager, 
            IEmployerWorkingDeskRepository EmployerWorkingDeskRepository)
        {
            _logger = logger;
            _EmployerWorkingDeskRepository = EmployerWorkingDeskRepository;
            _EmployerWorkingDeskManager = EmployerWorkingDeskManager;
        }
        // GET: api/<EmployerWorkingDeskController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployerWorkingDesk>> GetWorkingDesk(string id)
        {
            var WorkingDesk = await _EmployerWorkingDeskRepository.GetByIdAsync(id);

            if (WorkingDesk == null)
            {
                return NotFound();
            }
            var GetEmployerWorkingDesk = ModelToDTO<WorkingDesk, EmployerWorkingDesk>.ConvertToDTO(WorkingDesk, new EmployerWorkingDesk());
            return GetEmployerWorkingDesk;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployerWorkingDesk>>> Gets()
        {
            var WorkingDesks = await _EmployerWorkingDeskRepository.GetToListAsync();
            if (WorkingDesks.Count == 0)
            {
                return new List<EmployerWorkingDesk>();
            }
            List<EmployerWorkingDesk> EmployerWorkingDesks = new List<EmployerWorkingDesk>();
            foreach (var WorkingDesk in WorkingDesks)
            {
                EmployerWorkingDesks.Add(ModelToDTO<WorkingDesk, EmployerWorkingDesk>.ConvertToDTO(WorkingDesk, new EmployerWorkingDesk()));
            }
            return EmployerWorkingDesks;
        }
        [HttpGet("User")]
        public async Task<ActionResult<IEnumerable<EmployerWorkingDesk>>> GetsAsyncByUserId(string userid)
        {
            var WorkingDesks = await _EmployerWorkingDeskRepository.GetToListByUserIdAsync(userid);
            if (WorkingDesks.Count == 0)
            {
                return new List<EmployerWorkingDesk>();
            }
            List<EmployerWorkingDesk> EmployerWorkingDesks = new List<EmployerWorkingDesk>();
            foreach (var WorkingDesk in WorkingDesks)
            {
                EmployerWorkingDesks.Add(ModelToDTO<WorkingDesk, EmployerWorkingDesk>.ConvertToDTO(WorkingDesk, new EmployerWorkingDesk()));
            }
            return EmployerWorkingDesks;
        }

        [HttpPost]
        public async Task<ActionResult<EmployerWorkingDesk>> PostWorkingDesk(EmployerWorkingDesk EmployerWorkingDesk)
        {
            var model = DTOToModel<EmployerWorkingDesk, WorkingDesk>.ConvertToModel(EmployerWorkingDesk, new());
            var newWorkingDesk = await _EmployerWorkingDeskManager.CreateAsync(model);

            //return CreatedAtAction("GetWorkingDesk", new { id = WorkingDesk.Id }, WorkingDesk);
            return CreatedAtAction(nameof(GetWorkingDesk), new { id = newWorkingDesk.Id }, newWorkingDesk);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkingDesk(string id, EmployerWorkingDesk EmployerWorkingDesk)
        {
            var model = DTOToModel<EmployerWorkingDesk, WorkingDesk>.ConvertToModel(EmployerWorkingDesk, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _EmployerWorkingDeskManager.UpdateAsync(model);
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
            var WorkingDesk = await _EmployerWorkingDeskRepository.GetByIdAsync(id);
            if (WorkingDesk == null)
            {
                return NotFound();
            }
            await _EmployerWorkingDeskRepository.DeleteByIdAsync(WorkingDesk.Id);

            return NoContent();
        }
    }
}
