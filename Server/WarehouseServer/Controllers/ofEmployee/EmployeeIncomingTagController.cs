using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployee;
using BusinessData.ofWarehouse.ofInterface.ofEmployee;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehouseServer.Controllers.ofEmployee
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
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeIncomingTag>>> Gets()
        {
            var IncomingTags = await _EmployeeIncomingTagRepository.GetToListAsync();
            if (IncomingTags.Count == 0)
            {
                return new List<EmployeeIncomingTag>();
            }
            List<EmployeeIncomingTag> EmployeeIncomingTags = new List<EmployeeIncomingTag>();
            foreach (var IncomingTag in IncomingTags)
            {
                EmployeeIncomingTags.Add(ModelToDTO<IncomingTag, EmployeeIncomingTag>.ConvertToDTO(IncomingTag, new EmployeeIncomingTag()));
            }
            return EmployeeIncomingTags;
        }
        [HttpGet("User")]
        public async Task<ActionResult<IEnumerable<EmployeeIncomingTag>>> GetsAsyncByUserId(string userid)
        {
            var IncomingTags = await _EmployeeIncomingTagRepository.GetToListByUserId(userid);
            if (IncomingTags.Count == 0)
            {
                return new List<EmployeeIncomingTag>();
            }
            List<EmployeeIncomingTag> EmployeeIncomingTags = new List<EmployeeIncomingTag>();
            foreach (var IncomingTag in IncomingTags)
            {
                EmployeeIncomingTags.Add(ModelToDTO<IncomingTag, EmployeeIncomingTag>.ConvertToDTO(IncomingTag, new EmployeeIncomingTag()));
            }
            return EmployeeIncomingTags;
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
