using BusinessView.ofDTO.ofHR.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofHRCenter;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR
{
    public class EmployeePostHRCenterViewModel : HRCenterPostViewModel<EmployeeHRCenter>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostHRCenterViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutHRCenterViewModel : HRCenterPutViewModel<EmployeeHRCenter>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutHRCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteHRCenterViewModel : HRCenterDeleteViewModel<EmployeeHRCenter>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteHRCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsHRCenterViewModel : HRCenterGetsViewModel<EmployeeHRCenter>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsHRCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
