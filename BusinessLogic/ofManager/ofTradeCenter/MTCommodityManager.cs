using BusinessData.ofTrade.ofModel;
using BusinessData.ofTrade.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofTradeCenter.ofBlobStorage;
using BusinessLogic.ofManager.ofTradeCenter.ofFileFactory;
using BusinessLogic.ofManager.ofTradeCenter.ofIdFactory;

namespace BusinessLogic.ofManager.ofWarehouse
{
    public interface IMTCommodityManager
    {

    }
    public class MTCommodityManager : StatusManager<MTCommodity>
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