using BusinessData.ofDeliveryCenter;
using BusinessLogic.ofManager.ofGeneric;
using BusinessData.ofRepository;
using BusinessLogic.ofManager.ofDeliveryCenter.ofFileFactory;
using BusinessLogic.ofManager.ofDeliveryCenter.ofIdFactory;
using BusinessLogic.ofManager.ofDeliveryCenter.ofBlobStorage;
using BusinessLogic.ofManager.ofDeliveryCenter.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofDeliveryCenter.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofDeliveryCenter.ofInterface.ofPlatform;

namespace BusinessLogic.ofManager.ofDeliveryCenter
{
    public interface IDCommodityManager : ICommodityManager<DCommodity>
    {

    }
    public class DCommodityManager : CommodityManager<DCommodity>, IEmployerDCommodityManager, IEmployeeDCommodityManager, IPlatformDCommodityManager
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