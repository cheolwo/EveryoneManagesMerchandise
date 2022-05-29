using BusinessView.ofDTO.ofHR.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofHRCenter;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR
{
    public class PlatformPostHRCenterViewModel : HRCenterPostViewModel<PlatformHRCenter>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostHRCenterViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutHRCenterViewModel : HRCenterPutViewModel<PlatformHRCenter>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutHRCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteHRCenterViewModel : HRCenterDeleteViewModel<PlatformHRCenter>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteHRCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsHRCenterViewModel : HRCenterGetsViewModel<PlatformHRCenter>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsHRCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}