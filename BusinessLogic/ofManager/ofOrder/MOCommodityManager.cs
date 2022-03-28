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
    public interface IMOCommodityManager : IMStatusManager<MOCommodity>
    {
    }
    public class MOCommodityManager : MStatusManager<MOCommodity>, IEmployerMOCommodityManager, IEmployeeMOCommodityManager, IPlatformMOCommodityManager
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