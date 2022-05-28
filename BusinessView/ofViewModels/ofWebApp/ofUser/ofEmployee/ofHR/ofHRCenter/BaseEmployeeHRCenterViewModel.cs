using BusinessView.ofDTO.ofHR.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR
{
    public class BaseEmployeeHRCenterViewModel : BaseCenterViewModel<EmployeeHRCenter>
    {
        public BaseEmployeeHRCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostHRCenterViewModel : CenterPostViewModel<EmployeeHRCenter>
    {
        public EmployeePostHRCenterViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutHRCenterViewModel : CenterPutViewModel<EmployeeHRCenter>
    {
        public EmployeePutHRCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteHRCenterViewModel : CenterDeleteViewModel<EmployeeHRCenter>
    {
        public EmployeeDeleteHRCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsHRCenterViewModel : CenterGetsViewModel<EmployeeHRCenter>
    {
        public EmployeeGetsHRCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
