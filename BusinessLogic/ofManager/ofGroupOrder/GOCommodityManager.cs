using BusinessData.ofGroupOrder.ofModel;
using BusinessData.ofGroupOrder.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGroupOrder.ofBlobStorage;
using BusinessLogic.ofManager.ofGroupOrder.ofFileFactory;
using BusinessLogic.ofManager.ofGroupOrder.ofIdFactory;

namespace BusinessLogic.ofManager.ofOrder
{
    public interface IGOCommodityManager : ICommodityManager<GOCommodity>
    {
    }
    public class GOCommodityManager : CommodityManager<GOCommodity>, IGOCommodityManager
    {
        private readonly IGOCommodityRepository _GOCommodityRepository;
        public GOCommodityManager(IGOCommodityRepository GOCommodityRepository,
                               IGOCommodityIdFactory GOCommodityIdFactory,
                               IGOCommodityFileFactory GOCommodityFileFactory,
                               IGOCommodityBlobStorage blobStorage,
                            DicConvertFactory<GOCommodity> dicConvertFactory)
            : base(GOCommodityRepository, GOCommodityIdFactory, GOCommodityFileFactory, blobStorage, dicConvertFactory)
        {
            _GOCommodityRepository = GOCommodityRepository;
        }
    }
}
