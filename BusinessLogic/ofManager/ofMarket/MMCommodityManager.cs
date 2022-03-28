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
    public interface IMMCommodityManager : IMStatusManager<MMCommodity>
    {

    }
    [DataManager(typeof(MMCommodity))]
    public class MMCommodityManager : MStatusManager<MMCommodity>, IEmployerMMCommodityManager, IEmployeeMMCommodityManager, IPaltformMMCommodityManager
    {
        public MMCommodityManager(IMMCommodityRepository statusDataRepository,
            IMMCommodityIdFactory mMCommodityIdFactory,
                               IMMCommodityFileFactory statusFileFactory,
                               IMMCommodityBlobStorage blobStorage,
                            DicConvertFactory<MMCommodity> dicConvertFactory)
            : base(statusDataRepository, mMCommodityIdFactory, statusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}