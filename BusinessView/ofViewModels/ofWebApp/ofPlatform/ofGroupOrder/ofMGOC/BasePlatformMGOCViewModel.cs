using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofGroupOrder.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformMGOCViewModel : BaseStatusViewModel<PlatformMGOC>
    {
        public BasePlatformMGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostMGOCViewModel : StatusPostViewModel<PlatformMGOC>
    {
        public PlatformPostMGOCViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutMGOCViewModel : StatusPutViewModel<PlatformMGOC>
    {
        public PlatformPutMGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteMGOCViewModel : StatusDeleteViewModel<PlatformMGOC>
    {
        public PlatformDeleteMGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsMGOCViewModel : StatusGetsViewModel<PlatformMGOC>
    {
        public PlatformGetsMGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
