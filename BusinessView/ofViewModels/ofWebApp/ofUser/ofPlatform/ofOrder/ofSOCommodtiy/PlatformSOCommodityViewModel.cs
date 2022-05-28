using BusinessView.ofDTO.ofOrder.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofSOCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder
{
    public class PlatformPostSOCommodityViewModel : SOCommodityPostViewModel<PlatformSOCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostSOCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutSOCommodityViewModel : SOCommodityPutViewModel<PlatformSOCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutSOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteSOCommodityViewModel : SOCommodityDeleteViewModel<PlatformSOCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteSOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsSOCommodityViewModel : SOCommodityGetsViewModel<PlatformSOCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsSOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
