using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployee;
using BusinessView.ofGeneric;
using BusinessView.ofWarehouse.ofEmployee;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IncomingTagServer.Controllers.ofEmployee
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeIncomingTagController : ControllerBase
    {
        private readonly ILogger<EmployeeIncomingTagController> _logger;
        private readonly IEmployeeIncomingTagManager _EmployeeIncomingTagManager;
        private readonly IEmployeeIncomingTagRepository _EmployeeIncomingTagRepository;

        public EmployeeIncomingTagController(ILogger<EmployeeIncomingTagController> logger,
            IEmployeeIncomingTagManager EmployeeIncomingTagManager, 
            IEmployeeIncomingTagRepository EmployeeIncomingTagRepository)
        {
            _logger = logger;
            _EmployeeIncomingTagRepository = EmployeeIncomingTagRepository;
            _EmployeeIncomingTagManager = EmployeeIncomingTagManager;
        }
        // GET: api/<EmployeeIncomingTagController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeIncomingTag>> GetIncomingTag(string id)
        {
            var IncomingTag = await _EmployeeIncomingTagRepository.GetByIdAsync(id);

            if (IncomingTag == null)
            {
                return NotFound();
            }
            var GetEmployeeIncomingTag = ModelToDTO<IncomingTag, EmployeeIncomingTag>.ConvertToDTO(IncomingTag, new EmployeeIncomingTag());
            return GetEmployeeIncomingTag;
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeIncomingTag>> PostIncomingTag(EmployeeIncomingTag EmployeeIncomingTag)
        {
            var model = DTOToModel<EmployeeIncomingTag, IncomingTag>.ConvertToModel(EmployeeIncomingTag, new());
            var newIncomingTag = await _EmployeeIncomingTagManager.CreateAsync(model);

            //return CreatedAtAction("GetIncomingTag", new { id = IncomingTag.Id }, IncomingTag);
            return CreatedAtAction(nameof(GetIncomingTag), new { id = newIncomingTag.Id }, newIncomingTag);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutIncomingTag(string id, EmployeeIncomingTag EmployeeIncomingTag)
        {
            var model = DTOToModel<EmployeeIncomingTag, IncomingTag>.ConvertToModel(EmployeeIncomingTag, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _EmployeeIncomingTagManager.UpdateAsync(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIncomingTag(string id)
        {
            var IncomingTag = await _EmployeeIncomingTagRepository.GetByIdAsync(id);
            if (IncomingTag == null)
            {
                return NotFound();
            }
            await _EmployeeIncomingTagRepository.DeleteByIdAsync(IncomingTag.Id);

            return NoContent();
        }
    }
}
