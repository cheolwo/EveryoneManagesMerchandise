using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofWarehouse.ofBlobStorage;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;
using BusinessLogic.ofManager.ofWarehouse.ofIdFactory;

namespace BusinessLogic.ofManager.ofWarehouse
{
    public interface IWCommodityManager
    {

    }
    public class WCommodityManager : CommodityManager<WCommodity>
    {
        public WCommodityManager(IWCommodityRepository CommodityDataRepository,
            IWCommodityIdFactory wCommodityIdFactory,
                               IWCommodityFileFactory CommodityFileFactory,
                               IWCommodityBlobStorage blobStorage,
                            DicConvertFactory<WCommodity> dicConvertFactory)
            : base(CommodityDataRepository, wCommodityIdFactory, CommodityFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}