using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployer;
using BusinessData.ofWarehouse.ofInterface.ofEmployer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehouseServer.Controllers.ofEmployer
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
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployerWCommodity>>> Gets()
        {
            var WCommoditys = await _EmployerWCommodityRepository.GetToListAsync();
            if (WCommoditys.Count == 0)
            {
                return new List<EmployerWCommodity>();
            }
            List<EmployerWCommodity> EmployerWCommoditys = new List<EmployerWCommodity>();
            foreach (var WCommodity in WCommoditys)
            {
                EmployerWCommoditys.Add(ModelToDTO<WCommodity, EmployerWCommodity>.ConvertToDTO(WCommodity, new EmployerWCommodity()));
            }
            return EmployerWCommoditys;
        }
        [HttpGet("User")]
        public async Task<ActionResult<IEnumerable<EmployerWCommodity>>> GetsAsyncByUserId(string userid)
        {
            var WCommoditys = await _EmployerWCommodityRepository.GetToListByUserIdAsync(userid);
            if (WCommoditys.Count == 0)
            {
                return new List<EmployerWCommodity>();
            }
            List<EmployerWCommodity> EmployerWCommoditys = new List<EmployerWCommodity>();
            foreach (var WCommodity in WCommoditys)
            {
                EmployerWCommoditys.Add(ModelToDTO<WCommodity, EmployerWCommodity>.ConvertToDTO(WCommodity, new EmployerWCommodity()));
            }
            return EmployerWCommoditys;
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
