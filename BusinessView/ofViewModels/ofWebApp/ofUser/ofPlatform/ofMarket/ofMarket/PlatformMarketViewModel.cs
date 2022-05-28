using BusinessView.ofDTO.ofMarket.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofMarket;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket
{
    public class PlatformPostMarketViewModel : MarketPostViewModel<PlatformMarket>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostMarketViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutMarketViewModel : MarketPutViewModel<PlatformMarket>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutMarketViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteMarketViewModel : MarketDeleteViewModel<PlatformMarket>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteMarketViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsMarketViewModel : MarketGetsViewModel<PlatformMarket>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsMarketViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
