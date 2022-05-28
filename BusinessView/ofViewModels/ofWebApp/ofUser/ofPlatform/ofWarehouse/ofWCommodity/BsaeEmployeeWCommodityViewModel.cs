using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class BasePlatformWCommodityViewModel : BaseCommodityViewModel<PlatformWCommodity>
    {
        public BasePlatformWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostWCommodityViewModel : CommodityPostViewModel<PlatformWCommodity>
    {
        public PlatformPostWCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutWCommodityViewModel : CommodityPutViewModel<PlatformWCommodity>
    {
        public PlatformPutWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteWCommodityViewModel : CommodityDeleteViewModel<PlatformWCommodity>
    {
        public PlatformDeleteWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsWCommodityViewModel : CommodityGetsViewModel<PlatformWCommodity>
    {
        public PlatformGetsWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
