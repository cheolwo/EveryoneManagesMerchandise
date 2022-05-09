using BusinessView.ofDTO.ofHR.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR
{
    public class BaseEmployeeHREmployeeViewModel : BaseEntityViewModel<EmployeeHREmployee>
    {
        public BaseEmployeeHREmployeeViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostHREmployeeViewModel : EntityPostViewModel<EmployeeHREmployee>
    {
        public EmployeePostHREmployeeViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutHREmployeeViewModel : EntityPutViewModel<EmployeeHREmployee>
    {
        public EmployeePutHREmployeeViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteHREmployeeViewModel : EntityDeleteViewModel<EmployeeHREmployee>
    {
        public EmployeeDeleteHREmployeeViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsHREmployeeViewModel : EntityGetsViewModel<EmployeeHREmployee>
    {
        public EmployeeGetsHREmployeeViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
