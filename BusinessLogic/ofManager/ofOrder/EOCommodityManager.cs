using BusinessData.ofOrder.ofModel;
using BusinessData.ofOrder.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofOrder.ofBlobStorage;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;
using BusinessLogic.ofManager.ofWarehouse.ofIdFactory;

namespace BusinessLogic.ofManager.ofOrder
{
    public interface IEOCommodityManager : IStatusManager<EOCommodity>
    {
    }
    public class EOCommodityManager : StatusManager<EOCommodity>, IEOCommodityManager
    {
        private readonly IEOCommodityRepository _EOCommodityRepository;
        public EOCommodityManager(IEOCommodityRepository EOCommodityRepository,
                               IEOCommodityIdFactory EOCommodityIdFactory,
                               IEOCommodityFileFactory EOCommodityFileFactory,
                               IEOCommodityBlobStorage blobStorage,
                            DicConvertFactory<EOCommodity> dicConvertFactory)
            : base(EOCommodityRepository, EOCommodityIdFactory, EOCommodityFileFactory, blobStorage, dicConvertFactory)
        {
            _EOCommodityRepository = EOCommodityRepository;
        }
    }
}