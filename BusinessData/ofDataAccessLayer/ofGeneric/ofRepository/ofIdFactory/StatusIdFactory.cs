using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using System.Threading.Tasks;

namespace BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory
{
    public interface IStatusIdFactory<TEntity> : IEntityIdFactory<TEntity> where TEntity: Status
    {

    }
    public class StatusIdFactory<TEntity> : EntityIdFactory<TEntity>, IStatusIdFactory<TEntity> where TEntity : Status,  new()
    {
        public StatusIdFactory(IStatusDataRepository<TEntity> statusDataRepository)
            : base(statusDataRepository)
        {

        }
        public override async Task<string> CreateIdByRelationEntity(TEntity entity)
        {
            return await base.CreateIdByRelationEntity(entity);
        }
    }
}