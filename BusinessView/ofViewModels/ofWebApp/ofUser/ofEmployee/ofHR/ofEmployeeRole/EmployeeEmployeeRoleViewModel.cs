using BusinessView.ofDTO.ofHR.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofEmployeeRole;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR
{
    public class EmployeePostEmployeeRoleViewModel : EmployeeRolePostViewModel<EmployeeEmployeeRole>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostEmployeeRoleViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutEmployeeRoleViewModel : EmployeeRolePutViewModel<EmployeeEmployeeRole>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutEmployeeRoleViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteEmployeeRoleViewModel : EmployeeRoleDeleteViewModel<EmployeeEmployeeRole>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteEmployeeRoleViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsEmployeeRoleViewModel : EmployeeRoleGetsViewModel<EmployeeEmployeeRole>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsEmployeeRoleViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
