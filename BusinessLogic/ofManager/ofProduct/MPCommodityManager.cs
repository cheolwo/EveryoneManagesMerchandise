using BusinessData.ofMarket.ofRepository.ofIdFactory;
using BusinessData.ofProduct;
using BusinessData.ofProduct.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofProduct.ofBlobStorage;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;

namespace BusinessLogic.ofManager.ofProduct
{
    public class MPCommodityManager : StatusManager<MPCommodity>
    {
        private readonly IMPCommodityRepository _MPCommodityRepository;
        public MPCommodityManager(IMPCommodityRepository MPCommodityRepository,
                               IMPCommodityIdFactory MPCommodityIdFactory,
                               IMPCommodityFileFactory MPCommodityFileFactory,
                               IMPCommodityBlobStorage blobStorage,
                            DicConvertFactory<MPCommodity> dicConvertFactory)
            : base(MPCommodityRepository, MPCommodityIdFactory, MPCommodityFileFactory, blobStorage, dicConvertFactory)
        {
            _MPCommodityRepository = MPCommodityRepository;
        }
    }
}