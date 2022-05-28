using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class BasePlatformWorkingDeskViewModel : BaseEntityViewModel<PlatformWorkingDesk>
    {
        public BasePlatformWorkingDeskViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostWorkingDeskViewModel : EntityPostViewModel<PlatformWorkingDesk>
    {
        public PlatformPostWorkingDeskViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutWorkingDeskViewModel : EntityPutViewModel<PlatformWorkingDesk>
    {
        public PlatformPutWorkingDeskViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteWorkingDeskViewModel : EntityDeleteViewModel<PlatformWorkingDesk>
    {
        public PlatformDeleteWorkingDeskViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsWorkingDeskViewModel : EntityGetsViewModel<PlatformWorkingDesk>
    {
        public PlatformGetsWorkingDeskViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
