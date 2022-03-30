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
    public interface ISTCommodityManager : ISStatusManager<STCommodity>
    {

    }
    public class STCommodityManager : SStatusManager<STCommodity>, IEmployerSTCommodityManager, IEmployeeSTCommodityManager, IPlatformSTCommodityManager, ISTCommodityManager
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