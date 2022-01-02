using BusinessData.ofTrade.ofModel;
using BusinessData.ofTrade.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofTradeCenter.ofBlobStorage;
using BusinessLogic.ofManager.ofTradeCenter.ofFileFactory;
using BusinessLogic.ofManager.ofTradeCenter.ofIdFactory;

namespace BusinessLogic.ofManager.ofTradeCenter
{
    public interface ITCommodityManager
    {

    }
    public class TCommodityManager : CommodityManager<TCommodity>
    {
        public TCommodityManager(ITCommodityRepository CommodityDataRepository,
            ITCommodityIdFactory TCommodityIdFactory,
                               ITCommodityFileFactory CommodityFileFactory,
                               ITCommodityBlobStorage blobStorage,
                            DicConvertFactory<TCommodity> dicConvertFactory)
            : base(CommodityDataRepository, TCommodityIdFactory, CommodityFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}