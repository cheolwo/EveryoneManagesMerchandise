using BusinessData.ofGroupOrder.ofModel;
using BusinessData.ofGroupOrder.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGroupOrder.ofBlobStorage;
using BusinessLogic.ofManager.ofGroupOrder.ofFileFactory;
using BusinessLogic.ofManager.ofGroupOrder.ofIdFactory;

namespace BusinessLogic.ofManager.ofOrder
{
    public interface IMGOCommodityManager : IStatusManager<MGOCommodity>
    {
    }
    public class MGOCommodityManager : StatusManager<MGOCommodity>, IMGOCommodityManager
    {
        private readonly IMGOCommodityRepository _MGOCommodityRepository;
        public MGOCommodityManager(IMGOCommodityRepository MGOCommodityRepository,
                               IMGOCommodityIdFactory MGOCommodityIdFactory,
                               IMGOCommodityFileFactory MGOCommodityFileFactory,
                               IMGOCommodityBlobStorage blobStorage,
                            DicConvertFactory<MGOCommodity> dicConvertFactory)
            : base(MGOCommodityRepository, MGOCommodityIdFactory, MGOCommodityFileFactory, blobStorage, dicConvertFactory)
        {
            _MGOCommodityRepository = MGOCommodityRepository;
        }
    }
}
