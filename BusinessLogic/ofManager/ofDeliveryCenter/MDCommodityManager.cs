using BusinessData.ofDeliveryCenter;
using BusinessData.ofRepository;
using BusinessLogic.ofManager.ofDeliveryCenter.ofBlobStorage;
using BusinessLogic.ofManager.ofDeliveryCenter.ofFileFactory;
using BusinessLogic.ofManager.ofDeliveryCenter.ofIdFactory;
using BusinessLogic.ofManager.ofGeneric;

namespace BusinessLogic.ofManager.ofDeliveryCenter
{
    [DataManager(typeof(MDCommodity))]
    public class MDCommodityManager : StatusManager<MDCommodity>
    {
        public MDCommodityManager(IMDCommodityRepository statusDataRepository,     
            IMDCommodityIdFactory mDCommodityIdFatory,
                               IMDCommodityFileFactory statusFileFactory,
                               IMDCommodityBlobStorage blobStorage,
                            DicConvertFactory<MDCommodity> dicConvertFactory)
            : base(statusDataRepository, mDCommodityIdFatory, statusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}