using BusinessData.ofGroupOrder.ofModel;
using BusinessData.ofGroupOrder.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGroupOrder.ofBlobStorage;
using BusinessLogic.ofManager.ofGroupOrder.ofFileFactory;
using BusinessLogic.ofManager.ofGroupOrder.ofIdFactory;

namespace BusinessLogic.ofManager.ofOrder
{
    public interface ISGOCommodityManager : IStatusManager<SGOCommodity>
    {
    }
    public class SGOCommodityManager : StatusManager<SGOCommodity>, ISGOCommodityManager
    {
        private readonly ISGOCommodityRepository _SGOCommodityRepository;
        public SGOCommodityManager(ISGOCommodityRepository SGOCommodityRepository,
                               ISGOCommodityIdFactory SGOCommodityIdFactory,
                               ISGOCommodityFileFactory SGOCommodityFileFactory,
                               ISGOCommodityBlobStorage blobStorage,
                            DicConvertFactory<SGOCommodity> dicConvertFactory)
            : base(SGOCommodityRepository, SGOCommodityIdFactory, SGOCommodityFileFactory, blobStorage, dicConvertFactory)
        {
            _SGOCommodityRepository = SGOCommodityRepository;
        }
    }
}
