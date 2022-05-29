using BusinessView.ofDTO.ofHR.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofHRBusinessPart;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR
{
    public class PlatformPostHRBusinessPartViewModel : HRBusinessPartPostViewModel<PlatformHRBusinessPart>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostHRBusinessPartViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutHRBusinessPartViewModel : HRBusinessPartPutViewModel<PlatformHRBusinessPart>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutHRBusinessPartViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteHRBusinessPartViewModel : HRBusinessPartDeleteViewModel<PlatformHRBusinessPart>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteHRBusinessPartViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsHRBusinessPartViewModel : HRBusinessPartGetsViewModel<PlatformHRBusinessPart>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsHRBusinessPartViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}