using BusinessData;
using BusinessData.ofGeneric.ofIdFactory;
using BusinessData.ofGenericRepository;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace BusinessLogic.ofManager.ofGeneric
{
    public interface ICommodityManager<TEntity> : IEntityManager<TEntity> where TEntity : Commodity, IRelationable
    {   
        Task<Dictionary<string, List<TEntity>>> ExcelToCommodityEntities(string fileconnectionString, Dictionary<PropertyInfo, int> Target,
                                            int UserCodeTarget);
    }
    public class CommodityManager<TEntity> : EntityManager<TEntity>, ICommodityManager<TEntity> 
                                                                where TEntity : Commodity, IRelationable, new()
    {
        private readonly ICommodityFileFactory<TEntity> _commodityFileFactory;
        private readonly ICommodityIdFactory<TEntity> _commodiyIdFactory;
        public CommodityManager(ICommodityDataRepository<TEntity> commodityDataRepository,
            ICommodityIdFactory<TEntity> commodityIdFactory,
                            ICommodityFileFactory<TEntity> commodityFileFactory,
                            IEntityBlobStorage<TEntity> entityBlobStorage,
                            DicConvertFactory<TEntity> dicConvertFactory)
            : base(commodityDataRepository, commodityIdFactory, commodityFileFactory, entityBlobStorage, dicConvertFactory)
        {
            _commodityFileFactory = commodityFileFactory;
            _commodiyIdFactory = commodityIdFactory;
        }
        // public override async Task<TEntity> CreateAsync(TEntity entity)
        // {
        //     return await base.CreateAsync(entity);
        // }
        public async Task<Dictionary<string, List<TEntity>>> ExcelToCommodityEntities(string fileconnectionString, Dictionary<PropertyInfo, int> Target,
                                            int UserCodeTarget)
        {
            int count = await _EntityDataRepository.GetCountAsync();
            var datas = _EntityFileFactory.InitExcelData(fileconnectionString);
            var CenterKeyCommodityValue = _commodityFileFactory.SetExcelCommodities(datas, Target, UserCodeTarget);
            return _commodiyIdFactory.SetCenterKeyCommodityValueId(CenterKeyCommodityValue, count);
        }
    }
}