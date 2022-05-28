using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofJournal.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofJournal
{
    public class BasePlatformJCommodityViewModel : BaseCommodityViewModel<PlatformJCommodity>
    {
        public BasePlatformJCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostJCommodityViewModel : CommodityPostViewModel<PlatformJCommodity>
    {
        public PlatformPostJCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutJCommodityViewModel : CommodityPutViewModel<PlatformJCommodity>
    {
        public PlatformPutJCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteJCommodityViewModel : CommodityDeleteViewModel<PlatformJCommodity>
    {
        public PlatformDeleteJCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsJCommodityViewModel : CommodityGetsViewModel<PlatformJCommodity>
    {
        public PlatformGetsJCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
