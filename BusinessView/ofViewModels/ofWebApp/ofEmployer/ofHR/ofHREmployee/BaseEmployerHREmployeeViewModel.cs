using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofHR.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR
{
    public class BaseEmployerHREmployeeViewModel : BaseEntityViewModel<EmployerHREmployee>
    {
        public BaseEmployerHREmployeeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostHREmployeeViewModel : EntityPostViewModel<EmployerHREmployee>
    {
        public EmployerPostHREmployeeViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutHREmployeeViewModel : EntityPutViewModel<EmployerHREmployee>
    {
        public EmployerPutHREmployeeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteHREmployeeViewModel : EntityDeleteViewModel<EmployerHREmployee>
    {
        public EmployerDeleteHREmployeeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsHREmployeeViewModel : EntityGetsViewModel<EmployerHREmployee>
    {
        public EmployerGetsHREmployeeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
