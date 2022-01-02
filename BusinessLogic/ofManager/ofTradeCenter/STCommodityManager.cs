using BusinessData.ofTrade.ofModel;
using BusinessData.ofTrade.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofTradeCenter.ofBlobStorage;
using BusinessLogic.ofManager.ofTradeCenter.ofFileFactory;
using BusinessLogic.ofManager.ofTradeCenter.ofIdFactory;

namespace BusinessLogic.ofManager.ofTradeCenter
{
    public interface ISTCommodityManager
    {

    }
    public class STCommodityManager : StatusManager<STCommodity>
    {
        public STCommodityManager(ISTCommodityRepository StatusDataRepository,
            ISTCommodityIdFactory sTCommodityIdFactory,
                               ISTCommodityFileFactory StatusFileFactory,
                               ISTCommodityBlobStorage blobStorage,
                            DicConvertFactory<STCommodity> dicConvertFactory)
            : base(StatusDataRepository, sTCommodityIdFactory, StatusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}