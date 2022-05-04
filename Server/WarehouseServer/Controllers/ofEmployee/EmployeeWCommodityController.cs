using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployee;
using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WCommodityServer.Controllers.ofEmployee
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeWCommodityController : ControllerBase
    {
        private readonly ILogger<EmployeeWCommodityController> _logger;
        private readonly IEmployeeWCommodityManager _EmployeeWCommodityManager;
        private readonly IEmployeeWCommodityRepository _EmployeeWCommodityRepository;

        public EmployeeWCommodityController(ILogger<EmployeeWCommodityController> logger,
            IEmployeeWCommodityManager EmployeeWCommodityManager, 
            IEmployeeWCommodityRepository EmployeeWCommodityRepository)
        {
            _logger = logger;
            _EmployeeWCommodityRepository = EmployeeWCommodityRepository;
            _EmployeeWCommodityManager = EmployeeWCommodityManager;
        }
        // GET: api/<EmployeeWCommodityController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeWCommodity>> GetWCommodity(string id)
        {
            var WCommodity = await _EmployeeWCommodityRepository.GetByIdAsync(id);

            if (WCommodity == null)
            {
                return NotFound();
            }
            var GetEmployeeWCommodity = ModelToDTO<WCommodity, EmployeeWCommodity>.ConvertToDTO(WCommodity, new EmployeeWCommodity());
            return GetEmployeeWCommodity;
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeWCommodity>> PostWCommodity(EmployeeWCommodity EmployeeWCommodity)
        {
            var model = DTOToModel<EmployeeWCommodity, WCommodity>.ConvertToModel(EmployeeWCommodity, new());
            var newWCommodity = await _EmployeeWCommodityManager.CreateAsync(model);

            //return CreatedAtAction("GetWCommodity", new { id = WCommodity.Id }, WCommodity);
            return CreatedAtAction(nameof(GetWCommodity), new { id = newWCommodity.Id }, newWCommodity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutWCommodity(string id, EmployeeWCommodity EmployeeWCommodity)
        {
            var model = DTOToModel<EmployeeWCommodity, WCommodity>.ConvertToModel(EmployeeWCommodity, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _EmployeeWCommodityManager.UpdateAsync(model);
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
            var WCommodity = await _EmployeeWCommodityRepository.GetByIdAsync(id);
            if (WCommodity == null)
            {
                return NotFound();
            }
            await _EmployeeWCommodityRepository.DeleteByIdAsync(WCommodity.Id);

            return NoContent();
        }
    }
}
