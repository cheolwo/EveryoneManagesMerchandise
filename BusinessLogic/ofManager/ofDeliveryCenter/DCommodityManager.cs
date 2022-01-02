using BusinessData.ofDeliveryCenter;
using BusinessLogic.ofManager.ofGeneric;
using BusinessData.ofRepository;
using BusinessLogic.ofManager.ofDeliveryCenter.ofFileFactory;
using BusinessLogic.ofManager.ofDeliveryCenter.ofIdFactory;
using BusinessLogic.ofManager.ofDeliveryCenter.ofBlobStorage;

namespace BusinessLogic.ofManager.ofDeliveryCenter
{
    public class DCommodityManager : CommodityManager<DCommodity>
    {
        public DCommodityManager(IDCommodityRepository dcommodityDataRepository,
            IDCommodityIdFactory dCommodityIdFactory,
                                IDCommodityFileFactory dcommodityFileFactory,
                                IDCommodityBlobStorage dCommodityBlobStorage,
                            DicConvertFactory<DCommodity> dicConvertFactory)
            : base(dcommodityDataRepository, dCommodityIdFactory, dcommodityFileFactory, dCommodityBlobStorage, dicConvertFactory)
        {

        }
    }
}