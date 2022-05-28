using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofGroupOrder.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformSGOCViewModel : BaseStatusViewModel<PlatformSGOC>
    {
        public BasePlatformSGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostSGOCViewModel : StatusPostViewModel<PlatformSGOC>
    {
        public PlatformPostSGOCViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutSGOCViewModel : StatusPutViewModel<PlatformSGOC>
    {
        public PlatformPutSGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteSGOCViewModel : StatusDeleteViewModel<PlatformSGOC>
    {
        public PlatformDeleteSGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsSGOCViewModel : StatusGetsViewModel<PlatformSGOC>
    {
        public PlatformGetsSGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
