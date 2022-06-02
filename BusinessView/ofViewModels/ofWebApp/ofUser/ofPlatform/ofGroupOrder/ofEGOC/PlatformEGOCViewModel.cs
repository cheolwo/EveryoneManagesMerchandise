using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofEGOC;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofPlaform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class PlatformPostEGOCViewModel : EGOCPostViewModel<PlatformEGOC>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostEGOCViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutEGOCViewModel : EGOCPutViewModel<PlatformEGOC>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutEGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteEGOCViewModel : EGOCDeleteViewModel<PlatformEGOC>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteEGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsEGOCViewModel : EGOCGetsViewModel<PlatformEGOC>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsEGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
