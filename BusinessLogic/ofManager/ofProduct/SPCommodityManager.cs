using BusinessData.ofMarket.ofRepository.ofIdFactory;
using BusinessData.ofProduct;
using BusinessData.ofProduct.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofProduct.ofBlobStorage;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;

namespace BusinessLogic.ofManager.ofProduct
{
    public class SPCommodityManager : StatusManager<SPCommodity>
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