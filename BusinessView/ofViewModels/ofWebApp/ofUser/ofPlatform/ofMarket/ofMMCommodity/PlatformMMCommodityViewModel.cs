using BusinessView.ofDTO.ofMarket.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofMMCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket
{
    public class PlatformPostMMCommodityViewModel : MMCommodityPostViewModel<PlatformMMCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostMMCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutMMCommodityViewModel : MMCommodityPutViewModel<PlatformMMCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutMMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteMMCommodityViewModel : MMCommodityDeleteViewModel<PlatformMMCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteMMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsMMCommodityViewModel : MMCommodityGetsViewModel<PlatformMMCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsMMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
