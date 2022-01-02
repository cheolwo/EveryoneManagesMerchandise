using BusinessData.ofOrder.ofModel;
using BusinessData.ofOrder.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofOrder.ofBlobStorage;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;
using BusinessLogic.ofManager.ofWarehouse.ofIdFactory;

namespace BusinessLogic.ofManager.ofOrder
{
    public interface IOCommodityManager : ICommodityManager<OCommodity>
    {
    }
    public class OCommodityManager : CommodityManager<OCommodity>, IOCommodityManager
    {
        private readonly IOCommodityRepository _OCommodityRepository;
        public OCommodityManager(IOCommodityRepository OCommodityRepository,
                               IOCommodityIdFactory OCommodityIdFactory,
                               IOCommodityFileFactory OCommodityFileFactory,
                               IOCommodityBlobStorage blobStorage,
                            DicConvertFactory<OCommodity> dicConvertFactory)
            : base(OCommodityRepository, OCommodityIdFactory, OCommodityFileFactory, blobStorage, dicConvertFactory)
        {
        }
    }
}
