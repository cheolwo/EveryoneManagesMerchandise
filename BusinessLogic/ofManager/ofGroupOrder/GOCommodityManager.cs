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
    public interface IGOCCManager : ICommodityManager<GOCC>
    {
    }
    public class GOCCManager : CommodityManager<GOCC>, IEmployerGOCCManager, IEmployeeGOCCManager, IPlatformGOCCManager
    {
        private readonly IGOCCRepository _GOCCRepository;
        public GOCCManager(IGOCCRepository GOCCRepository,
                               IGOCCIdFactory GOCCIdFactory,
                               IGOCCFileFactory GOCCFileFactory,
                               IGOCCBlobStorage blobStorage,
                            DicConvertFactory<GOCC> dicConvertFactory)
            : base(GOCCRepository, GOCCIdFactory, GOCCFileFactory, blobStorage, dicConvertFactory)
        {
            _GOCCRepository = GOCCRepository;
        }
    }
}
