using BusinessData.ofDeliveryCenter;
using BusinessData.ofRepository;
using BusinessLogic.ofManager.ofDeliveryCenter.ofBlobStorage;
using BusinessLogic.ofManager.ofDeliveryCenter.ofFileFactory;
using BusinessLogic.ofManager.ofDeliveryCenter.ofIdFactory;
using BusinessLogic.ofManager.ofGeneric;

namespace BusinessLogic.ofManager.ofDeliveryCenter
{
    [DataManager(typeof(SDCommodity))]
    public class SDCommodityManager : StatusManager<SDCommodity>
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