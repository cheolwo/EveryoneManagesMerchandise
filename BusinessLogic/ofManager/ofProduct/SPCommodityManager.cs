using BusinessData.ofMarket.ofRepository.ofIdFactory;
using BusinessData.ofProduct;
using BusinessData.ofProduct.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofProduct.ofBlobStorage;
using BusinessLogic.ofManager.ofProduct.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofProduct.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofProduct.ofInterface.ofPlatform;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;

namespace BusinessLogic.ofManager.ofProduct
{
    public interface ISPCommodityManager : ISStatusManager<SPCommodity>
    {

    }
    public class SPCommodityManager : SStatusManager<SPCommodity>, IEmployerSPCommodityManager, IEmployeeSPCommodityManager, IPlatformSPCommodityManager, ISPCommodityManager
    {
        private readonly ISPCommodityRepository _SPCommodityRepository;
        public SPCommodityManager(ISPCommodityRepository SPCommodityRepository,
                               ISPCommodityIdFactory SPCommodityIdFactory,
                               ISPCommodityFileFactory SPCommodityFileFactory,
                               ISPCommodityBlobStorage blobStorage,
                            DicConvertFactory<SPCommodity> dicConvertFactory)
            : base(SPCommodityRepository, SPCommodityIdFactory, SPCommodityFileFactory, blobStorage, dicConvertFactory)
        {
            _SPCommodityRepository = SPCommodityRepository;
        }
    }
}