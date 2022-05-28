using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofTrade.ofMTCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade
{
    public class PlatformPostMTCommodityViewModel : MTCommodityPostViewModel<PlatformMTCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostMTCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutMTCommodityViewModel : MTCommodityPutViewModel<PlatformMTCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutMTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteMTCommodityViewModel : MTCommodityDeleteViewModel<PlatformMTCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteMTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsMTCommodityViewModel : MTCommodityGetsViewModel<PlatformMTCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsMTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
