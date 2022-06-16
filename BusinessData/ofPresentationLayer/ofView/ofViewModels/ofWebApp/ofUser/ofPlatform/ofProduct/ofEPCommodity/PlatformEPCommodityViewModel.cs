using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofEPCommodity;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct
{
    public class PlatformPostEPCommodityViewModel : EPCommodityPostViewModel<PlatformEPCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostEPCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutEPCommodityViewModel : EPCommodityPutViewModel<PlatformEPCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutEPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteEPCommodityViewModel : EPCommodityDeleteViewModel<PlatformEPCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteEPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsEPCommodityViewModel : EPCommodityGetsViewModel<PlatformEPCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsEPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
