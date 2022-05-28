using BusinessView.ofDTO.ofJournal.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofJournal.ofJCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofJournal
{
    public class PlatformPostJCommodityViewModel : JCommodityPostViewModel<PlatformJCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostJCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutJCommodityViewModel : JCommodityPutViewModel<PlatformJCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutJCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteJCommodityViewModel : JCommodityDeleteViewModel<PlatformJCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteJCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsJCommodityViewModel : JCommodityGetsViewModel<PlatformJCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsJCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
