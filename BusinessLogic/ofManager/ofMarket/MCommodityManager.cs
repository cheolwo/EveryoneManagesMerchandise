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
    public interface IMCommodityManager : ICommodityManager<MCommodity>
    {

    }
    [DataManager(typeof(MCommodity))]
    public class MCommodityManager : CommodityManager<MCommodity>, IEmployerMCommodityManager, IEmployeeMCommodityManager, IPaltformMCommodityManager
    {
        public MCommodityManager(IMCommodityRepository CommodityDataRepository,
                               IMCommodityIdFactory mComodityIdFactory,
                               IMCommodityFileFactory CommodityFileFactory,
                               IMCommodityBlobStorage blobStorage,
                            DicConvertFactory<MCommodity> dicConvertFactory)
            : base(CommodityDataRepository, mComodityIdFactory, CommodityFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}