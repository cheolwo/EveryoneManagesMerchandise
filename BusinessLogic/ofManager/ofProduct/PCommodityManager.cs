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
    public interface IPCommodityManager : ICommodityManager<PCommodity>
    {

    }
    public class PCommodityManager : CommodityManager<PCommodity>, IEmployerPCommodityManager, IEmployeePCommodityManager, IPlatformPCommodityManager, IPCommodityManager
    {
        private readonly IPCommodityRepository _PCommodityRepository;
        public PCommodityManager(IPCommodityRepository PCommodityRepository,
                               IPCommodityIdFactory PCommodityIdFactory,
                               IPCommodityFileFactory PCommodityFileFactory,
                               IPCommodityBlobStorage blobStorage,
                            DicConvertFactory<PCommodity> dicConvertFactory)
            : base(PCommodityRepository, PCommodityIdFactory, PCommodityFileFactory, blobStorage, dicConvertFactory)
        {
            _PCommodityRepository = PCommodityRepository;
        }
    }
}