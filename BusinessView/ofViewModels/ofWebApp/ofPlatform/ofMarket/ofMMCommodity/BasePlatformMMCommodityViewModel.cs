using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofMarket.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket
{
    public class BasePlatformMMCommodityViewModel : BaseStatusViewModel<PlatformMMCommodity>
    {
        public BasePlatformMMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostMMCommodityViewModel : StatusPostViewModel<PlatformMMCommodity>
    {
        public PlatformPostMMCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutMMCommodityViewModel : StatusPutViewModel<PlatformMMCommodity>
    {
        public PlatformPutMMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteMMCommodityViewModel : StatusDeleteViewModel<PlatformMMCommodity>
    {
        public PlatformDeleteMMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsMMCommodityViewModel : StatusGetsViewModel<PlatformMMCommodity>
    {
        public PlatformGetsMMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
