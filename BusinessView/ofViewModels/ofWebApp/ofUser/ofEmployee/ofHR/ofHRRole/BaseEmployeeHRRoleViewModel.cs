using BusinessView.ofDTO.ofHR.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR
{
    public class BaseEmployeeHRRoleViewModel : BaseEntityViewModel<EmployeeHRRole>
    {
        public BaseEmployeeHRRoleViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostHRRoleViewModel : EntityPostViewModel<EmployeeHRRole>
    {
        public EmployeePostHRRoleViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutHRRoleViewModel : EntityPutViewModel<EmployeeHRRole>
    {
        public EmployeePutHRRoleViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteHRRoleViewModel : EntityDeleteViewModel<EmployeeHRRole>
    {
        public EmployeeDeleteHRRoleViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsHRRoleViewModel : EntityGetsViewModel<EmployeeHRRole>
    {
        public EmployeeGetsHRRoleViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
