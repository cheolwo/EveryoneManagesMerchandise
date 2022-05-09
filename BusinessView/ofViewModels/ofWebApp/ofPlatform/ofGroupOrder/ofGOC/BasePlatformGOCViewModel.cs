using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofGroupOrder.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformGOCViewModel : BaseCenterViewModel<PlatformGOC>
    {
        public BasePlatformGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostGOCViewModel : CenterPostViewModel<PlatformGOC>
    {
        public PlatformPostGOCViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutGOCViewModel : CenterPutViewModel<PlatformGOC>
    {
        public PlatformPutGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteGOCViewModel : CenterDeleteViewModel<PlatformGOC>
    {
        public PlatformDeleteGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsGOCViewModel : CenterGetsViewModel<PlatformGOC>
    {
        public PlatformGetsGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
