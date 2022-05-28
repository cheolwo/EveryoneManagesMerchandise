using BusinessView.ofDTO.ofGroupOrder.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofGOCC;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class PlatformPostGOCCViewModel : GOCCPostViewModel<PlatformGOCC>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostGOCCViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutGOCCViewModel : GOCCPutViewModel<PlatformGOCC>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutGOCCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteGOCCViewModel : GOCCDeleteViewModel<PlatformGOCC>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteGOCCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsGOCCViewModel : GOCCGetsViewModel<PlatformGOCC>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsGOCCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
