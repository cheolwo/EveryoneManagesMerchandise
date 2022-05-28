using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofTrade.ofTradeCenter;
using BusinessView.ofUser.ofCommon;

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
