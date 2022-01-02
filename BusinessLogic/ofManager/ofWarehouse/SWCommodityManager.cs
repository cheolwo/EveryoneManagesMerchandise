using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofWarehouse.ofBlobStorage;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;
using BusinessLogic.ofManager.ofWarehouse.ofIdFactory;

namespace BusinessLogic.ofManager.ofWarehouse
{
    public interface ISWCommodityManager
    {

    }
    public class SWCommodityManager : StatusManager<SWCommodity>
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