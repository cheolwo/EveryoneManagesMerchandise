using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofIncomingTag;
using BusinessView.ofUser.ofCommon;

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
