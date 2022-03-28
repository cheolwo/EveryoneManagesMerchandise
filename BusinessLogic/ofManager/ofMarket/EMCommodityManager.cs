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
    public interface IEMCommodityManager : IEStatusManager<EMCommodity>
    {

    }
    [DataManager(typeof(EMCommodity))]
    public class EMCommodityManager : EStatusManager<EMCommodity>, IEmployerEMCommodityManager, IEmployeeEMCommodityManager, IPaltformEMCommodityManager
    {
        public EMCommodityManager(IEMCommodityRepository statusDataRepository,
            IEMCommodityIdFactory eMCommodityIdFactory,
                               IEMCommodityFileFactory statusFileFactory,
                               IEMCommodityBlobStorage blobStorage,
                            DicConvertFactory<EMCommodity> dicConvertFactory)
            : base(statusDataRepository, eMCommodityIdFactory, statusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}