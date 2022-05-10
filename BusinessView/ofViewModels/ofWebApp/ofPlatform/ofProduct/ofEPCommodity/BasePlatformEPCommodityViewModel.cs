using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofProduct.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct
{
    public class BasePlatformEPCommodityViewModel : BaseStatusViewModel<PlatformEPCommodity>
    {
        public BasePlatformEPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostEPCommodityViewModel : StatusPostViewModel<PlatformEPCommodity>
    {
        public PlatformPostEPCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutEPCommodityViewModel : StatusPutViewModel<PlatformEPCommodity>
    {
        public PlatformPutEPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteEPCommodityViewModel : StatusDeleteViewModel<PlatformEPCommodity>
    {
        public PlatformDeleteEPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsEPCommodityViewModel : StatusGetsViewModel<PlatformEPCommodity>
    {
        public PlatformGetsEPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
