using BusinessData.ofGO.ofRepository;
using BusinessData.ofGroupOrder.ofModel;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGroupOrder.ofBlobStorage;
using BusinessLogic.ofManager.ofGroupOrder.ofFileFactory;
using BusinessLogic.ofManager.ofGroupOrder.ofIdFactory;

namespace BusinessLogic.ofManager.ofOrder
{
    public interface IMGOCManager : IStatusManager<MGOC>
    {
    }
    public class MGOCManager : StatusManager<MGOC>, IMGOCManager
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
