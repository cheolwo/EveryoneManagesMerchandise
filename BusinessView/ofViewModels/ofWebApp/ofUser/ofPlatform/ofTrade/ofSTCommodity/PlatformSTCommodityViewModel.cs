using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofTrade.ofSTCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade
{
    public class PlatformPostSTCommodityViewModel : STCommodityPostViewModel<PlatformSTCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostSTCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutSTCommodityViewModel : STCommodityPutViewModel<PlatformSTCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutSTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteSTCommodityViewModel : STCommodityDeleteViewModel<PlatformSTCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteSTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsSTCommodityViewModel : STCommodityGetsViewModel<PlatformSTCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsSTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}