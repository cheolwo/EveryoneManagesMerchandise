using BusinessData.ofGroupOrder.ofModel;
using BusinessData.ofGroupOrder.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGroupOrder.ofBlobStorage;
using BusinessLogic.ofManager.ofGroupOrder.ofFileFactory;
using BusinessLogic.ofManager.ofGroupOrder.ofIdFactory;

namespace BusinessLogic.ofManager.ofOrder
{
    public interface IEGOCommodityManager : IStatusManager<EGOCommodity>
    {
    }
    public class EGOCommodityManager : StatusManager<EGOCommodity>, IEGOCommodityManager
    {
        private readonly IEGOCommodityRepository _EGOCommodityRepository;
        public EGOCommodityManager(IEGOCommodityRepository EGOCommodityRepository,
                               IEGOCommodityIdFactory EGOCommodityIdFactory,
                               IEGOCommodityFileFactory EGOCommodityFileFactory,
                               IEGOCommodityBlobStorage blobStorage,
                            DicConvertFactory<EGOCommodity> dicConvertFactory)
            : base(EGOCommodityRepository, EGOCommodityIdFactory, EGOCommodityFileFactory, blobStorage, dicConvertFactory)
        {
            _EGOCommodityRepository = EGOCommodityRepository;
        }
    }
}
