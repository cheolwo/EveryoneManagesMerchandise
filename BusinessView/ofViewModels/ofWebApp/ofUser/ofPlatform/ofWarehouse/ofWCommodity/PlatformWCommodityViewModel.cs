using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofWCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class PlatformPostWCommodityViewModel : WCommodityPostViewModel<PlatformWCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostWCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutWCommodityViewModel : WCommodityPutViewModel<PlatformWCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteWCommodityViewModel : WCommodityDeleteViewModel<PlatformWCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsWCommodityViewModel : WCommodityGetsViewModel<PlatformWCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
