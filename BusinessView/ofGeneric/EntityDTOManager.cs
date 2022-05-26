﻿using BusinessData;
using BusinessData.ofGeneric.ofIdFactory;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofGeneric
{
    public interface IEntityDTOManager<DTO> : EntityManager<Model> where DTO : EntityDTO, new() where Model : Entity, new()
    {
        Task<DTO> CreateAsync(DTO entityDTO);
        Task<DTO> UpdateAsync(DTO entityDTO);
        Task<List<DTO>> GetToListAsync(EntityQuery<DTO> entityQuery);
        Task DeleteAsync(string id);
    }
    public class EntityDTOManager<DTO, Model> : EntityManager<Model>, IEntityDTOManager<DTO, Model> where DTO : EntityDTO, new() where Model : Entity, new()
    {
        private readonly IEntityDataRepository<Model> _EntityDataRepository;
        public EntityDTOManager(IEntityDataRepository<Model> EntityDataRepository, 
            IEntityIdFactory<Model> EntityIdFactory, 
            IEntityFileFactory<Model> entityFileFactory, 
            IEntityBlobStorage<Model> EntityBlobStorage, 
            DicConvertFactory<Model> DicConvertFactory) : base(EntityDataRepository, EntityIdFactory, entityFileFactory, EntityBlobStorage, DicConvertFactory)
        {
            _EntityDataRepository = EntityDataRepository;
        }

        public Task<DTO> CreateAsync(DTO entityDTO)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }
        
        public Task<List<DTO>> GetToListAsyncByQuery(EntityQuery<DTO> entityQuery)
        {  
            // EntityQuery 를 Dictionary 로 분류하는 단계
            var QueryDic = entityQuery.GetByQueryAttirute().GetQueryDictionary();
            var dto = entityQuery.Dto;
            List<DTO> dtos = new();
            // 분류된 Dic을 EntityDataRepository 에 전달하는 단계
            List<Model> models = await _EntityDataRepository.QueryChaining(QueryDic, dto);
            if(models != null || models.Count > 0)
            {
                foreach(var model in models)
                {
                    dtos.Add(model.ConvertToDTO());
                }
            }
            return dtos;
        }

        public Task<DTO> UpdateAsync(DTO entityDTO)
        {
            throw new NotImplementedException();
        }
    }
}
