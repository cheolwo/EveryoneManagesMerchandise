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
    public interface IEDCommodityManager : IEStatusManager<EDCommodity>
    {

    }
    [DataManager(typeof(EDCommodity))]
    public class EDCommodityManager : EStatusManager<EDCommodity>, IEmployerEDCommodityManager, IEmployeeEDCommodityManager, IPlatformEDCommodityManager
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