using BusinessView.ofDTO.ofHR.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR
{
    public class BaseEmployeeHRBusinessPartViewModel : BaseEntityViewModel<EmployeeHRBusinessPart>
    {
        public BaseEmployeeHRBusinessPartViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostHRBusinessPartViewModel : EntityPostViewModel<EmployeeHRBusinessPart>
    {
        public EmployeePostHRBusinessPartViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutHRBusinessPartViewModel : EntityPutViewModel<EmployeeHRBusinessPart>
    {
        public EmployeePutHRBusinessPartViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteHRBusinessPartViewModel : EntityDeleteViewModel<EmployeeHRBusinessPart>
    {
        public EmployeeDeleteHRBusinessPartViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsHRBusinessPartViewModel : EntityGetsViewModel<EmployeeHRBusinessPart>
    {
        public EmployeeGetsHRBusinessPartViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
