using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofProducter;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct
{
    public class PlatformPostProducterViewModel : ProducterPostViewModel<PlatformProducter>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostProducterViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutProducterViewModel : ProducterPutViewModel<PlatformProducter>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutProducterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteProducterViewModel : ProducterDeleteViewModel<PlatformProducter>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteProducterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsProducterViewModel : ProducterGetsViewModel<PlatformProducter>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsProducterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
