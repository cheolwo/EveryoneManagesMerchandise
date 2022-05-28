using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofProduct.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct
{
    public class BasePlatformMPCommodityViewModel : BaseStatusViewModel<PlatformMPCommodity>
    {
        public BasePlatformMPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostMPCommodityViewModel : StatusPostViewModel<PlatformMPCommodity>
    {
        public PlatformPostMPCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutMPCommodityViewModel : StatusPutViewModel<PlatformMPCommodity>
    {
        public PlatformPutMPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteMPCommodityViewModel : StatusDeleteViewModel<PlatformMPCommodity>
    {
        public PlatformDeleteMPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsMPCommodityViewModel : StatusGetsViewModel<PlatformMPCommodity>
    {
        public PlatformGetsMPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
