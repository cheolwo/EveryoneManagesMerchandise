using BusinessView.ofDTO.ofGroupOrder.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofMGOC;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class PlatformPostMGOCViewModel : MGOCPostViewModel<PlatformMGOC>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostMGOCViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutMGOCViewModel : MGOCPutViewModel<PlatformMGOC>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutMGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteMGOCViewModel : MGOCDeleteViewModel<PlatformMGOC>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteMGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsMGOCViewModel : MGOCGetsViewModel<PlatformMGOC>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsMGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
