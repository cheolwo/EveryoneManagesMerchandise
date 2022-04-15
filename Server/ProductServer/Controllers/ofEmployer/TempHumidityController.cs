using BusinessData;
using BusinessData.ofIot.Model;
using BusinessLogic.ofManager.ofGeneric;
using BusinessView.ofDTO.ofIotDTO;
using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductServer.Controllers.ofEmployer
{
    [Route("api/[controller]")]
    [ApiController]
    public class TempHumidityDTOController : ControllerBase
    {
        private readonly IEntityManager<TemperatureHumidity> _entityManager;
        private readonly IEntityDataRepository<TemperatureHumidity> _entityDataRepository;
       
        private Dictionary<int, TempHumidityDTO> DicDtos;
        private List<TempHumidityDTO> tempHumidityDTOs = new();

        public TempHumidityDTOController(IEntityManager<TemperatureHumidity> entityManager, IEntityDataRepository<TemperatureHumidity> entityDataRepository)
        {
            _entityManager = entityManager;
            _entityDataRepository = entityDataRepository;
            DicDtos = new();
        }
        // GET: api/<TempHumidityController>
        [HttpGet]
        public async Task<IEnumerable<TempHumidityDTO>> Get()
        {
            var ModelDatas = await _entityDataRepository.GetToListAsync();
            
            foreach(var model in ModelDatas)
            {
                var Dto = ModelToDTO<TemperatureHumidity, TempHumidityDTO>.ConvertToDTO(model, new TempHumidityDTO());
                if(DicDtos[Dto.Id.GetHashCode()] != null)
                {
                    continue;
                }
                else {DicDtos.Add(Dto.GetHashCode(), Dto); }
            }
            return tempHumidityDTOs;
        }

        // GET api/<TempHumidityController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TempHumidityController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TempHumidityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TempHumidityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
