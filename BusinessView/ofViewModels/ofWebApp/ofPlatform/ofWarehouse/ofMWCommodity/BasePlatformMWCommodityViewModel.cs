using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class BasePlatformMWCommodityViewModel : BaseStatusViewModel<PlatformMWCommodity>
    {
        public BasePlatformMWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostMWCommodityViewModel : StatusPostViewModel<PlatformMWCommodity>
    {
        public PlatformPostMWCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutMWCommodityViewModel : StatusPutViewModel<PlatformMWCommodity>
    {
        public PlatformPutMWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteMWCommodityViewModel : StatusDeleteViewModel<PlatformMWCommodity>
    {
        public PlatformDeleteMWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsMWCommodityViewModel : StatusGetsViewModel<PlatformMWCommodity>
    {
        public PlatformGetsMWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
