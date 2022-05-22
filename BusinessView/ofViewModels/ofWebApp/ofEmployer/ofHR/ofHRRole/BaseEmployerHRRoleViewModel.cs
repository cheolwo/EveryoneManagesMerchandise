using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR
{

    public class EmployerPostHRRoleViewModel : EmployerPostViewModel<EmployerHRRole>
    {
        public EmployerPostHRRoleViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutHRRoleViewModel : EmployerPutViewModel<EmployerHRRole>
    {
        public EmployerPutHRRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteHRRoleViewModel : EmployerDeleteViewModel<EmployerHRRole>
    {
        public EmployerDeleteHRRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsHRRoleViewModel : EmployerGetsViewModel<EmployerHRRole>
    {
        public EmployerGetsHRRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
