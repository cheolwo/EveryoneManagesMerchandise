using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessView.ofTrade.ofEmployer;
using BusinessData.ofTrade.ofinterface.ofEmployer;
using BusinessData.ofTrade.ofModel;
using BusinessLogic.ofManager.ofTradeCenter.ofInterface.ofEmployer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TradeServer.Controllers.ofEmployer
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerSTCommodityController : ControllerBase
    {
        private readonly ILogger<EmployerSTCommodityController> _logger;
        private readonly IEmployerSTCommodityManager _EmployerSTCommodityManager;
        private readonly IEmployerSTCommodityRepository _EmployerSTCommodityRepository;

        public EmployerSTCommodityController(ILogger<EmployerSTCommodityController> logger,
            IEmployerSTCommodityManager EmployerSTCommodityManager, 
            IEmployerSTCommodityRepository EmployerSTCommodityRepository)
        {
            _logger = logger;
            _EmployerSTCommodityRepository = EmployerSTCommodityRepository;
            _EmployerSTCommodityManager = EmployerSTCommodityManager;
        }
        // GET: api/<EmployerSTCommodityController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployerSTCommodity>> GetSTCommodity(string id)
        {
            var STCommodity = await _EmployerSTCommodityRepository.GetByIdAsync(id);

            if (STCommodity == null)
            {
                return NotFound();
            }
            var GetEmployerSTCommodity = ModelToDTO<STCommodity, EmployerSTCommodity>.ConvertToDTO(STCommodity, new EmployerSTCommodity());
            return GetEmployerSTCommodity;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployerSTCommodity>>> Gets()
        {
            var STCommoditys = await _EmployerSTCommodityRepository.GetToListAsync();
            if (STCommoditys.Count == 0)
            {
                return new List<EmployerSTCommodity>();
            }
            List<EmployerSTCommodity> EmployerSTCommoditys = new List<EmployerSTCommodity>();
            foreach (var STCommodity in STCommoditys)
            {
                EmployerSTCommoditys.Add(ModelToDTO<STCommodity, EmployerSTCommodity>.ConvertToDTO(STCommodity, new EmployerSTCommodity()));
            }
            return EmployerSTCommoditys;
        }
        [HttpGet("User")]
        public async Task<ActionResult<IEnumerable<EmployerSTCommodity>>> GetsAsyncByUserId(string userid)
        {
            var STCommoditys = await _EmployerSTCommodityRepository.GetToListByUserId(userid);
            if (STCommoditys.Count == 0)
            {
                return new List<EmployerSTCommodity>();
            }
            List<EmployerSTCommodity> EmployerSTCommoditys = new List<EmployerSTCommodity>();
            foreach (var STCommodity in STCommoditys)
            {
                EmployerSTCommoditys.Add(ModelToDTO<STCommodity, EmployerSTCommodity>.ConvertToDTO(STCommodity, new EmployerSTCommodity()));
            }
            return EmployerSTCommoditys;
        }

        [HttpPost]
        public async Task<ActionResult<EmployerSTCommodity>> PostSTCommodity(EmployerSTCommodity EmployerSTCommodity)
        {
            var model = DTOToModel<EmployerSTCommodity, STCommodity>.ConvertToModel(EmployerSTCommodity, new());
            var newSTCommodity = await _EmployerSTCommodityManager.CreateAsync(model);

            //return CreatedAtAction("GetSTCommodity", new { id = STCommodity.Id }, STCommodity);
            return CreatedAtAction(nameof(GetSTCommodity), new { id = newSTCommodity.Id }, newSTCommodity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSTCommodity(string id, EmployerSTCommodity EmployerSTCommodity)
        {
            var model = DTOToModel<EmployerSTCommodity, STCommodity>.ConvertToModel(EmployerSTCommodity, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _EmployerSTCommodityManager.UpdateAsync(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSTCommodity(string id)
        {
            var STCommodity = await _EmployerSTCommodityRepository.GetByIdAsync(id);
            if (STCommodity == null)
            {
                return NotFound();
            }
            await _EmployerSTCommodityRepository.DeleteByIdAsync(STCommodity.Id);

            return NoContent();
        }
    }
}
