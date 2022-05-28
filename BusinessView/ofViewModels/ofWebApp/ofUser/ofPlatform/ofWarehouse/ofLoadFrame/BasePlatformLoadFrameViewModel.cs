using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class BasePlatformLoadFrameViewModel : BaseEntityViewModel<PlatformLoadFrame>
    {
        public BasePlatformLoadFrameViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostLoadFrameViewModel : EntityPostViewModel<PlatformLoadFrame>
    {
        public PlatformPostLoadFrameViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutLoadFrameViewModel : EntityPutViewModel<PlatformLoadFrame>
    {
        public PlatformPutLoadFrameViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteLoadFrameViewModel : EntityDeleteViewModel<PlatformLoadFrame>
    {
        public PlatformDeleteLoadFrameViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsLoadFrameViewModel : EntityGetsViewModel<PlatformLoadFrame>
    {
        public PlatformGetsLoadFrameViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
