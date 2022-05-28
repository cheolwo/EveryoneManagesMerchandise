using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofHR.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR
{
    public class BasePlatformHRBusinessPartViewModel : BaseEntityViewModel<PlatformHRBusinessPart>
    {
        public BasePlatformHRBusinessPartViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostHRBusinessPartViewModel : EntityPostViewModel<PlatformHRBusinessPart>
    {
        public PlatformPostHRBusinessPartViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutHRBusinessPartViewModel : EntityPutViewModel<PlatformHRBusinessPart>
    {
        public PlatformPutHRBusinessPartViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteHRBusinessPartViewModel : EntityDeleteViewModel<PlatformHRBusinessPart>
    {
        public PlatformDeleteHRBusinessPartViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsHRBusinessPartViewModel : EntityGetsViewModel<PlatformHRBusinessPart>
    {
        public PlatformGetsHRBusinessPartViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
