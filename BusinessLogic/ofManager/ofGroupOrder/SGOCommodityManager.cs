using BusinessData.ofGO.ofRepository;
using BusinessData.ofGroupOrder.ofModel;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGroupOrder.ofBlobStorage;
using BusinessLogic.ofManager.ofGroupOrder.ofFileFactory;
using BusinessLogic.ofManager.ofGroupOrder.ofIdFactory;

namespace BusinessLogic.ofManager.ofOrder
{
    public interface ISGOCManager : IStatusManager<SGOC>
    {
    }
    public class SGOCManager : StatusManager<SGOC>, ISGOCManager
    {
        private readonly ISGOCRepository _SGOCRepository;
        public SGOCManager(ISGOCRepository SGOCRepository,
                               ISGOCIdFactory SGOCIdFactory,
                               ISGOCFileFactory SGOCFileFactory,
                               ISGOCBlobStorage blobStorage,
                            DicConvertFactory<SGOC> dicConvertFactory)
            : base(SGOCRepository, SGOCIdFactory, SGOCFileFactory, blobStorage, dicConvertFactory)
        {
            _SGOCRepository = SGOCRepository;
        }
    }
}
