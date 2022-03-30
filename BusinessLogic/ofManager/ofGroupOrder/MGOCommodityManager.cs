using BusinessData.ofGO.ofRepository;
using BusinessData.ofGroupOrder.ofModel;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGroupOrder.ofBlobStorage;
using BusinessLogic.ofManager.ofGroupOrder.ofFileFactory;
using BusinessLogic.ofManager.ofGroupOrder.ofIdFactory;
using BusinessLogic.ofManager.ofGroupOrder.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofGroupOrder.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofGroupOrder.ofInterface.ofPlatform;

namespace BusinessLogic.ofManager.ofOrder
{
    public interface IMGOCManager : IMStatusManager<MGOC>
    {
    }
    public class MGOCManager : MStatusManager<MGOC>, IEmployerMGOCManager, IEmployeeMGOCManager, IPlatformMGOCManager, IMGOCManager
    {
        private readonly IMGOCRepository _MGOCRepository;
        public MGOCManager(IMGOCRepository MGOCRepository,
                               IMGOCIdFactory MGOCIdFactory,
                               IMGOCFileFactory MGOCFileFactory,
                               IMGOCBlobStorage blobStorage,
                            DicConvertFactory<MGOC> dicConvertFactory)
            : base(MGOCRepository, MGOCIdFactory, MGOCFileFactory, blobStorage, dicConvertFactory)
        {
            _MGOCRepository = MGOCRepository;
        }
    }
}
