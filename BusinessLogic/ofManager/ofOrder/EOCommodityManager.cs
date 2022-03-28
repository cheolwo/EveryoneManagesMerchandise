using BusinessData.ofOrder.ofModel;
using BusinessData.ofOrder.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofOrder.ofBlobStorage;
using BusinessLogic.ofManager.ofOrder.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofOrder.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofOrder.ofInterface.ofPlatform;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;
using BusinessLogic.ofManager.ofWarehouse.ofIdFactory;

namespace BusinessLogic.ofManager.ofOrder
{
    public interface IEOCommodityManager : IEStatusManager<EOCommodity>
    {
    }
    public class EOCommodityManager : EStatusManager<EOCommodity>, IEmployerEOCommodityManager, IEmployeeEOCommodityManager, IPlatformEOCommodityManager
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