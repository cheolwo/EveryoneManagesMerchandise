using System.Threading.Tasks;
using BusinessData.ofGenericRepository;

namespace BusinessData.ofGeneric.ofIdFactory
{
    public interface ICommodityIdFactory<TEntity> : IEntityIdFactory<TEntity> where TEntity: Commodity, IRelationable
    {

    }
    public class CommodityIdFactory<TEntity> : EntityIdFactory<TEntity>, ICommodityIdFactory<TEntity> where TEntity : Commodity, IRelationable, new()
    {
        public CommodityIdFactory(ICommodityDataRepository<TEntity> commodityDataRepository)
            : base(commodityDataRepository)
        {

        }
        public override async Task<string> CreateIdByRelationEntity(TEntity entity)
        {
            return await base.CreateIdByRelationEntity(entity);
        }
    }
}