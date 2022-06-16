using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofTrade.ofTradeCenter;
using BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade
{
    public class PlatformPostTradeCenterViewModel : TradeCenterPostViewModel<PlatformTradeCenter>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostTradeCenterViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutTradeCenterViewModel : TradeCenterPutViewModel<PlatformTradeCenter>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutTradeCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteTradeCenterViewModel : TradeCenterDeleteViewModel<PlatformTradeCenter>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteTradeCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsTradeCenterViewModel : TradeCenterGetsViewModel<PlatformTradeCenter>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsTradeCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
