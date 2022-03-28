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
    public interface ISGOCManager : ISStatusManager<SGOC>
    {
    }
    public class SGOCManager : SStatusManager<SGOC>, IEmployerSGOCManager, IEmployeeSGOCManager, IPlatformSGOCManager
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
