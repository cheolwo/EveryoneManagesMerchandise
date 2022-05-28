using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofTrade.ofTCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade
{
    public class PlatformPostTCommodityViewModel : TCommodityPostViewModel<PlatformTCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostTCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutTCommodityViewModel : TCommodityPutViewModel<PlatformTCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteTCommodityViewModel : TCommodityDeleteViewModel<PlatformTCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsTCommodityViewModel : TCommodityGetsViewModel<PlatformTCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
