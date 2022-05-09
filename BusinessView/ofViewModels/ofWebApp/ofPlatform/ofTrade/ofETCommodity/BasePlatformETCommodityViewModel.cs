using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofTrade.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade
{
    public class BasePlatformETCommodityViewModel : BaseStatusViewModel<PlatformETCommodity>
    {
        public BasePlatformETCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostETCommodityViewModel : StatusPostViewModel<PlatformETCommodity>
    {
        public PlatformPostETCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutETCommodityViewModel : StatusPutViewModel<PlatformETCommodity>
    {
        public PlatformPutETCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteETCommodityViewModel : StatusDeleteViewModel<PlatformETCommodity>
    {
        public PlatformDeleteETCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsETCommodityViewModel : StatusGetsViewModel<PlatformETCommodity>
    {
        public PlatformGetsETCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
