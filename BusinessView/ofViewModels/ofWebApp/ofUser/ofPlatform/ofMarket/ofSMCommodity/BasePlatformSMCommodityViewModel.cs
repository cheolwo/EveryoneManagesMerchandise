using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofMarket.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket
{
    public class BasePlatformSMCommodityViewModel : BaseStatusViewModel<PlatformSMCommodity>
    {
        public BasePlatformSMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostSMCommodityViewModel : StatusPostViewModel<PlatformSMCommodity>
    {
        public PlatformPostSMCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutSMCommodityViewModel : StatusPutViewModel<PlatformSMCommodity>
    {
        public PlatformPutSMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteSMCommodityViewModel : StatusDeleteViewModel<PlatformSMCommodity>
    {
        public PlatformDeleteSMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsSMCommodityViewModel : StatusGetsViewModel<PlatformSMCommodity>
    {
        public PlatformGetsSMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
