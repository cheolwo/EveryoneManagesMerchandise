using BusinessData.ofTrade.ofinterface.ofEmployer;
using BusinessData.ofTrade.ofModel;
using BusinessLogic.ofManager.ofTradeCenter.ofInterface.ofEmployer;
using BusinessView.ofGeneric;
using BusinessView.ofTrade.ofEmployer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehouseServer.Controllers.ofEmployer
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerETCommodityController : ControllerBase
    {
        private readonly ILogger<EmployerETCommodityController> _logger;
        private readonly IEmployerETCommodityManager _EmployerETCommodityManager;
        private readonly IEmployerETCommodityRepository _EmployerETCommodityRepository;

        public EmployerETCommodityController(ILogger<EmployerETCommodityController> logger,
            IEmployerETCommodityManager EmployerETCommodityManager, 
            IEmployerETCommodityRepository EmployerETCommodityRepository)
        {
            _logger = logger;
            _EmployerETCommodityRepository = EmployerETCommodityRepository;
            _EmployerETCommodityManager = EmployerETCommodityManager;
        }
        // GET: api/<EmployerETCommodityController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployerETCommodity>> GetETCommodity(string id)
        {
            var ETCommodity = await _EmployerETCommodityRepository.GetByIdAsync(id);

            if (ETCommodity == null)
            {
                return NotFound();
            }
            var GetEmployerETCommodity = ModelToDTO<ETCommodity, EmployerETCommodity>.ConvertToDTO(ETCommodity, new EmployerETCommodity());
            return GetEmployerETCommodity;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployerETCommodity>>> Gets()
        {
            var ETCommoditys = await _EmployerETCommodityRepository.GetToListAsync();
            if (ETCommoditys.Count == 0)
            {
                return new List<EmployerETCommodity>();
            }
            List<EmployerETCommodity> EmployerETCommoditys = new List<EmployerETCommodity>();
            foreach (var ETCommodity in ETCommoditys)
            {
                EmployerETCommoditys.Add(ModelToDTO<ETCommodity, EmployerETCommodity>.ConvertToDTO(ETCommodity, new EmployerETCommodity()));
            }
            return EmployerETCommoditys;
        }
        [HttpGet("User")]
        public async Task<ActionResult<IEnumerable<EmployerETCommodity>>> GetsAsyncByUserId(string userid)
        {
            var ETCommoditys = await _EmployerETCommodityRepository.GetToListByUserId(userid);
            if (ETCommoditys.Count == 0)
            {
                return new List<EmployerETCommodity>();
            }
            List<EmployerETCommodity> EmployerETCommoditys = new List<EmployerETCommodity>();
            foreach (var ETCommodity in ETCommoditys)
            {
                EmployerETCommoditys.Add(ModelToDTO<ETCommodity, EmployerETCommodity>.ConvertToDTO(ETCommodity, new EmployerETCommodity()));
            }
            return EmployerETCommoditys;
        }

        [HttpPost]
        public async Task<ActionResult<EmployerETCommodity>> PostETCommodity(EmployerETCommodity EmployerETCommodity)
        {
            var model = DTOToModel<EmployerETCommodity, ETCommodity>.ConvertToModel(EmployerETCommodity, new());
            var newETCommodity = await _EmployerETCommodityManager.CreateAsync(model);

            //return CreatedAtAction("GetETCommodity", new { id = ETCommodity.Id }, ETCommodity);
            return CreatedAtAction(nameof(GetETCommodity), new { id = newETCommodity.Id }, newETCommodity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutETCommodity(string id, EmployerETCommodity EmployerETCommodity)
        {
            var model = DTOToModel<EmployerETCommodity, ETCommodity>.ConvertToModel(EmployerETCommodity, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _EmployerETCommodityManager.UpdateAsync(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteETCommodity(string id)
        {
            var ETCommodity = await _EmployerETCommodityRepository.GetByIdAsync(id);
            if (ETCommodity == null)
            {
                return NotFound();
            }
            await _EmployerETCommodityRepository.DeleteByIdAsync(ETCommodity.Id);

            return NoContent();
        }
    }
}
