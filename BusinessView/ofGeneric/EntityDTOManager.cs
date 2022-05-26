using BusinessData;
using BusinessData.ofGeneric.ofIdFactory;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofGeneric
{
    public interface IEntityDTOManager<DTO, Model> : IEntityManager<Model> where DTO : EntityDTO, new() where Model : Entity, new()
    {
        Task<DTO> CreateAsync(DTO entityDTO);
        Task<DTO> UpdateAsync(DTO entityDTO);
        Task<List<DTO>> GetToListAsync(DTO entityDTO);
        Task DeleteAsync(string id);

    }
    public class EntityDTOManager<DTO, Model> : EntityManager<Model>, IEntityDTOManager<DTO, Model> where DTO : EntityDTO, new() where Model : Entity, new()
    {
        public EntityDTOManager(IEntityDataRepository<Model> EntityDataRepository, 
            IEntityIdFactory<Model> EntityIdFactory, 
            IEntityFileFactory<Model> entityFileFactory, 
            IEntityBlobStorage<Model> EntityBlobStorage, 
            DicConvertFactory<Model> DicConvertFactory) : base(EntityDataRepository, EntityIdFactory, entityFileFactory, EntityBlobStorage, DicConvertFactory)
        {
        }

        public Task<DTO> CreateAsync(DTO entityDTO)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<DTO>> GetToListAsync(DTO entityDTO)
        {
            throw new NotImplementedException();
        }

        public Task<DTO> UpdateAsync(DTO entityDTO)
        {
            throw new NotImplementedException();
        }
    }
}
