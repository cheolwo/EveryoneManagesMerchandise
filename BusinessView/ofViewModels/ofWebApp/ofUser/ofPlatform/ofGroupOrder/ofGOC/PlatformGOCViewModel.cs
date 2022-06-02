using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofGOC;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofPlaform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class PlatformPostGOCViewModel : GOCPostViewModel<PlatformGOC>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostGOCViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutGOCViewModel : GOCPutViewModel<PlatformGOC>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteGOCViewModel : GOCDeleteViewModel<PlatformGOC>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsGOCViewModel : GOCGetsViewModel<PlatformGOC>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
