using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofMarket.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket
{
    public class BasePlatformMCommodityViewModel : BaseCommodityViewModel<PlatformMCommodity>
    {
        public BasePlatformMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostMCommodityViewModel : CommodityPostViewModel<PlatformMCommodity>
    {
        public PlatformPostMCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutMCommodityViewModel : CommodityPutViewModel<PlatformMCommodity>
    {
        public PlatformPutMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteMCommodityViewModel : CommodityDeleteViewModel<PlatformMCommodity>
    {
        public PlatformDeleteMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsMCommodityViewModel : CommodityGetsViewModel<PlatformMCommodity>
    {
        public PlatformGetsMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
