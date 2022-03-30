using BusinessData.ofDeliveryCenter;
using BusinessData.ofRepository;
using BusinessLogic.ofManager.ofDeliveryCenter.ofBlobStorage;
using BusinessLogic.ofManager.ofDeliveryCenter.ofFileFactory;
using BusinessLogic.ofManager.ofDeliveryCenter.ofIdFactory;
using BusinessLogic.ofManager.ofDeliveryCenter.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofDeliveryCenter.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofDeliveryCenter.ofInterface.ofPlatform;
using BusinessLogic.ofManager.ofGeneric;

namespace BusinessLogic.ofManager.ofDeliveryCenter
{
    public interface ISDCommodityManager : ISStatusManager<SDCommodity>
    {

    }
    [DataManager(typeof(SDCommodity))]
    public class SDCommodityManager : SStatusManager<SDCommodity>, IEmployerSDCommodityManager, IEmployeeSDCommodityManager, IPlatformSDCommodityManager, ISDCommodityManager
    {
        public SDCommodityManager(ISDCommodityRepository statusDataRepository, 
            ISDCommodityIdFactory sDCommodityIdFactory,
                               ISDCommodityFileFactory statusFileFactory,
                               ISDCommodityBlobStorage blobStorage,
                            DicConvertFactory<SDCommodity> dicConvertFactory)
            : base(statusDataRepository, sDCommodityIdFactory, statusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}