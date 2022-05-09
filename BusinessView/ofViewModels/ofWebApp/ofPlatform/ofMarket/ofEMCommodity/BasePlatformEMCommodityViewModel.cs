using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofMarket.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket
{
    public class BasePlatformEMCommodityViewModel : BaseStatusViewModel<PlatformEMCommodity>
    {
        public BasePlatformEMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostEMCommodityViewModel : StatusPostViewModel<PlatformEMCommodity>
    {
        public PlatformPostEMCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutEMCommodityViewModel : StatusPutViewModel<PlatformEMCommodity>
    {
        public PlatformPutEMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteEMCommodityViewModel : StatusDeleteViewModel<PlatformEMCommodity>
    {
        public PlatformDeleteEMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsEMCommodityViewModel : StatusGetsViewModel<PlatformEMCommodity>
    {
        public PlatformGetsEMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
