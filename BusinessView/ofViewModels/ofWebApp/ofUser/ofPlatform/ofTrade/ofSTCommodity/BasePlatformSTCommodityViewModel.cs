using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofTrade.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade
{
    public class BasePlatformSTCommodityViewModel : BaseStatusViewModel<PlatformSTCommodity>
    {
        public BasePlatformSTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostSTCommodityViewModel : StatusPostViewModel<PlatformSTCommodity>
    {
        public PlatformPostSTCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutSTCommodityViewModel : StatusPutViewModel<PlatformSTCommodity>
    {
        public PlatformPutSTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteSTCommodityViewModel : StatusDeleteViewModel<PlatformSTCommodity>
    {
        public PlatformDeleteSTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsSTCommodityViewModel : StatusGetsViewModel<PlatformSTCommodity>
    {
        public PlatformGetsSTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
