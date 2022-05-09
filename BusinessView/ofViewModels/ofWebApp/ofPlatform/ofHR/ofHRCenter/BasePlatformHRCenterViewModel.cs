using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofHR.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR
{
    public class BasePlatformHRCenterViewModel : BaseCenterViewModel<PlatformHRCenter>
    {
        public BasePlatformHRCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostHRCenterViewModel : CenterPostViewModel<PlatformHRCenter>
    {
        public PlatformPostHRCenterViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutHRCenterViewModel : CenterPutViewModel<PlatformHRCenter>
    {
        public PlatformPutHRCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteHRCenterViewModel : CenterDeleteViewModel<PlatformHRCenter>
    {
        public PlatformDeleteHRCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsHRCenterViewModel : CenterGetsViewModel<PlatformHRCenter>
    {
        public PlatformGetsHRCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
