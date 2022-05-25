namespace BusienssLogic.ofController.ofGeneric
{
    // 여기 친구는 Rouing 을 할 정도가 아니야
    // Rouing은 구체적인 이름이 붙어야 돼.
    public interface IEntityDTOController
    {
        
    }
    [ApiController]
    public class EntiyDTOController<DTO, Model> : ControllerBase where DTO : EntityDTO where Model : Entity
    {
        protected readonly ILogger<DTO> _logger;
        protected readonly IEntityManager<Model> _entityManager;
        protected readonly IConfiguration _configuration;
        // configurationa 이라는 친구는 AzureBlbobStorage ConnectionString 에 접근하는 역할을 담당하는 것이지.
        // 이외 추가적으로 Singleton 으로 운영되는 메모리 저장소가 있으면 좋겟다.

        public EntityDTOController(ILogger<DTO> logger, IEntityManager<Model> entityManager,
                                        IConfiguration configuration)
        {
            _logger = logger;
            _entityManager = entityManager;
            _configuration = configuration;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<DTO>> GetById(string id)
        {
            _logger.LogInformation(nameof(EntiyDTOController<DTO>.GetById));
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
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DTO>>> GetAlls()
        {
            // 여기는 중간 저장소를 볼 게 아니라 바로 DB 쪽 데이터에서 가져오도록 하자.
            _logger.LogInformation(nameof(EntiyDTOController<DTO>.GetAlls));
            var models = await _entityManager.GetToListAsync();
            if(Entities.Count == 0)
            {
                return new List<Model>();
            }
            List<DTO> dtos = new();
            foreach(var model in models)
            {
                dtos.Add(ModelToDTO<Model, DTO>.ConvertToDTO(model, new DTO()));
            }
            return dtos;
        }
        [HttpPost]
        public async Task<ActionResult<DTO>> Post([FromBody]Model model)
        {
            _logger.LogInformation(nameof(EntiyDTOController<DTO>.Post));
            
            var newModel = _entityManager.CreateAsync(model);
            if(newModel != null)
            {
                // 중간 저장소에 저장하는 로직을 포함할 필요감 있음.
                var dto = ModelToDTO<Model, DTO>.ConvertToDTO(newModel, new DTO());
                return dto;
            }
            _logger.LogInformation(nameof(newModel));
        }
        [HttpPut]
        public async Task<ActionResult<DTO>> Put([FromBody]Model model)
        {
            _logger.LogInformation(nameof(EntiyDTOController<DTO>.Put));
            var updatedModel = _entityManager.UpdateAsync(model);
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
            _logger.LogInformation(nameof(EntiyDTOController<DTO>.Delete));
            var deletedModel = _entityManager.GetByIdAsync(id);
            if(deletedModel == null)
            {
                return NotFound();
            }
            await _entityManager.DeleteAsync(deletedModel);
        }
    }
}