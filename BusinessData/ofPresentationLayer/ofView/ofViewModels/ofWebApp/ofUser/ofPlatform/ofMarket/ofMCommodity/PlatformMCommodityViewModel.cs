using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofMCommodity;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket
{
    public class PlatformPostMCommodityViewModel : MCommodityPostViewModel<PlatformMCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostMCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutMCommodityViewModel : MCommodityPutViewModel<PlatformMCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteMCommodityViewModel : MCommodityDeleteViewModel<PlatformMCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsMCommodityViewModel : MCommodityGetsViewModel<PlatformMCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
