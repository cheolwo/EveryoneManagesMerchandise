using BusinessData.ofMarket.ofModel;
using BusinessData.ofMarket.ofRepository;
using BusinessLogic.ofManager.ofDeliveryCenter.ofFileFactory;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofMarket.ofBlobStorage;
using BusinessLogic.ofManager.ofMarket.ofIdFactory;

namespace BusinessLogic.ofManager.ofMarket
{
    [DataManager(typeof(MCommodity))]
    public class MCommodityManager : CommodityManager<MCommodity>
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