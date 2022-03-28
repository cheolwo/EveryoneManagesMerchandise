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
    public interface IMDCommodityManager : IMStatusManager<MDCommodity>
    {

    }
    [DataManager(typeof(MDCommodity))]
    public class MDCommodityManager : MStatusManager<MDCommodity>, IEmployerMDCommodityManager, IEmployeeMDCommodityManager, IPlatformMDCommodityManager
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