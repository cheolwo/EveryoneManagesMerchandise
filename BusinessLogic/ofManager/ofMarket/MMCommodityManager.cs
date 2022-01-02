using BusinessData.ofMarket.ofModel;
using BusinessData.ofMarket.ofRepository;
using BusinessLogic.ofManager.ofDeliveryCenter.ofFileFactory;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofMarket.ofBlobStorage;
using BusinessLogic.ofManager.ofMarket.ofIdFactory;

namespace BusinessLogic.ofManager.ofMarket
{
    [DataManager(typeof(MMCommodity))]
    public class MMCommodityManager : StatusManager<MMCommodity>
    {
        public MMCommodityManager(IMMCommodityRepository statusDataRepository,
            IMMCommodityIdFactory mMCommodityIdFactory,
                               IMMCommodityFileFactory statusFileFactory,
                               IMMCommodityBlobStorage blobStorage,
                            DicConvertFactory<MMCommodity> dicConvertFactory)
            : base(statusDataRepository, mMCommodityIdFactory, statusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}