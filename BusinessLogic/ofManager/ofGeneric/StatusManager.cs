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
    public interface IMStatusManager<TEntity> : IStatusManager<TEntity> where TEntity : Status, IRelationable
    {
    }
    public interface IEStatusManager<TEntity> : IStatusManager<TEntity> where TEntity : Status, IRelationable
    {
    }
    public interface ISStatusManager<TEntity> : IStatusManager<TEntity> where TEntity : Status, IRelationable
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
    public class SStatusManager<TEntity> : EntityManager<TEntity>, ISStatusManager<TEntity> where TEntity : Status, IRelationable, new()
    {
        public SStatusManager(IStatusDataRepository<TEntity> statusDataRepository,
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
    public class MStatusManager<TEntity> : EntityManager<TEntity>, IMStatusManager<TEntity> where TEntity : Status, IRelationable, new()
    {
        public MStatusManager(IStatusDataRepository<TEntity> statusDataRepository,
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
    public class EStatusManager<TEntity> : EntityManager<TEntity>, IEStatusManager<TEntity> where TEntity : Status, IRelationable, new()
    {
        public EStatusManager(IStatusDataRepository<TEntity> statusDataRepository,
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