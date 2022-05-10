using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class BasePlatformEWCommodityViewModel : BaseStatusViewModel<PlatformEWCommodity>
    {
        public BasePlatformEWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostEWCommodityViewModel : StatusPostViewModel<PlatformEWCommodity>
    {
        public PlatformPostEWCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutEWCommodityViewModel : StatusPutViewModel<PlatformEWCommodity>
    {
        public PlatformPutEWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteEWCommodityViewModel : StatusDeleteViewModel<PlatformEWCommodity>
    {
        public PlatformDeleteEWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsEWCommodityViewModel : StatusGetsViewModel<PlatformEWCommodity>
    {
        public PlatformGetsEWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
