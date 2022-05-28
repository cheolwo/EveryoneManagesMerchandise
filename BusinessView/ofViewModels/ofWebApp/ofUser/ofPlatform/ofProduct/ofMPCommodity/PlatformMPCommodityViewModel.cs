using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofMPCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct
{
    public class PlatformPostMPCommodityViewModel : MPCommodityPostViewModel<PlatformMPCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostMPCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutMPCommodityViewModel : MPCommodityPutViewModel<PlatformMPCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutMPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteMPCommodityViewModel : MPCommodityDeleteViewModel<PlatformMPCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteMPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsMPCommodityViewModel : MPCommodityGetsViewModel<PlatformMPCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsMPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
