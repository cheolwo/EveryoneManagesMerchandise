using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofOrder.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder
{
    public class BasePlatformMOCommodityViewModel : BaseStatusViewModel<PlatformMOCommodity>
    {
        public BasePlatformMOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostMOCommodityViewModel : StatusPostViewModel<PlatformMOCommodity>
    {
        public PlatformPostMOCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutMOCommodityViewModel : StatusPutViewModel<PlatformMOCommodity>
    {
        public PlatformPutMOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteMOCommodityViewModel : StatusDeleteViewModel<PlatformMOCommodity>
    {
        public PlatformDeleteMOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsMOCommodityViewModel : StatusGetsViewModel<PlatformMOCommodity>
    {
        public PlatformGetsMOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
