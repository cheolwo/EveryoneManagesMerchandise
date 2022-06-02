using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofHRRole;
using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR
{
    public class EmployeePostHRRoleViewModel : HRRolePostViewModel<EmployeeHRRole>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostHRRoleViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutHRRoleViewModel : HRRolePutViewModel<EmployeeHRRole>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutHRRoleViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteHRRoleViewModel : HRRoleDeleteViewModel<EmployeeHRRole>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteHRRoleViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsHRRoleViewModel : HRRoleGetsViewModel<EmployeeHRRole>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsHRRoleViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
