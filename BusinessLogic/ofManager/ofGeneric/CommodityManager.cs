using BusinessData;
using BusinessData.ofGeneric.ofIdFactory;
using BusinessData.ofGenericRepository;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;

namespace BusinessLogic.ofManager.ofGeneric
{
    public interface ICommodityManager<TEntity> : IEntityManager<TEntity> where TEntity : Commodity, IRelationable
    {   
    }
    public class CommodityManager<TEntity> : EntityManager<TEntity>, ICommodityManager<TEntity> 
                                                                where TEntity : Commodity, IRelationable, new()
    {
        public CommodityManager(ICommodityDataRepository<TEntity> commodityDataRepository,
            ICommodityIdFactory<TEntity> commodityIdFactory,
                            ICommodityFileFactory<TEntity> commodityFileFactory,
                            IEntityBlobStorage<TEntity> entityBlobStorage,
                            DicConvertFactory<TEntity> dicConvertFactory)
            : base(commodityDataRepository, commodityIdFactory, commodityFileFactory, entityBlobStorage, dicConvertFactory)
        {
        
        }
        // public override async Task<TEntity> CreateAsync(TEntity entity)
        // {
        //     return await base.CreateAsync(entity);
        // }
    }
}