using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofHR.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR
{
    public class BasePlatformEmployeeRoleViewModel : BaseEntityViewModel<PlatformEmployeeRole>
    {
        public BasePlatformEmployeeRoleViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostEmployeeRoleViewModel : EntityPostViewModel<PlatformEmployeeRole>
    {
        public PlatformPostEmployeeRoleViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutEmployeeRoleViewModel : EntityPutViewModel<PlatformEmployeeRole>
    {
        public PlatformPutEmployeeRoleViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteEmployeeRoleViewModel : EntityDeleteViewModel<PlatformEmployeeRole>
    {
        public PlatformDeleteEmployeeRoleViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsEmployeeRoleViewModel : EntityGetsViewModel<PlatformEmployeeRole>
    {
        public PlatformGetsEmployeeRoleViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
