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
    public class EmployeeSWCommodityController : ControllerBase
    {
        private readonly ILogger<EmployeeSWCommodityController> _logger;
        private readonly IEmployeeSWCommodityManager _EmployeeSWCommodityManager;
        private readonly IEmployeeSWCommodityRepository _EmployeeSWCommodityRepository;

        public EmployeeSWCommodityController(ILogger<EmployeeSWCommodityController> logger,
            IEmployeeSWCommodityManager EmployeeSWCommodityManager, 
            IEmployeeSWCommodityRepository EmployeeSWCommodityRepository)
        {
            _logger = logger;
            _EmployeeSWCommodityRepository = EmployeeSWCommodityRepository;
            _EmployeeSWCommodityManager = EmployeeSWCommodityManager;
        }
        // GET: api/<EmployeeSWCommodityController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeSWCommodity>> GetSWCommodity(string id)
        {
            var SWCommodity = await _EmployeeSWCommodityRepository.GetByIdAsync(id);

            if (SWCommodity == null)
            {
                return NotFound();
            }
            var GetEmployeeSWCommodity = ModelToDTO<SWCommodity, EmployeeSWCommodity>.ConvertToDTO(SWCommodity, new EmployeeSWCommodity());
            return GetEmployeeSWCommodity;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeSWCommodity>>> Gets()
        {
            var SWCommoditys = await _EmployeeSWCommodityRepository.GetToListAsync();
            if (SWCommoditys.Count == 0)
            {
                return new List<EmployeeSWCommodity>();
            }
            List<EmployeeSWCommodity> EmployeeSWCommoditys = new List<EmployeeSWCommodity>();
            foreach (var SWCommodity in SWCommoditys)
            {
                EmployeeSWCommoditys.Add(ModelToDTO<SWCommodity, EmployeeSWCommodity>.ConvertToDTO(SWCommodity, new EmployeeSWCommodity()));
            }
            return EmployeeSWCommoditys;
        }
        [HttpGet("User")]
        public async Task<ActionResult<IEnumerable<EmployeeSWCommodity>>> GetsAsyncByUserId(string userid)
        {
            var SWCommoditys = await _EmployeeSWCommodityRepository.GetToListByUserIdAsync(userid);
            if (SWCommoditys.Count == 0)
            {
                return new List<EmployeeSWCommodity>();
            }
            List<EmployeeSWCommodity> EmployeeSWCommoditys = new List<EmployeeSWCommodity>();
            foreach (var SWCommodity in SWCommoditys)
            {
                EmployeeSWCommoditys.Add(ModelToDTO<SWCommodity, EmployeeSWCommodity>.ConvertToDTO(SWCommodity, new EmployeeSWCommodity()));
            }
            return EmployeeSWCommoditys;
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeSWCommodity>> PostSWCommodity(EmployeeSWCommodity EmployeeSWCommodity)
        {
            var model = DTOToModel<EmployeeSWCommodity, SWCommodity>.ConvertToModel(EmployeeSWCommodity, new());
            var newSWCommodity = await _EmployeeSWCommodityManager.CreateAsync(model);

            //return CreatedAtAction("GetSWCommodity", new { id = SWCommodity.Id }, SWCommodity);
            return CreatedAtAction(nameof(GetSWCommodity), new { id = newSWCommodity.Id }, newSWCommodity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSWCommodity(string id, EmployeeSWCommodity EmployeeSWCommodity)
        {
            var model = DTOToModel<EmployeeSWCommodity, SWCommodity>.ConvertToModel(EmployeeSWCommodity, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _EmployeeSWCommodityManager.UpdateAsync(model);
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
            var SWCommodity = await _EmployeeSWCommodityRepository.GetByIdAsync(id);
            if (SWCommodity == null)
            {
                return NotFound();
            }
            await _EmployeeSWCommodityRepository.DeleteByIdAsync(SWCommodity.Id);

            return NoContent();
        }
    }
}
