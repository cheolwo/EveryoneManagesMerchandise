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
    public interface IMWCommodityManager : IMStatusManager<MWCommodity>
    {

    }
    public class MWCommodityManager : StatusManager<MWCommodity>, IEmployerMWCommodityManager, IEmployeeMWCommodityManager, IPlatformMWCommodityManager
    {
        public MWCommodityManager(IMWCommodityRepository StatusDataRepository,
            IMWCommodityIdFactory mWCommodityIdFactory,
                               IMWCommodityFileFactory StatusFileFactory,
                               IMWCommodityBlobStorage blobStorage,
                            DicConvertFactory<MWCommodity> dicConvertFactory)
            : base(StatusDataRepository, mWCommodityIdFactory, StatusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}