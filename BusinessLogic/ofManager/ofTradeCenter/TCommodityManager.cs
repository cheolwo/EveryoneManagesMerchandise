using BusinessData.ofTrade.ofModel;
using BusinessData.ofTrade.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofTradeCenter.ofBlobStorage;
using BusinessLogic.ofManager.ofTradeCenter.ofFileFactory;
using BusinessLogic.ofManager.ofTradeCenter.ofIdFactory;
using BusinessLogic.ofManager.ofTradeCenter.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofTradeCenter.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofTradeCenter.ofInterface.ofPlatform;

namespace BusinessLogic.ofManager.ofTradeCenter
{
    public interface ITCommodityManager : ICommodityManager<TCommodity>
    {

    }
    public class TCommodityManager : CommodityManager<TCommodity>, IEmployerTCommodityManager, IEmployeeTCommodityManager, IPlatformTCommodityManager
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