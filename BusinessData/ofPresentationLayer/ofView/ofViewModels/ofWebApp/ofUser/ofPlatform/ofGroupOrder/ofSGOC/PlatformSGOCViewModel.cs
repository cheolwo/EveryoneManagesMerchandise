using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofSGOC;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofPlaform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class PlatformPostSGOCViewModel : SGOCPostViewModel<PlatformSGOC>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostSGOCViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutSGOCViewModel : SGOCPutViewModel<PlatformSGOC>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutSGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteSGOCViewModel : SGOCDeleteViewModel<PlatformSGOC>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteSGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsSGOCViewModel : SGOCGetsViewModel<PlatformSGOC>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsSGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
