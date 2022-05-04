using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployee;
using BusinessData.ofWarehouse.ofInterface.ofEmployer;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DividedTagServer.Controllers.ofEmployer
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerDividedTagController : ControllerBase
    {
        private readonly ILogger<EmployerDividedTagController> _logger;
        private readonly IEmployerDividedTagManager _EmployerDividedTagManager;
        private readonly IEmployerDividedTagRepository _EmployerDividedTagRepository;

        public EmployerDividedTagController(ILogger<EmployerDividedTagController> logger,
            IEmployerDividedTagManager EmployerDividedTagManager, 
            IEmployerDividedTagRepository EmployerDividedTagRepository)
        {
            _logger = logger;
            _EmployerDividedTagRepository = EmployerDividedTagRepository;
            _EmployerDividedTagManager = EmployerDividedTagManager;
        }
        // GET: api/<EmployerDividedTagController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployerDividedTag>> GetDividedTag(string id)
        {
            var DividedTag = await _EmployerDividedTagRepository.GetByIdAsync(id);

            if (DividedTag == null)
            {
                return NotFound();
            }
            var GetEmployerDividedTag = ModelToDTO<DividedTag, EmployerDividedTag>.ConvertToDTO(DividedTag, new EmployerDividedTag());
            return GetEmployerDividedTag;
        }

        [HttpPost]
        public async Task<ActionResult<EmployerDividedTag>> PostDividedTag(EmployerDividedTag EmployerDividedTag)
        {
            var model = DTOToModel<EmployerDividedTag, DividedTag>.ConvertToModel(EmployerDividedTag, new());
            var newDividedTag = await _EmployerDividedTagManager.CreateAsync(model);

            //return CreatedAtAction("GetDividedTag", new { id = DividedTag.Id }, DividedTag);
            return CreatedAtAction(nameof(GetDividedTag), new { id = newDividedTag.Id }, newDividedTag);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDividedTag(string id, EmployerDividedTag EmployerDividedTag)
        {
            var model = DTOToModel<EmployerDividedTag, DividedTag>.ConvertToModel(EmployerDividedTag, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _EmployerDividedTagManager.UpdateAsync(model);
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
            var DividedTag = await _EmployerDividedTagRepository.GetByIdAsync(id);
            if (DividedTag == null)
            {
                return NotFound();
            }
            await _EmployerDividedTagRepository.DeleteByIdAsync(DividedTag.Id);

            return NoContent();
        }
    }
}
