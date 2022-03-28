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
    public interface IEGOCManager : IEStatusManager<EGOC>
    {
    }
    public class EGOCManager : EStatusManager<EGOC>, IEmployerEGOCManager, IEmployeeEGOCManager, IPlatformEGOCManager
    {
        private readonly IEGOCRepository _EGOCRepository;
        public EGOCManager(IEGOCRepository EGOCRepository,
                               IEGOCIdFactory EGOCIdFactory,
                               IEGOCFileFactory EGOCFileFactory,
                               IEGOCBlobStorage blobStorage,
                            DicConvertFactory<EGOC> dicConvertFactory)
            : base(EGOCRepository, EGOCIdFactory, EGOCFileFactory, blobStorage, dicConvertFactory)
        {
            _EGOCRepository = EGOCRepository;
        }
    }
}
