using BusinessView.ofDTO.ofOrder.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofOCommodity;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofEOCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder
{
    public class PlatformPostEOCommodityViewModel : EOCommodityPostViewModel<PlatformEOCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostEOCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutEOCommodityViewModel : EOCommodityPutViewModel<PlatformEOCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutEOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteEOCommodityViewModel : EOCommodityDeleteViewModel<PlatformEOCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteEOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsEOCommodityViewModel : EOCommodityGetsViewModel<PlatformEOCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsEOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
