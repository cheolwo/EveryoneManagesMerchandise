using BusinessData.ofMarket.ofModel;
using BusinessData.ofMarket.ofRepository;
using BusinessLogic.ofManager.ofDeliveryCenter.ofFileFactory;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofMarket.ofBlobStorage;
using BusinessLogic.ofManager.ofMarket.ofIdFactory;
using BusinessLogic.ofManager.ofMarket.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofMarket.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofMarket.ofInterface.ofPlatform;

namespace BusinessLogic.ofManager.ofMarket
{
    public interface ISMCommodityManager : ISStatusManager<SMCommodity>
    {

    }
    [DataManager(typeof(SMCommodity))]
    public class SMCommodityManager : SStatusManager<SMCommodity>, IEmployerSMCommodityManager, IEmployeeSMCommodityManager, IPaltformSMCommodityManager, ISMCommodityManager
    {
        public SMCommodityManager(ISMCommodityRepository statusDataRepository,
            ISMCommodityIdFactory sMCommodityIdFactory,
                               ISMCommodityFileFactory statusFileFactory,
                               ISMCommodityBlobStorage blobStorage,
                            DicConvertFactory<SMCommodity> dicConvertFactory)
            : base(statusDataRepository, sMCommodityIdFactory, statusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}