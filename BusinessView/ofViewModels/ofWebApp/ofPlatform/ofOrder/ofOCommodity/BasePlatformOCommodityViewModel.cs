using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofOrder.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder
{
    public class BasePlatformOCommodityViewModel : BaseCommodityViewModel<PlatformOCommodity>
    {
        public BasePlatformOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostOCommodityViewModel : CommodityPostViewModel<PlatformOCommodity>
    {
        public PlatformPostOCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutOCommodityViewModel : CommodityPutViewModel<PlatformOCommodity>
    {
        public PlatformPutOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteOCommodityViewModel : CommodityDeleteViewModel<PlatformOCommodity>
    {
        public PlatformDeleteOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsOCommodityViewModel : CommodityGetsViewModel<PlatformOCommodity>
    {
        public PlatformGetsOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
