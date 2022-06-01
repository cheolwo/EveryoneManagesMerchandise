using BusinessData.ofTrade.ofModel;
using BusinessData.ofTrade.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofTradeCenter.ofBlobStorage;
using BusinessLogic.ofManager.ofTradeCenter.ofFileFactory;
using BusinessLogic.ofManager.ofTradeCenter.ofIdFactory;
using BusinessLogic.ofManager.ofTradeCenter.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofTradeCenter.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofTradeCenter.ofInterface.ofPlatform;

namespace BusinessLogic.ofManager.ofWarehouse
{
    public interface IMTCommodityManager : IMStatusManager<MTCommodity>
    {

    }
    public class MTCommodityManager : MStatusManager<MTCommodity>, IEmployerMTCommodityManager, IEmployeeMTCommodityManager, IPlatformMTCommodityManager, IMTCommodityManager
    {
        public MTCommodityManager(IMTCommodityRepository StatusDataRepository,
            IMTCommodityIdFactory mTCommodityIdFactory,
                               IMTCommodityFileFactory StatusFileFactory,
                               IMTCommodityBlobStorage blobStorage,
                            DicConvertFactory<MTCommodity> dicConvertFactory)
            : base(StatusDataRepository, mTCommodityIdFactory, StatusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}