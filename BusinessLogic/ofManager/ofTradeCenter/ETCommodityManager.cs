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
    public interface IETCommodityManager : IEStatusManager<ETCommodity>
    {

    }
    public class ETCommodityManager : EStatusManager<ETCommodity>, IEmployerETCommodityManager, IEmployeeETCommodityManager, IPlatformETCommodityManager, IETCommodityManager
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