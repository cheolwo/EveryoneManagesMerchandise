using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofDividedTag;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class PlatformPostDividedTagViewModel : DividedTagPostViewModel<PlatformDividedTag>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostDividedTagViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutDividedTagViewModel : DividedTagPutViewModel<PlatformDividedTag>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutDividedTagViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteDividedTagViewModel : DividedTagDeleteViewModel<PlatformDividedTag>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteDividedTagViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsDividedTagViewModel : DividedTagGetsViewModel<PlatformDividedTag>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsDividedTagViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
