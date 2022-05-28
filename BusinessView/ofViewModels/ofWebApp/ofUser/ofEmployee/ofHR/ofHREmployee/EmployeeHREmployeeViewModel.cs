using BusinessView.ofDTO.ofHR.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofHREmployee;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR
{
    public class EmployeePostHREmployeeViewModel : HREmployeePostViewModel<EmployeeHREmployee>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostHREmployeeViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutHREmployeeViewModel : HREmployeePutViewModel<EmployeeHREmployee>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutHREmployeeViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteHREmployeeViewModel : HREmployeeDeleteViewModel<EmployeeHREmployee>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteHREmployeeViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsHREmployeeViewModel : HREmployeeGetsViewModel<EmployeeHREmployee>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsHREmployeeViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
