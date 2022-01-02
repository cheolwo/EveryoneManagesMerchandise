using BusinessData.ofMarket.ofRepository.ofIdFactory;
using BusinessData.ofProduct;
using BusinessData.ofProduct.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofProduct.ofBlobStorage;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;

namespace BusinessLogic.ofManager.ofProduct
{
    public class PCommodityManager : CommodityManager<PCommodity>
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