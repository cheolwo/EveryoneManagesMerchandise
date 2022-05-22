using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR
{
    public class EmployerPostHREmployeeViewModel : EmployerPostViewModel<EmployerHREmployee>
    {
        public EmployerPostHREmployeeViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutHREmployeeViewModel : EmployerPutViewModel<EmployerHREmployee>
    {
        public EmployerPutHREmployeeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteHREmployeeViewModel : EmployerDeleteViewModel<EmployerHREmployee>
    {
        public EmployerDeleteHREmployeeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsHREmployeeViewModel : EmployerGetsViewModel<EmployerHREmployee>
    {
        public EmployerGetsHREmployeeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
