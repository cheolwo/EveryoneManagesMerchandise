using BusinessData.ofGO.ofRepository;
using BusinessData.ofGroupOrder.ofModel;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGroupOrder.ofBlobStorage;
using BusinessLogic.ofManager.ofGroupOrder.ofFileFactory;
using BusinessLogic.ofManager.ofGroupOrder.ofIdFactory;

namespace BusinessLogic.ofManager.ofOrder
{
    public interface IEGOCManager : IStatusManager<EGOC>
    {
    }
    public class EGOCManager : StatusManager<EGOC>, IEGOCManager
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
