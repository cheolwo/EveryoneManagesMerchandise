using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofWarehouse.ofBlobStorage;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;
using BusinessLogic.ofManager.ofWarehouse.ofIdFactory;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofPlatform;

namespace BusinessLogic.ofManager.ofWarehouse
{
    public class EWCommodityManager : StatusManager<EWCommodity>, IEmployerEWCommodityManager, IEmployeeEWCommodityManager, IPlatformEWCommodityManager, IEWCommodityManager
    {
        public EWCommodityManager(IEWCommodityRepository StatusDataRepository,
            IEWCommodityIdFactory eWCommodityIdFactory,
                               IEWCommodityFileFactory StatusFileFactory,
                               IEWCommodityBlobStorage blobStorage,
                            DicConvertFactory<EWCommodity> dicConvertFactory)
            : base(StatusDataRepository, eWCommodityIdFactory, StatusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}