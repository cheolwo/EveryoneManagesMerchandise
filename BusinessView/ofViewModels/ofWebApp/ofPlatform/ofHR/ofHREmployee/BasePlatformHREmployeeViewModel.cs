using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofHR.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR
{
    public class BasePlatformHREmployeeViewModel : BaseEntityViewModel<PlatformHREmployee>
    {
        public BasePlatformHREmployeeViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostHREmployeeViewModel : EntityPostViewModel<PlatformHREmployee>
    {
        public PlatformPostHREmployeeViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutHREmployeeViewModel : EntityPutViewModel<PlatformHREmployee>
    {
        public PlatformPutHREmployeeViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteHREmployeeViewModel : EntityDeleteViewModel<PlatformHREmployee>
    {
        public PlatformDeleteHREmployeeViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsHREmployeeViewModel : EntityGetsViewModel<PlatformHREmployee>
    {
        public PlatformGetsHREmployeeViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
