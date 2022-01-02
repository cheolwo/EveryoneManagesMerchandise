using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofWarehouse.ofBlobStorage;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;
using BusinessLogic.ofManager.ofWarehouse.ofIdFactory;

namespace BusinessLogic.ofManager.ofWarehouse
{
    public interface IEWCommodityManager
    {

    }
    public class EWCommodityManager : StatusManager<EWCommodity>
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