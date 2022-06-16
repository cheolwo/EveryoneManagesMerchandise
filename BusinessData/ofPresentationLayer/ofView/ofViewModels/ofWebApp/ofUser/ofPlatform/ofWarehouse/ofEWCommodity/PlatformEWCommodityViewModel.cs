using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofEWCommodity;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class PlatformPostEWCommodityViewModel : EWCommodityPostViewModel<PlatformEWCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostEWCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutEWCommodityViewModel : EWCommodityPutViewModel<PlatformEWCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutEWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteEWCommodityViewModel : EWCommodityDeleteViewModel<PlatformEWCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteEWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsEWCommodityViewModel : EWCommodityGetsViewModel<PlatformEWCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsEWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
