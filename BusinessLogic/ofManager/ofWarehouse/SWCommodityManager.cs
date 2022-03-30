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
    public interface ISWCommodityManager : ISStatusManager<SWCommodity>
    {

    }
    public class SWCommodityManager : StatusManager<SWCommodity>, IEmployerSWCommodityManager, IEmployeeSWCommodityManager, IPlatformSWCommodityManager, ISWCommodityManager
    {
        public SWCommodityManager(ISWCommodityRepository StatusDataRepository,
            ISWCommodityIdFactory sWCommodityIdFactory,
                               ISWCommodityFileFactory StatusFileFactory,
                               ISWCommodityBlobStorage blobStorage,
                            DicConvertFactory<SWCommodity> dicConvertFactory)
            : base(StatusDataRepository, sWCommodityIdFactory, StatusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}