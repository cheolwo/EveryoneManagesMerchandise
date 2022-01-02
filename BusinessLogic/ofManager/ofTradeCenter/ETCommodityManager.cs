using BusinessData.ofTrade.ofModel;
using BusinessData.ofTrade.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofTradeCenter.ofBlobStorage;
using BusinessLogic.ofManager.ofTradeCenter.ofFileFactory;
using BusinessLogic.ofManager.ofTradeCenter.ofIdFactory;

namespace BusinessLogic.ofManager.ofWarehouse
{
    public interface IETCommodityManager
    {

    }
    public class ETCommodityManager : StatusManager<ETCommodity>
    {
        public ETCommodityManager(IETCommodityRepository StatusDataRepository,
            IETCommodityIdFactory eTCommodityIdFactory,
                               IETCommodityFileFactory StatusFileFactory,
                               IETCommodityBlobStorage blobStorage,
                            DicConvertFactory<ETCommodity> dicConvertFactory)
            : base(StatusDataRepository, eTCommodityIdFactory, StatusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}