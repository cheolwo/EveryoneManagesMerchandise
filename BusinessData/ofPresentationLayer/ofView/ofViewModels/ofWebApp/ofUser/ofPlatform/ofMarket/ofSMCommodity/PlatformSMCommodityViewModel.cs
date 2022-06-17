using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofSMCommodity;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket
{
    public class PlatformPostSMCommodityViewModel : SMCommodityPostViewModel<PlatformSMCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostSMCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutSMCommodityViewModel : SMCommodityPutViewModel<PlatformSMCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutSMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteSMCommodityViewModel : SMCommodityDeleteViewModel<PlatformSMCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteSMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsSMCommodityViewModel : SMCommodityGetsViewModel<PlatformSMCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsSMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}