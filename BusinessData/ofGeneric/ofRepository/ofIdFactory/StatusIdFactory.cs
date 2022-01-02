using System.Threading.Tasks;

namespace BusinessData.ofGeneric.ofIdFactory
{
    public interface IStatusIdFactory<TEntity> : IEntityIdFactory<TEntity> where TEntity: Status, IRelationable
    {

    }
    public class StatusIdFactory<TEntity> : EntityIdFactory<TEntity>, IStatusIdFactory<TEntity> where TEntity : Status, IRelationable, new()
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