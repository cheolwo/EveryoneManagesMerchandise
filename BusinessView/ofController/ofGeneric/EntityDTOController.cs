using BusinessData;
using BusinessLogic.ofManager.ofGeneric;
using BusinessView.ofDTO.ofCommon;
using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
namespace BusienssView.ofController.ofGeneric
{
    // 여기 친구는 Rouing 을 할 정도가 아니야
    // Rouing은 구체적인 이름이 붙어야 돼.
    public interface IEntityDTOController
    {
        
    }
    [ApiController]
    public class EntiyDTOController<DTO, Model> : ControllerBase where DTO : EntityDTO, new() where Model : Entity, new()
    {
        protected readonly ILogger<DTO> _logger;
        protected readonly IEntityDTOManager<DTO, Model> _entityManager;
        protected readonly IEntityDataRepository<Model> _entiyDataRepository;
        protected readonly IConfiguration _configuration;
        // configurationa 이라는 친구는 AzureBlbobStorage ConnectionString 에 접근하는 역할을 담당하는 것이지.
        // 이외 추가적으로 Singleton 으로 운영되는 메모리 저장소가 있으면 좋겟다.

        public EntiyDTOController(ILogger<DTO> logger, IEntityDTOManager<DTO, Model> entityManager,
                                        IEntityDataRepository<Model> entityDataRepository,
                                        IConfiguration configuration)
        {
            _logger = logger;
            _entityManager = entityManager;
            _configuration = configuration;
            _entiyDataRepository = entityDataRepository;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<DTO>> GetById(string id)
        {
            _logger.LogInformation(nameof(EntiyDTOController<DTO, Model>.GetById));
            // 이 과정에서 바로 _entityManager 에게 가는 게 아니라 중간 저장소에 값이 있는지 확인을 할 필요가 있다는 거지.
            // 지금은 일단 이런 식으로 만들고.
            Model model = await _entityManager.GetByIdAsync(id);
            if(model == null)
            {
                _logger.LogInformation(nameof(NotFound));
                return NotFound();
            }
            _logger.LogInformation(nameof(model));
            var dto = ModelToDTO<Model, DTO>.ConvertToDTO(model, new DTO());
            return dto;
        }
        // 사전에 분류가 되어 있으면 좋겠다.
        // prop 의 Attribute를 보고 어떻게 Get를 할지에 대해.
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DTO>>> GetByDTO(DTO dto)
        {
            // EntityManager 가 Get 부분에 있어 EntityDataRepository 만큼 할 일이 별로 없어서
            // EntityManager 내부에서 상기 코드가 처리되는 게 있었으면 한다.
            _logger.LogInformation(nameof(EntiyDTOController<DTO, Model>.GetByDTO));
            List<DTO> dtos = await _entityManager.GetToListAsync(dto);
            if(dtos.Count > 0)
            {
                return new List<DTO>();
            }
            return dtos;
            // List<DTO> dtos = new();
            // var distributed = dto.GetByQueryAttribute().DistributedByQueryCode();
            // if(distributed[QueryCode.Key].Count > 0)
            // {
            //     var keyProp = distributed[QueryCode.Key].FirstOrDefault();
            //     var model = _entiyDataRepository.GetByIdAsync((string)keyProp.GetValue(dto));
            //     if(model == null) {throw new ArgumentException("Model Is Null");}
            //     var dto = model.ConvertToDTO();
            //     return dtos.Add(dto);
            // }
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DTO>>> GetAlls()
        {
            // 여기는 중간 저장소를 볼 게 아니라 바로 DB 쪽 데이터에서 가져오도록 하자.
            _logger.LogInformation(nameof(EntiyDTOController<DTO, Model>.GetAlls));
            var models = await _entityManager.GetToListAsync();
            if(models.Count == 0)
            {
                return new List<DTO>();
            }
            List<DTO> dtos = new();
            foreach(var model in models)
            {
                dtos.Add(ModelToDTO<Model, DTO>.ConvertToDTO(model, new DTO()));
            }
            return dtos;
        }
        [HttpPost]
        public async Task<ActionResult<DTO>> Post([FromBody]DTO dto)
        {
            _logger.LogInformation(nameof(EntiyDTOController<DTO, Model>.Post));
            
            var newModel = await _entityManager.CreateAsync(dto);
            if(newModel != null)
            {              
                return newModel;
            }
            throw new ArgumentException("Post Failed");
            _logger.LogInformation(nameof(newModel));
        }
        [HttpPut]
        public async Task<ActionResult<DTO>> Put([FromBody]DTO dto)
        {
            _logger.LogInformation(nameof(EntiyDTOController<DTO, Model>.Put));
            var updatedModel = await _entityManager.UpdateAsync(dto);
            if(updatedModel == null)
            {
                return BadRequest();
            }
            // 중간 저장소에 같은 Id를 가지는 값이 있다면 삭제하고 삽입
            return updatedModel;
        }
        [HttpDelete]
        public async Task Delete(string id)
        {
            _logger.LogInformation(nameof(EntiyDTOController<DTO, Model>.Delete));
            var deletedModel = _entityManager.GetByIdAsync(id);
            if(deletedModel == null)
            {
                return;
            }
            await _entityManager.DeleteAsync(id);
        }
    }
}