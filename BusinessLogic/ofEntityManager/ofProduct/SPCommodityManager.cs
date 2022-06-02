using BusinessData.ofProduct.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessLogic.ofEntityManager.ofProduct.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofProduct.ofInterface.ofEmployee;
using BusinessLogic.ofEntityManager.ofProduct.ofInterface.ofEmployer;
using BusinessLogic.ofEntityManager.ofProduct.ofInterface.ofPlatform;
using BusinessLogic.ofEntityManager.ofProduct.ofFileFactory;
using BusinessData.ofDataAccessLayer.ofProduct;
using BusinessLogic.ofEntityManager.ofProduct.ofIdFactory;

namespace BusinessLogic.ofEntityManager.ofProduct
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