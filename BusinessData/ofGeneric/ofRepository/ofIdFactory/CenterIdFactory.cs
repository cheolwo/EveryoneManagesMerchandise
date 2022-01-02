using System.Threading.Tasks;

namespace BusinessData.ofGeneric.ofIdFactory
{
    public interface ICenterIdFactory<TEntity> : IEntityIdFactory<TEntity> where TEntity: Center, IRelationable
    {

    }
    public class CenterIdFactory<TEntity> : EntityIdFactory<TEntity>, ICenterIdFactory<TEntity> where TEntity : Center, IRelationable, new()
    {
        public CenterIdFactory(ICenterDataRepository<TEntity> entityDataRepository)
            : base(entityDataRepository)
        {

        }
        public override async Task<string> CreateIdByRelationEntity(TEntity entity)
        {
            return await base.CreateIdByRelationEntity(entity);
        }
    }
}