using BusinessData.ofMarket.ofModel;
using BusinessData.ofMarket.ofRepository;
using BusinessLogic.ofManager.ofDeliveryCenter.ofFileFactory;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofMarket.ofBlobStorage;
using BusinessLogic.ofManager.ofMarket.ofIdFactory;

namespace BusinessLogic.ofManager.ofMarket
{
    [DataManager(typeof(SMCommodity))]
    public class SMCommodityManager : StatusManager<SMCommodity>
    {
        public SMCommodityManager(ISMCommodityRepository statusDataRepository,
            ISMCommodityIdFactory sMCommodityIdFactory,
                               ISMCommodityFileFactory statusFileFactory,
                               ISMCommodityBlobStorage blobStorage,
                            DicConvertFactory<SMCommodity> dicConvertFactory)
            : base(statusDataRepository, sMCommodityIdFactory, statusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}