using BusinessView.ofDTO.ofOrder.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofOCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder
{
    public class PlatformPostOCommodityViewModel : OCommodityPostViewModel<PlatformOCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostOCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutOCommodityViewModel : OCommodityPutViewModel<PlatformOCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteOCommodityViewModel : OCommodityDeleteViewModel<PlatformOCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsOCommodityViewModel : OCommodityGetsViewModel<PlatformOCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
