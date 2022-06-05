using BusienssData.ofPresentationLayer.ofController.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofPresentationLayer.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessLogic.ofEntityDTOManager.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusienssLogic.ofController.ofGeneric
{
    // 여기 친구는 Rouing 을 할 정도가 아니야
    // Rouing은 구체적인 이름이 붙어야 돼.
    public interface ICenterDTOController<DTO> : IEntityDTOController<DTO> where DTO : CenterDTO, new()
    {
    }

    [ApiController]
    public class CenterDTOController<DTO, Model> : ControllerBase, ICenterDTOController<DTO> where DTO : CenterDTO, new() where Model : Center, new()
    {
        protected readonly ILogger<DTO> _logger;
        protected readonly ICenterDTOManager<DTO, Model> _CenterManager;
        protected readonly IConfiguration _configuration;

        public CenterDTOController(ILogger<DTO> logger, ICenterDTOManager<DTO, Model> CenterManager,
                                        IConfiguration configuration)
        {
            _logger = logger;
            _CenterManager = CenterManager;
            _configuration = configuration;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<DTO>> GetById(string id)
        {
            _logger.LogInformation(nameof(CenterDTOController<DTO, Model>.GetById));
            // 이 과정에서 바로 _CenterManager 에게 가는 게 아니라 중간 저장소에 값이 있는지 확인을 할 필요가 있다는 거지.
            // 지금은 일단 이런 식으로 만들고.
            Model model = await _CenterManager.GetByIdAsync(id);
            if (model == null)
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
        [HttpPost("Searching")]
        public async Task<ActionResult<IEnumerable<DTO>>> GetByDTO([FromBody] CenterQuery<DTO> query)
        {
            // CenterManager 가 Get 부분에 있어 CenterDataRepository 만큼 할 일이 별로 없어서
            // CenterManager 내부에서 상기 코드가 처리되는 게 있었으면 한다.
            _logger.LogInformation(nameof(CenterDTOController<DTO, Model>.GetByDTO));
            List<DTO> dtos = new();
            if (dtos.Count > 0)
            {
                return new List<DTO>();
            }
            return dtos;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DTO>>> GetAlls()
        {
            // 여기는 중간 저장소를 볼 게 아니라 바로 DB 쪽 데이터에서 가져오도록 하자.
            _logger.LogInformation(nameof(CenterDTOController<DTO, Model>.GetAlls));
            var models = await _CenterManager.GetToListAsync();
            if (models.Count == 0)
            {
                return new List<DTO>();
            }
            List<DTO> dtos = new();
            foreach (var model in models)
            {
                dtos.Add(ModelToDTO<Model, DTO>.ConvertToDTO(model, new DTO()));
            }
            return dtos;
        }
        [HttpPost]
        public async Task<ActionResult<DTO>> Post([FromBody] DTO dto)
        {
            _logger.LogInformation(nameof(CenterDTOController<DTO, Model>.Post));
            var ConvertedModel = dto.ConvertToModel<Model, DTO>();
            var newModel = await _CenterManager.CreateAsync(ConvertedModel);
            if (newModel != null)
            {
                return newModel.ConvertToDTO<DTO, Model>();
            }
            throw new ArgumentException("Post Failed");
        }
        [HttpPut]
        public async Task<ActionResult<DTO>> Put([FromBody] DTO dto)
        {
            _logger.LogInformation(nameof(CenterDTOController<DTO, Model>.Put));
            var updatedModel = await _CenterManager.UpdateAsync(dto.ConvertToModel<Model, DTO>());
            if (updatedModel == null)
            {
                return BadRequest();
            }
            // 중간 저장소에 같은 Id를 가지는 값이 있다면 삭제하고 삽입
            return updatedModel.ConvertToDTO<DTO, Model>();
        }
        [HttpDelete]
        public async Task Delete(string id)
        {
            _logger.LogInformation(nameof(CenterDTOController<DTO, Model>.Delete));
            var deletedModel = _CenterManager.GetByIdAsync(id);
            if (deletedModel == null)
            {
                return;
            }
            await _CenterManager.DeleteByIdAsync(id);
        }

        public Task<ActionResult<IEnumerable<DTO>>> GetByDTO([FromBody] EntityQuery<DTO> query)
        {
            throw new NotImplementedException();
        }
    }
}