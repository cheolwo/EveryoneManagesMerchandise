using BusinessData;
using BusinessData.ofGeneric.ofIdFactory;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using System.Threading.Tasks;

namespace BusinessLogic.ofManager.ofGeneric
{
    public interface IStatusManager<TEntity> : IEntityManager<TEntity> where TEntity : Status, IRelationable
    {   
    }
    public class StatusManager<TEntity> : EntityManager<TEntity> , IStatusManager<TEntity> where TEntity : Status, IRelationable, new()
    {
        public StatusManager(IStatusDataRepository<TEntity> statusDataRepository,
            IStatusIdFactory<TEntity> statusIdFactory,
                            IStatusFileFactory<TEntity> statusFileFactory,
                            IEntityBlobStorage<TEntity> entityBlobStorage,
                            DicConvertFactory<TEntity> dicConvertFactory)
            : base(statusDataRepository, statusIdFactory, statusFileFactory, entityBlobStorage, dicConvertFactory)
        { }
        public override async Task<TEntity> CreateAsync(TEntity entity)
        {
            return await base.CreateAsync(entity);
        }
    }
}