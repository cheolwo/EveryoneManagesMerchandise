using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR
{
    public class EmployerPostEmployeeRoleViewModel : EmployerPostViewModel<EmployerEmployeeRole>
    {
        public EmployerPostEmployeeRoleViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutEmployeeRoleViewModel : EmployerPutViewModel<EmployerEmployeeRole>
    {
        public EmployerPutEmployeeRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteEmployeeRoleViewModel : EmployerDeleteViewModel<EmployerEmployeeRole>
    {
        public EmployerDeleteEmployeeRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsEmployeeRoleViewModel : EmployerGetsViewModel<EmployerEmployeeRole>
    {
        public EmployerGetsEmployeeRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
