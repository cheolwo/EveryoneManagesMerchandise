using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployer;
using BusinessData.ofWarehouse.ofInterface.ofEmployer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SWCommodityServer.Controllers.ofEmployer
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerSWCommodityController : ControllerBase
    {
        private readonly ILogger<EmployerSWCommodityController> _logger;
        private readonly IEmployerSWCommodityManager _EmployerSWCommodityManager;
        private readonly IEmployerSWCommodityRepository _EmployerSWCommodityRepository;

        public EmployerSWCommodityController(ILogger<EmployerSWCommodityController> logger,
            IEmployerSWCommodityManager EmployerSWCommodityManager, 
            IEmployerSWCommodityRepository EmployerSWCommodityRepository)
        {
            _logger = logger;
            _EmployerSWCommodityRepository = EmployerSWCommodityRepository;
            _EmployerSWCommodityManager = EmployerSWCommodityManager;
        }
        // GET: api/<EmployerSWCommodityController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployerSWCommodity>> GetSWCommodity(string id)
        {
            var SWCommodity = await _EmployerSWCommodityRepository.GetByIdAsync(id);

            if (SWCommodity == null)
            {
                return NotFound();
            }
            var GetEmployerSWCommodity = ModelToDTO<SWCommodity, EmployerSWCommodity>.ConvertToDTO(SWCommodity, new EmployerSWCommodity());
            return GetEmployerSWCommodity;
        }

        [HttpPost]
        public async Task<ActionResult<EmployerSWCommodity>> PostSWCommodity(EmployerSWCommodity EmployerSWCommodity)
        {
            var model = DTOToModel<EmployerSWCommodity, SWCommodity>.ConvertToModel(EmployerSWCommodity, new());
            var newSWCommodity = await _EmployerSWCommodityManager.CreateAsync(model);

            //return CreatedAtAction("GetSWCommodity", new { id = SWCommodity.Id }, SWCommodity);
            return CreatedAtAction(nameof(GetSWCommodity), new { id = newSWCommodity.Id }, newSWCommodity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSWCommodity(string id, EmployerSWCommodity EmployerSWCommodity)
        {
            var model = DTOToModel<EmployerSWCommodity, SWCommodity>.ConvertToModel(EmployerSWCommodity, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _EmployerSWCommodityManager.UpdateAsync(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSWCommodity(string id)
        {
            var SWCommodity = await _EmployerSWCommodityRepository.GetByIdAsync(id);
            if (SWCommodity == null)
            {
                return NotFound();
            }
            await _EmployerSWCommodityRepository.DeleteByIdAsync(SWCommodity.Id);

            return NoContent();
        }
    }
}
