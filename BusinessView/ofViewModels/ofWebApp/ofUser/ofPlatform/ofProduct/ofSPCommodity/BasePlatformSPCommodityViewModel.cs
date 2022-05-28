using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofProduct.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct
{
    public class BasePlatformSPCommodityViewModel : BaseStatusViewModel<PlatformSPCommodity>
    {
        public BasePlatformSPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostSPCommodityViewModel : StatusPostViewModel<PlatformSPCommodity>
    {
        public PlatformPostSPCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutSPCommodityViewModel : StatusPutViewModel<PlatformSPCommodity>
    {
        public PlatformPutSPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteSPCommodityViewModel : StatusDeleteViewModel<PlatformSPCommodity>
    {
        public PlatformDeleteSPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsSPCommodityViewModel : StatusGetsViewModel<PlatformSPCommodity>
    {
        public PlatformGetsSPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
