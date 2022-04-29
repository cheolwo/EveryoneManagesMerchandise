using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessView.ofWarehouse.ofEmployer;
using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployer;
using BusinessData.ofWarehouse.ofInterface.ofEmployer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MWCommodityServer.Controllers.ofEmployer
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerMWCommodityController : ControllerBase
    {
        private readonly ILogger<EmployerMWCommodityController> _logger;
        private readonly IEmployerMWCommodityManager _EmployerMWCommodityManager;
        private readonly IEmployerMWCommodityRepository _EmployerMWCommodityRepository;

        public EmployerMWCommodityController(ILogger<EmployerMWCommodityController> logger,
            IEmployerMWCommodityManager EmployerMWCommodityManager, 
            IEmployerMWCommodityRepository EmployerMWCommodityRepository)
        {
            _logger = logger;
            _EmployerMWCommodityRepository = EmployerMWCommodityRepository;
            _EmployerMWCommodityManager = EmployerMWCommodityManager;
        }
        // GET: api/<EmployerMWCommodityController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployerMWCommodity>> GetMWCommodity(string id)
        {
            var MWCommodity = await _EmployerMWCommodityRepository.GetByIdAsync(id);

            if (MWCommodity == null)
            {
                return NotFound();
            }
            var GetEmployerMWCommodity = ModelToDTO<MWCommodity, EmployerMWCommodity>.ConvertToDTO(MWCommodity, new EmployerMWCommodity());
            return GetEmployerMWCommodity;
        }

        [HttpPost]
        public async Task<ActionResult<EmployerMWCommodity>> PostMWCommodity(EmployerMWCommodity EmployerMWCommodity)
        {
            var model = DTOToModel<EmployerMWCommodity, MWCommodity>.ConvertToModel(EmployerMWCommodity, new());
            var newMWCommodity = await _EmployerMWCommodityManager.CreateAsync(model);

            //return CreatedAtAction("GetMWCommodity", new { id = MWCommodity.Id }, MWCommodity);
            return CreatedAtAction(nameof(GetMWCommodity), new { id = newMWCommodity.Id }, newMWCommodity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMWCommodity(string id, EmployerMWCommodity EmployerMWCommodity)
        {
            var model = DTOToModel<EmployerMWCommodity, MWCommodity>.ConvertToModel(EmployerMWCommodity, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _EmployerMWCommodityManager.UpdateAsync(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMWCommodity(string id)
        {
            var MWCommodity = await _EmployerMWCommodityRepository.GetByIdAsync(id);
            if (MWCommodity == null)
            {
                return NotFound();
            }
            await _EmployerMWCommodityRepository.DeleteByIdAsync(MWCommodity.Id);

            return NoContent();
        }
    }
}
