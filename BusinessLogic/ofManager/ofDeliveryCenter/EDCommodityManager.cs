using BusinessData.ofDeliveryCenter;
using BusinessData.ofRepository;
using BusinessLogic.ofManager.ofDeliveryCenter.ofBlobStorage;
using BusinessLogic.ofManager.ofDeliveryCenter.ofFileFactory;
using BusinessLogic.ofManager.ofDeliveryCenter.ofIdFactory;
using BusinessLogic.ofManager.ofGeneric;

namespace BusinessLogic.ofManager.ofDeliveryCenter
{
    [DataManager(typeof(EDCommodity))]
    public class EDCommodityManager : StatusManager<EDCommodity>
    {
        public EDCommodityManager(IEDCommodityRepository statusDataRepository,
            IEDCommodityIdFactory eDCommodityIdFactory,
                               IEDCommodityFileFactory statusFileFactory,
                               IEDCommodityBlobStorage blobStorage,
                            DicConvertFactory<EDCommodity> dicConvertFactory)
            : base(statusDataRepository, eDCommodityIdFactory, statusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}