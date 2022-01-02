using BusinessData.ofMarket.ofModel;
using BusinessData.ofMarket.ofRepository;
using BusinessLogic.ofManager.ofDeliveryCenter.ofFileFactory;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofMarket.ofBlobStorage;
using BusinessLogic.ofManager.ofMarket.ofIdFactory;

namespace BusinessLogic.ofManager.ofMarket
{
    [DataManager(typeof(EMCommodity))]
    public class EMCommodityManager : StatusManager<EMCommodity>
    {
        public EMCommodityManager(IEMCommodityRepository statusDataRepository,
            IEMCommodityIdFactory eMCommodityIdFactory,
                               IEMCommodityFileFactory statusFileFactory,
                               IEMCommodityBlobStorage blobStorage,
                            DicConvertFactory<EMCommodity> dicConvertFactory)
            : base(statusDataRepository, eMCommodityIdFactory, statusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}