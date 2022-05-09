using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofTrade.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade
{
    public class BasePlatformTradeCenterViewModel : BaseCenterViewModel<PlatformTradeCenter>
    {
        public BasePlatformTradeCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostTradeCenterViewModel : CenterPostViewModel<PlatformTradeCenter>
    {
        public PlatformPostTradeCenterViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutTradeCenterViewModel : CenterPutViewModel<PlatformTradeCenter>
    {
        public PlatformPutTradeCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteTradeCenterViewModel : CenterDeleteViewModel<PlatformTradeCenter>
    {
        public PlatformDeleteTradeCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsTradeCenterViewModel : CenterGetsViewModel<PlatformTradeCenter>
    {
        public PlatformGetsTradeCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
