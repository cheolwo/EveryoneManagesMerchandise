using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofOrder.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder
{
    public class BasePlatformSOCommodityViewModel : BaseStatusViewModel<PlatformSOCommodity>
    {
        public BasePlatformSOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostSOCommodityViewModel : StatusPostViewModel<PlatformSOCommodity>
    {
        public PlatformPostSOCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutSOCommodityViewModel : StatusPutViewModel<PlatformSOCommodity>
    {
        public PlatformPutSOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteSOCommodityViewModel : StatusDeleteViewModel<PlatformSOCommodity>
    {
        public PlatformDeleteSOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsSOCommodityViewModel : StatusGetsViewModel<PlatformSOCommodity>
    {
        public PlatformGetsSOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
