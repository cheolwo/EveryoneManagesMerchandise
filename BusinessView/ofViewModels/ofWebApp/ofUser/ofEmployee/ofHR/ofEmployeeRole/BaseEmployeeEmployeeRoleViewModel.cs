using BusinessView.ofDTO.ofHR.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR
{
    public class BaseEmployeeEmployeeRoleViewModel : BaseEntityViewModel<EmployeeEmployeeRole>
    {
        public BaseEmployeeEmployeeRoleViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostEmployeeRoleViewModel : EntityPostViewModel<EmployeeEmployeeRole>
    {
        public EmployeePostEmployeeRoleViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutEmployeeRoleViewModel : EntityPutViewModel<EmployeeEmployeeRole>
    {
        public EmployeePutEmployeeRoleViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteEmployeeRoleViewModel : EntityDeleteViewModel<EmployeeEmployeeRole>
    {
        public EmployeeDeleteEmployeeRoleViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsEmployeeRoleViewModel : EntityGetsViewModel<EmployeeEmployeeRole>
    {
        public EmployeeGetsEmployeeRoleViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
