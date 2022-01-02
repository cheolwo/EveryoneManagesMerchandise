using BusinessData.ofOrder.ofModel;
using BusinessData.ofOrder.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofOrder.ofBlobStorage;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;
using BusinessLogic.ofManager.ofWarehouse.ofIdFactory;

namespace BusinessLogic.ofManager.ofOrder
{
    public interface IMOCommodityManager : IStatusManager<MOCommodity>
    {
    }
    public class MOCommodityManager : StatusManager<MOCommodity>, IMOCommodityManager
    {
        private readonly IMOCommodityRepository _MOCommodityRepository;
        public MOCommodityManager(IMOCommodityRepository MOCommodityRepository,
                               IMOCommodityIdFactory MOCommodityIdFactory,
                               IMOCommodityFileFactory MOCommodityFileFactory,
                               IMOCommodityBlobStorage blobStorage,
                            DicConvertFactory<MOCommodity> dicConvertFactory)
            : base(MOCommodityRepository, MOCommodityIdFactory, MOCommodityFileFactory, blobStorage, dicConvertFactory)
        {
            _MOCommodityRepository = MOCommodityRepository;
        }
    }
}