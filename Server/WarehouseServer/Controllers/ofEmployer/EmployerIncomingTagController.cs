using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessView.ofWarehouse.ofEmployer;
using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployee;
using BusinessData.ofWarehouse.ofInterface.ofEmployer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IncomingTagServer.Controllers.ofEmployer
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerIncomingTagController : ControllerBase
    {
        private readonly ILogger<EmployerIncomingTagController> _logger;
        private readonly IEmployerIncomingTagManager _EmployerIncomingTagManager;
        private readonly IEmployerIncomingTagRepository _EmployerIncomingTagRepository;

        public EmployerIncomingTagController(ILogger<EmployerIncomingTagController> logger,
            IEmployerIncomingTagManager EmployerIncomingTagManager, 
            IEmployerIncomingTagRepository EmployerIncomingTagRepository)
        {
            _logger = logger;
            _EmployerIncomingTagRepository = EmployerIncomingTagRepository;
            _EmployerIncomingTagManager = EmployerIncomingTagManager;
        }
        // GET: api/<EmployerIncomingTagController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployerIncomingTag>> GetIncomingTag(string id)
        {
            var IncomingTag = await _EmployerIncomingTagRepository.GetByIdAsync(id);

            if (IncomingTag == null)
            {
                return NotFound();
            }
            var GetEmployerIncomingTag = ModelToDTO<IncomingTag, EmployerIncomingTag>.ConvertToDTO(IncomingTag, new EmployerIncomingTag());
            return GetEmployerIncomingTag;
        }

        [HttpPost]
        public async Task<ActionResult<EmployerIncomingTag>> PostIncomingTag(EmployerIncomingTag EmployerIncomingTag)
        {
            var model = DTOToModel<EmployerIncomingTag, IncomingTag>.ConvertToModel(EmployerIncomingTag, new());
            var newIncomingTag = await _EmployerIncomingTagManager.CreateAsync(model);

            //return CreatedAtAction("GetIncomingTag", new { id = IncomingTag.Id }, IncomingTag);
            return CreatedAtAction(nameof(GetIncomingTag), new { id = newIncomingTag.Id }, newIncomingTag);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutIncomingTag(string id, EmployerIncomingTag EmployerIncomingTag)
        {
            var model = DTOToModel<EmployerIncomingTag, IncomingTag>.ConvertToModel(EmployerIncomingTag, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _EmployerIncomingTagManager.UpdateAsync(model);
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
            var IncomingTag = await _EmployerIncomingTagRepository.GetByIdAsync(id);
            if (IncomingTag == null)
            {
                return NotFound();
            }
            await _EmployerIncomingTagRepository.DeleteByIdAsync(IncomingTag.Id);

            return NoContent();
        }
    }
}
