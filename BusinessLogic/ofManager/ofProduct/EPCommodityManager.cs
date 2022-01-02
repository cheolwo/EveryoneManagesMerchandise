using BusinessData.ofMarket.ofRepository.ofIdFactory;
using BusinessData.ofProduct;
using BusinessData.ofProduct.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofProduct.ofBlobStorage;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;

namespace BusinessLogic.ofManager.ofProduct
{
    public class EPCommodityManager : StatusManager<EPCommodity>
    {
        private readonly IEPCommodityRepository _EPCommodityRepository;
        public EPCommodityManager(IEPCommodityRepository EPCommodityRepository,
                               IEPCommodityIdFactory EPCommodityIdFactory,
                               IEPCommodityFileFactory EPCommodityFileFactory,
                               IEPCommodityBlobStorage blobStorage,
                            DicConvertFactory<EPCommodity> dicConvertFactory)
            : base(EPCommodityRepository, EPCommodityIdFactory, EPCommodityFileFactory, blobStorage, dicConvertFactory)
        {
            _EPCommodityRepository = EPCommodityRepository;
        }
    }
}