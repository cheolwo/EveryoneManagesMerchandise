using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofWarehouse.ofBlobStorage;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;
using BusinessLogic.ofManager.ofWarehouse.ofIdFactory;

namespace BusinessLogic.ofManager.ofWarehouse
{
    public interface IMWCommodityManager
    {

    }
    public class MWCommodityManager : StatusManager<MWCommodity>
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