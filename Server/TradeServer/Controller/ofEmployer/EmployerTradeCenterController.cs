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
    public class EmployerTradeCenterController : ControllerBase
    {
        private readonly ILogger<EmployerTradeCenterController> _logger;
        private readonly IEmployerTradeCenterManager _EmployerTradeCenterManager;
        private readonly IEmployerTradeCenterRepository _EmployerTradeCenterRepository;

        public EmployerTradeCenterController(ILogger<EmployerTradeCenterController> logger,
            IEmployerTradeCenterManager EmployerTradeCenterManager, 
            IEmployerTradeCenterRepository EmployerTradeCenterRepository)
        {
            _logger = logger;
            _EmployerTradeCenterRepository = EmployerTradeCenterRepository;
            _EmployerTradeCenterManager = EmployerTradeCenterManager;
        }
        // GET: api/<EmployerTradeCenterController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployerTradeCenter>> GetTradeCenter(string id)
        {
            var TradeCenter = await _EmployerTradeCenterRepository.GetByIdAsync(id);

            if (TradeCenter == null)
            {
                return NotFound();
            }
            var GetEmployerTradeCenter = ModelToDTO<TradeCenter, EmployerTradeCenter>.ConvertToDTO(TradeCenter, new EmployerTradeCenter());
            return GetEmployerTradeCenter;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployerTradeCenter>>> Gets()
        {
            var TradeCenters = await _EmployerTradeCenterRepository.GetToListAsync();
            if (TradeCenters.Count == 0)
            {
                return new List<EmployerTradeCenter>();
            }
            List<EmployerTradeCenter> EmployerTradeCenters = new List<EmployerTradeCenter>();
            foreach (var TradeCenter in TradeCenters)
            {
                EmployerTradeCenters.Add(ModelToDTO<TradeCenter, EmployerTradeCenter>.ConvertToDTO(TradeCenter, new EmployerTradeCenter()));
            }
            return EmployerTradeCenters;
        }
        [HttpGet("User")]
        public async Task<ActionResult<IEnumerable<EmployerTradeCenter>>> GetsAsyncByUserId(string userid)
        {
            var TradeCenters = await _EmployerTradeCenterRepository.GetToListByUserIdAsync(userid);
            if (TradeCenters.Count == 0)
            {
                return new List<EmployerTradeCenter>();
            }
            List<EmployerTradeCenter> EmployerTradeCenters = new List<EmployerTradeCenter>();
            foreach (var TradeCenter in TradeCenters)
            {
                EmployerTradeCenters.Add(ModelToDTO<TradeCenter, EmployerTradeCenter>.ConvertToDTO(TradeCenter, new EmployerTradeCenter()));
            }
            return EmployerTradeCenters;
        }

        [HttpPost]
        public async Task<ActionResult<EmployerTradeCenter>> PostTradeCenter(EmployerTradeCenter EmployerTradeCenter)
        {
            var model = DTOToModel<EmployerTradeCenter, TradeCenter>.ConvertToModel(EmployerTradeCenter, new());
            var newTradeCenter = await _EmployerTradeCenterManager.CreateAsync(model);

            //return CreatedAtAction("GetTradeCenter", new { id = TradeCenter.Id }, TradeCenter);
            return CreatedAtAction(nameof(GetTradeCenter), new { id = newTradeCenter.Id }, newTradeCenter);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTradeCenter(string id, EmployerTradeCenter EmployerTradeCenter)
        {
            var model = DTOToModel<EmployerTradeCenter, TradeCenter>.ConvertToModel(EmployerTradeCenter, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _EmployerTradeCenterManager.UpdateAsync(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTradeCenter(string id)
        {
            var TradeCenter = await _EmployerTradeCenterRepository.GetByIdAsync(id);
            if (TradeCenter == null)
            {
                return NotFound();
            }
            await _EmployerTradeCenterRepository.DeleteByIdAsync(TradeCenter.Id);

            return NoContent();
        }
    }
}
