using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofTrade.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade
{
    public class BasePlatformMTCommodityViewModel : BaseStatusViewModel<PlatformMTCommodity>
    {
        public BasePlatformMTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostMTCommodityViewModel : StatusPostViewModel<PlatformMTCommodity>
    {
        public PlatformPostMTCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutMTCommodityViewModel : StatusPutViewModel<PlatformMTCommodity>
    {
        public PlatformPutMTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteMTCommodityViewModel : StatusDeleteViewModel<PlatformMTCommodity>
    {
        public PlatformDeleteMTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsMTCommodityViewModel : StatusGetsViewModel<PlatformMTCommodity>
    {
        public PlatformGetsMTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
