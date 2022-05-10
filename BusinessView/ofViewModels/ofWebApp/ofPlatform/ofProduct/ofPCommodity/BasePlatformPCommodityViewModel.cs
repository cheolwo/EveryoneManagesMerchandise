using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofProduct.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct
{
    public class BasePlatformPCommodityViewModel : BaseCommodityViewModel<PlatformPCommodity>
    {
        public BasePlatformPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostPCommodityViewModel : CommodityPostViewModel<PlatformPCommodity>
    {
        public PlatformPostPCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutPCommodityViewModel : CommodityPutViewModel<PlatformPCommodity>
    {
        public PlatformPutPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeletePCommodityViewModel : CommodityDeleteViewModel<PlatformPCommodity>
    {
        public PlatformDeletePCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsPCommodityViewModel : CommodityGetsViewModel<PlatformPCommodity>
    {
        public PlatformGetsPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
