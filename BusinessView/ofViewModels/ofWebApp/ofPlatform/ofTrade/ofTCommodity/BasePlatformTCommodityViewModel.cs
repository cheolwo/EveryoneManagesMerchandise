using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofTrade.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade
{
    public class BasePlatformTCommodityViewModel : BaseCommodityViewModel<PlatformTCommodity>
    {
        public BasePlatformTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostTCommodityViewModel : CommodityPostViewModel<PlatformTCommodity>
    {
        public PlatformPostTCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutTCommodityViewModel : CommodityPutViewModel<PlatformTCommodity>
    {
        public PlatformPutTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteTCommodityViewModel : CommodityDeleteViewModel<PlatformTCommodity>
    {
        public PlatformDeleteTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsTCommodityViewModel : CommodityGetsViewModel<PlatformTCommodity>
    {
        public PlatformGetsTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
