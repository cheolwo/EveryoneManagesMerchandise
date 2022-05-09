using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofGroupOrder.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformEGOCViewModel : BaseStatusViewModel<PlatformEGOC>
    {
        public BasePlatformEGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostEGOCViewModel : StatusPostViewModel<PlatformEGOC>
    {
        public PlatformPostEGOCViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutEGOCViewModel : StatusPutViewModel<PlatformEGOC>
    {
        public PlatformPutEGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteEGOCViewModel : StatusDeleteViewModel<PlatformEGOC>
    {
        public PlatformDeleteEGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsEGOCViewModel : StatusGetsViewModel<PlatformEGOC>
    {
        public PlatformGetsEGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
