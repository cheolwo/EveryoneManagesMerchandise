using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofWarehouse.ofBlobStorage;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;
using BusinessLogic.ofManager.ofWarehouse.ofIdFactory;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofPlatform;

namespace BusinessLogic.ofManager.ofWarehouse
{
    public interface IWCommodityManager : ICommodityManager<WCommodity>
    {

    }
    public class WCommodityManager : CommodityManager<WCommodity>, IEmployerWCommodityManager, IEmployeeWCommodityManager, IPlatformWCommodityManager
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