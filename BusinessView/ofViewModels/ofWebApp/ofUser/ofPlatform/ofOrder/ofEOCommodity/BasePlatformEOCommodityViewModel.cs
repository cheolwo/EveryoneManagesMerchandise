using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofOrder.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder
{
    public class BasePlatformEOCommodityViewModel : BaseStatusViewModel<PlatformEOCommodity>
    {
        public BasePlatformEOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostEOCommodityViewModel : StatusPostViewModel<PlatformEOCommodity>
    {
        public PlatformPostEOCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutEOCommodityViewModel : StatusPutViewModel<PlatformEOCommodity>
    {
        public PlatformPutEOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteEOCommodityViewModel : StatusDeleteViewModel<PlatformEOCommodity>
    {
        public PlatformDeleteEOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsEOCommodityViewModel : StatusGetsViewModel<PlatformEOCommodity>
    {
        public PlatformGetsEOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
