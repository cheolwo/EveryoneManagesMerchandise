using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessView.ofWarehouse.ofEmployer;
using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployer;
using BusinessData.ofWarehouse.ofInterface.ofEmployer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WCommodityServer.Controllers.ofEmployer
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerWCommodityController : ControllerBase
    {
        private readonly ILogger<EmployerWCommodityController> _logger;
        private readonly IEmployerWCommodityManager _EmployerWCommodityManager;
        private readonly IEmployerWCommodityRepository _EmployerWCommodityRepository;

        public EmployerWCommodityController(ILogger<EmployerWCommodityController> logger,
            IEmployerWCommodityManager EmployerWCommodityManager, 
            IEmployerWCommodityRepository EmployerWCommodityRepository)
        {
            _logger = logger;
            _EmployerWCommodityRepository = EmployerWCommodityRepository;
            _EmployerWCommodityManager = EmployerWCommodityManager;
        }
        // GET: api/<EmployerWCommodityController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployerWCommodity>> GetWCommodity(string id)
        {
            var WCommodity = await _EmployerWCommodityRepository.GetByIdAsync(id);

            if (WCommodity == null)
            {
                return NotFound();
            }
            var GetEmployerWCommodity = ModelToDTO<WCommodity, EmployerWCommodity>.ConvertToDTO(WCommodity, new EmployerWCommodity());
            return GetEmployerWCommodity;
        }

        [HttpPost]
        public async Task<ActionResult<EmployerWCommodity>> PostWCommodity(EmployerWCommodity EmployerWCommodity)
        {
            var model = DTOToModel<EmployerWCommodity, WCommodity>.ConvertToModel(EmployerWCommodity, new());
            var newWCommodity = await _EmployerWCommodityManager.CreateAsync(model);

            //return CreatedAtAction("GetWCommodity", new { id = WCommodity.Id }, WCommodity);
            return CreatedAtAction(nameof(GetWCommodity), new { id = newWCommodity.Id }, newWCommodity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutWCommodity(string id, EmployerWCommodity EmployerWCommodity)
        {
            var model = DTOToModel<EmployerWCommodity, WCommodity>.ConvertToModel(EmployerWCommodity, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _EmployerWCommodityManager.UpdateAsync(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWCommodity(string id)
        {
            var WCommodity = await _EmployerWCommodityRepository.GetByIdAsync(id);
            if (WCommodity == null)
            {
                return NotFound();
            }
            await _EmployerWCommodityRepository.DeleteByIdAsync(WCommodity.Id);

            return NoContent();
        }
    }
}
