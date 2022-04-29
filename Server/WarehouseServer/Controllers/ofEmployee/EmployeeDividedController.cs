using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessView.ofWarehouse.ofEmployee;
using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployee;
using BusinessData.ofWarehouse.ofInterface.ofEmployee;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DividedTagServer.Controllers.ofEmployee
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDividedTagController : ControllerBase
    {
        private readonly ILogger<EmployeeDividedTagController> _logger;
        private readonly IEmployeeDividedTagManager _EmployeeDividedTagManager;
        private readonly IEmployeeDividedTagRepository _EmployeeDividedTagRepository;

        public EmployeeDividedTagController(ILogger<EmployeeDividedTagController> logger,
            IEmployeeDividedTagManager EmployeeDividedTagManager, 
            IEmployeeDividedTagRepository EmployeeDividedTagRepository)
        {
            _logger = logger;
            _EmployeeDividedTagRepository = EmployeeDividedTagRepository;
            _EmployeeDividedTagManager = EmployeeDividedTagManager;
        }
        // GET: api/<EmployeeDividedTagController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeDividedTag>> GetDividedTag(string id)
        {
            var DividedTag = await _EmployeeDividedTagRepository.GetByIdAsync(id);

            if (DividedTag == null)
            {
                return NotFound();
            }
            var GetEmployeeDividedTag = ModelToDTO<DividedTag, EmployeeDividedTag>.ConvertToDTO(DividedTag, new EmployeeDividedTag());
            return GetEmployeeDividedTag;
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeDividedTag>> PostDividedTag(EmployeeDividedTag EmployeeDividedTag)
        {
            var model = DTOToModel<EmployeeDividedTag, DividedTag>.ConvertToModel(EmployeeDividedTag, new());
            var newDividedTag = await _EmployeeDividedTagManager.CreateAsync(model);

            //return CreatedAtAction("GetDividedTag", new { id = DividedTag.Id }, DividedTag);
            return CreatedAtAction(nameof(GetDividedTag), new { id = newDividedTag.Id }, newDividedTag);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDividedTag(string id, EmployeeDividedTag EmployeeDividedTag)
        {
            var model = DTOToModel<EmployeeDividedTag, DividedTag>.ConvertToModel(EmployeeDividedTag, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _EmployeeDividedTagManager.UpdateAsync(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDividedTag(string id)
        {
            var DividedTag = await _EmployeeDividedTagRepository.GetByIdAsync(id);
            if (DividedTag == null)
            {
                return NotFound();
            }
            await _EmployeeDividedTagRepository.DeleteByIdAsync(DividedTag.Id);

            return NoContent();
        }
    }
}
