using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofHR.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR
{
    public class BaseEmployerEmployeeRoleViewModel : BaseEntityViewModel<EmployerEmployeeRole>
    {
        public BaseEmployerEmployeeRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostEmployeeRoleViewModel : EntityPostViewModel<EmployerEmployeeRole>
    {
        public EmployerPostEmployeeRoleViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutEmployeeRoleViewModel : EntityPutViewModel<EmployerEmployeeRole>
    {
        public EmployerPutEmployeeRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteEmployeeRoleViewModel : EntityDeleteViewModel<EmployerEmployeeRole>
    {
        public EmployerDeleteEmployeeRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsEmployeeRoleViewModel : EntityGetsViewModel<EmployerEmployeeRole>
    {
        public EmployerGetsEmployeeRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
