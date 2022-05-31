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
    public class EmployerEWCommodityController : ControllerBase
    {
        private readonly ILogger<EmployerEWCommodityController> _logger;
        private readonly IEmployerEWCommodityManager _EmployerEWCommodityManager;
        private readonly IEmployerEWCommodityRepository _EmployerEWCommodityRepository;

        public EmployerEWCommodityController(ILogger<EmployerEWCommodityController> logger,
            IEmployerEWCommodityManager EmployerEWCommodityManager, 
            IEmployerEWCommodityRepository EmployerEWCommodityRepository)
        {
            _logger = logger;
            _EmployerEWCommodityRepository = EmployerEWCommodityRepository;
            _EmployerEWCommodityManager = EmployerEWCommodityManager;
        }
        // GET: api/<EmployerEWCommodityController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployerEWCommodity>> GetEWCommodity(string id)
        {
            var EWCommodity = await _EmployerEWCommodityRepository.GetByIdAsync(id);

            if (EWCommodity == null)
            {
                return NotFound();
            }
            var GetEmployerEWCommodity = ModelToDTO<EWCommodity, EmployerEWCommodity>.ConvertToDTO(EWCommodity, new EmployerEWCommodity());
            return GetEmployerEWCommodity;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployerEWCommodity>>> Gets()
        {
            var EWCommoditys = await _EmployerEWCommodityRepository.GetToListAsync();
            if (EWCommoditys.Count == 0)
            {
                return new List<EmployerEWCommodity>();
            }
            List<EmployerEWCommodity> EmployerEWCommoditys = new List<EmployerEWCommodity>();
            foreach (var EWCommodity in EWCommoditys)
            {
                EmployerEWCommoditys.Add(ModelToDTO<EWCommodity, EmployerEWCommodity>.ConvertToDTO(EWCommodity, new EmployerEWCommodity()));
            }
            return EmployerEWCommoditys;
        }
        [HttpGet("User")]
        public async Task<ActionResult<IEnumerable<EmployerEWCommodity>>> GetsAsyncByUserId(string userid)
        {
            var EWCommoditys = await _EmployerEWCommodityRepository.GetToListByUserIdAsync(userid);
            if (EWCommoditys.Count == 0)
            {
                return new List<EmployerEWCommodity>();
            }
            List<EmployerEWCommodity> EmployerEWCommoditys = new List<EmployerEWCommodity>();
            foreach (var EWCommodity in EWCommoditys)
            {
                EmployerEWCommoditys.Add(ModelToDTO<EWCommodity, EmployerEWCommodity>.ConvertToDTO(EWCommodity, new EmployerEWCommodity()));
            }
            return EmployerEWCommoditys;
        }

        [HttpPost]
        public async Task<ActionResult<EmployerEWCommodity>> PostEWCommodity(EmployerEWCommodity EmployerEWCommodity)
        {
            var model = DTOToModel<EmployerEWCommodity, EWCommodity>.ConvertToModel(EmployerEWCommodity, new());
            var newEWCommodity = await _EmployerEWCommodityManager.CreateAsync(model);

            //return CreatedAtAction("GetEWCommodity", new { id = EWCommodity.Id }, EWCommodity);
            return CreatedAtAction(nameof(GetEWCommodity), new { id = newEWCommodity.Id }, newEWCommodity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEWCommodity(string id, EmployerEWCommodity EmployerEWCommodity)
        {
            var model = DTOToModel<EmployerEWCommodity, EWCommodity>.ConvertToModel(EmployerEWCommodity, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _EmployerEWCommodityManager.UpdateAsync(model);
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
            var EWCommodity = await _EmployerEWCommodityRepository.GetByIdAsync(id);
            if (EWCommodity == null)
            {
                return NotFound();
            }
            await _EmployerEWCommodityRepository.DeleteByIdAsync(EWCommodity.Id);

            return NoContent();
        }
    }
}
