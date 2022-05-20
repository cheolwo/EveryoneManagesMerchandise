using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessView.ofTrade.ofEmployer;
using BusinessLogic.ofManager.ofTradeCenter.ofInterface.ofEmployer;
using BusinessData.ofTrade.ofinterface.ofEmployer;
using BusinessData.ofTrade.ofModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TradeServer.Controllers.ofEmployer
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerTCommodityController : ControllerBase
    {
        private readonly ILogger<EmployerTCommodityController> _logger;
        private readonly IEmployerTCommodityManager _EmployerTCommodityManager;
        private readonly IEmployerTCommodityRepository _EmployerTCommodityRepository;

        public EmployerTCommodityController(ILogger<EmployerTCommodityController> logger,
            IEmployerTCommodityManager EmployerTCommodityManager, 
            IEmployerTCommodityRepository EmployerTCommodityRepository)
        {
            _logger = logger;
            _EmployerTCommodityRepository = EmployerTCommodityRepository;
            _EmployerTCommodityManager = EmployerTCommodityManager;
        }
        // GET: api/<EmployerTCommodityController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployerTCommodity>> GetTCommodity(string id)
        {
            var TCommodity = await _EmployerTCommodityRepository.GetByIdAsync(id);

            if (TCommodity == null)
            {
                return NotFound();
            }
            var GetEmployerTCommodity = ModelToDTO<TCommodity, EmployerTCommodity>.ConvertToDTO(TCommodity, new EmployerTCommodity());
            return GetEmployerTCommodity;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployerTCommodity>>> Gets()
        {
            var TCommoditys = await _EmployerTCommodityRepository.GetToListAsync();
            if (TCommoditys.Count == 0)
            {
                return new List<EmployerTCommodity>();
            }
            List<EmployerTCommodity> EmployerTCommoditys = new List<EmployerTCommodity>();
            foreach (var TCommodity in TCommoditys)
            {
                EmployerTCommoditys.Add(ModelToDTO<TCommodity, EmployerTCommodity>.ConvertToDTO(TCommodity, new EmployerTCommodity()));
            }
            return EmployerTCommoditys;
        }
        [HttpGet("User")]
        public async Task<ActionResult<IEnumerable<EmployerTCommodity>>> GetsAsyncByUserId(string userid)
        {
            var TCommoditys = await _EmployerTCommodityRepository.GetToListByUserId(userid);
            if (TCommoditys.Count == 0)
            {
                return new List<EmployerTCommodity>();
            }
            List<EmployerTCommodity> EmployerTCommoditys = new List<EmployerTCommodity>();
            foreach (var TCommodity in TCommoditys)
            {
                EmployerTCommoditys.Add(ModelToDTO<TCommodity, EmployerTCommodity>.ConvertToDTO(TCommodity, new EmployerTCommodity()));
            }
            return EmployerTCommoditys;
        }

        [HttpPost]
        public async Task<ActionResult<EmployerTCommodity>> PostTCommodity(EmployerTCommodity EmployerTCommodity)
        {
            var model = DTOToModel<EmployerTCommodity, TCommodity>.ConvertToModel(EmployerTCommodity, new());
            var newTCommodity = await _EmployerTCommodityManager.CreateAsync(model);

            //return CreatedAtAction("GetTCommodity", new { id = TCommodity.Id }, TCommodity);
            return CreatedAtAction(nameof(GetTCommodity), new { id = newTCommodity.Id }, newTCommodity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTCommodity(string id, EmployerTCommodity EmployerTCommodity)
        {
            var model = DTOToModel<EmployerTCommodity, TCommodity>.ConvertToModel(EmployerTCommodity, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _EmployerTCommodityManager.UpdateAsync(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTCommodity(string id)
        {
            var TCommodity = await _EmployerTCommodityRepository.GetByIdAsync(id);
            if (TCommodity == null)
            {
                return NotFound();
            }
            await _EmployerTCommodityRepository.DeleteByIdAsync(TCommodity.Id);

            return NoContent();
        }
    }
}
