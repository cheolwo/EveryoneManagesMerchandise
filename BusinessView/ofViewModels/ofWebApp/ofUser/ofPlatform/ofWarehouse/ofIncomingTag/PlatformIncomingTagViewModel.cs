using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofIncomingTag;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class PlatformPostIncomingTagViewModel : IncomingTagPostViewModel<PlatformIncomingTag>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostIncomingTagViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutIncomingTagViewModel : IncomingTagPutViewModel<PlatformIncomingTag>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutIncomingTagViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteIncomingTagViewModel : IncomingTagDeleteViewModel<PlatformIncomingTag>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteIncomingTagViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsIncomingTagViewModel : IncomingTagGetsViewModel<PlatformIncomingTag>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsIncomingTagViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
