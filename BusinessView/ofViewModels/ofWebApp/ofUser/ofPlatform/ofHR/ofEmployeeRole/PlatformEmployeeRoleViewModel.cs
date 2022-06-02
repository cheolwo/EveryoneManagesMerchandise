using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofEmployeeRole;
using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR
{
    public class PlatformPostEmployeeRoleViewModel : EmployeeRolePostViewModel<PlatformEmployeeRole>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostEmployeeRoleViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutEmployeeRoleViewModel : EmployeeRolePutViewModel<PlatformEmployeeRole>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutEmployeeRoleViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteEmployeeRoleViewModel : EmployeeRoleDeleteViewModel<PlatformEmployeeRole>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteEmployeeRoleViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsEmployeeRoleViewModel : EmployeeRoleGetsViewModel<PlatformEmployeeRole>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsEmployeeRoleViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
