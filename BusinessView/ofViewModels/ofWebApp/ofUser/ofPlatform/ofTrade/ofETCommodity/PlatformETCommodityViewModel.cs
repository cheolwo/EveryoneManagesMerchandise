using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofTrade.ofETCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade
{
    public class PlatformPostETCommodityViewModel : ETCommodityPostViewModel<PlatformETCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostETCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutETCommodityViewModel : ETCommodityPutViewModel<PlatformETCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutETCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteETCommodityViewModel : ETCommodityDeleteViewModel<PlatformETCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteETCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsETCommodityViewModel : ETCommodityGetsViewModel<PlatformETCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsETCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}