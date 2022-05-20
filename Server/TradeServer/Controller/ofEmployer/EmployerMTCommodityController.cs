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
    public class EmployerMTCommodityController : ControllerBase
    {
        private readonly ILogger<EmployerMTCommodityController> _logger;
        private readonly IEmployerMTCommodityManager _EmployerMTCommodityManager;
        private readonly IEmployerMTCommodityRepository _EmployerMTCommodityRepository;

        public EmployerMTCommodityController(ILogger<EmployerMTCommodityController> logger,
            IEmployerMTCommodityManager EmployerMTCommodityManager, 
            IEmployerMTCommodityRepository EmployerMTCommodityRepository)
        {
            _logger = logger;
            _EmployerMTCommodityRepository = EmployerMTCommodityRepository;
            _EmployerMTCommodityManager = EmployerMTCommodityManager;
        }
        // GET: api/<EmployerMTCommodityController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployerMTCommodity>> GetMTCommodity(string id)
        {
            var MTCommodity = await _EmployerMTCommodityRepository.GetByIdAsync(id);

            if (MTCommodity == null)
            {
                return NotFound();
            }
            var GetEmployerMTCommodity = ModelToDTO<MTCommodity, EmployerMTCommodity>.ConvertToDTO(MTCommodity, new EmployerMTCommodity());
            return GetEmployerMTCommodity;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployerMTCommodity>>> Gets()
        {
            var MTCommoditys = await _EmployerMTCommodityRepository.GetToListAsync();
            if (MTCommoditys.Count == 0)
            {
                return new List<EmployerMTCommodity>();
            }
            List<EmployerMTCommodity> EmployerMTCommoditys = new List<EmployerMTCommodity>();
            foreach (var MTCommodity in MTCommoditys)
            {
                EmployerMTCommoditys.Add(ModelToDTO<MTCommodity, EmployerMTCommodity>.ConvertToDTO(MTCommodity, new EmployerMTCommodity()));
            }
            return EmployerMTCommoditys;
        }
        [HttpGet("User")]
        public async Task<ActionResult<IEnumerable<EmployerMTCommodity>>> GetsAsyncByUserId(string userid)
        {
            var MTCommoditys = await _EmployerMTCommodityRepository.GetToListByUserId(userid);
            if (MTCommoditys.Count == 0)
            {
                return new List<EmployerMTCommodity>();
            }
            List<EmployerMTCommodity> EmployerMTCommoditys = new List<EmployerMTCommodity>();
            foreach (var MTCommodity in MTCommoditys)
            {
                EmployerMTCommoditys.Add(ModelToDTO<MTCommodity, EmployerMTCommodity>.ConvertToDTO(MTCommodity, new EmployerMTCommodity()));
            }
            return EmployerMTCommoditys;
        }

        [HttpPost]
        public async Task<ActionResult<EmployerMTCommodity>> PostMTCommodity(EmployerMTCommodity EmployerMTCommodity)
        {
            var model = DTOToModel<EmployerMTCommodity, MTCommodity>.ConvertToModel(EmployerMTCommodity, new());
            var newMTCommodity = await _EmployerMTCommodityManager.CreateAsync(model);

            //return CreatedAtAction("GetMTCommodity", new { id = MTCommodity.Id }, MTCommodity);
            return CreatedAtAction(nameof(GetMTCommodity), new { id = newMTCommodity.Id }, newMTCommodity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMTCommodity(string id, EmployerMTCommodity EmployerMTCommodity)
        {
            var model = DTOToModel<EmployerMTCommodity, MTCommodity>.ConvertToModel(EmployerMTCommodity, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _EmployerMTCommodityManager.UpdateAsync(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMTCommodity(string id)
        {
            var MTCommodity = await _EmployerMTCommodityRepository.GetByIdAsync(id);
            if (MTCommodity == null)
            {
                return NotFound();
            }
            await _EmployerMTCommodityRepository.DeleteByIdAsync(MTCommodity.Id);

            return NoContent();
        }
    }
}
