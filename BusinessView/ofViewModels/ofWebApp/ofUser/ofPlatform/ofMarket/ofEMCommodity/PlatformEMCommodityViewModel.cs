using BusinessView.ofDTO.ofMarket.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofEMCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket
{
    public class PlatformPostEMCommodityViewModel : EMCommodityPostViewModel<PlatformEMCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostEMCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutEMCommodityViewModel : EMCommodityPutViewModel<PlatformEMCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutEMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteEMCommodityViewModel : EMCommodityDeleteViewModel<PlatformEMCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteEMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsEMCommodityViewModel : EMCommodityGetsViewModel<PlatformEMCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsEMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
