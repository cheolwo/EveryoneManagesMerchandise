using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofPlatMarket;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket
{
    public class PlatformPostPlatMarketViewModel : PlatMarketPostViewModel<PlatformPlatMarket>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostPlatMarketViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutPlatMarketViewModel : PlatMarketPutViewModel<PlatformPlatMarket>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutPlatMarketViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeletePlatMarketViewModel : PlatMarketDeleteViewModel<PlatformPlatMarket>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeletePlatMarketViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsPlatMarketViewModel : PlatMarketGetsViewModel<PlatformPlatMarket>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsPlatMarketViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
