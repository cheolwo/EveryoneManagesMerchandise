using BusinessData.ofOrder.ofModel;
using BusinessData.ofOrder.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofOrder.ofBlobStorage;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;
using BusinessLogic.ofManager.ofWarehouse.ofIdFactory;

namespace BusinessLogic.ofManager.ofOrder
{
    public interface ISOCommodityManager : IStatusManager<SOCommodity>
    {
    }
    public class SOCommodityManager : StatusManager<SOCommodity>, ISOCommodityManager
    {
        private readonly ISOCommodityRepository _SOCommodityRepository;
        public SOCommodityManager(ISOCommodityRepository SOCommodityRepository,
                               ISOCommodityIdFactory SOCommodityIdFactory,
                               ISOCommodityFileFactory SOCommodityFileFactory,
                               ISOCommodityBlobStorage blobStorage,
                            DicConvertFactory<SOCommodity> dicConvertFactory)
            : base(SOCommodityRepository, SOCommodityIdFactory, SOCommodityFileFactory, blobStorage, dicConvertFactory)
        {
            _SOCommodityRepository = SOCommodityRepository;
        }
    }
}