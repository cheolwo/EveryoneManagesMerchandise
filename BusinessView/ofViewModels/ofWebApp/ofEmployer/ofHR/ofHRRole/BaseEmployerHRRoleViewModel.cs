using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofHR.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR
{
    public class BaseEmployerHRRoleViewModel : BaseEntityViewModel<EmployerHRRole>
    {
        public BaseEmployerHRRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostHRRoleViewModel : EntityPostViewModel<EmployerHRRole>
    {
        public EmployerPostHRRoleViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutHRRoleViewModel : EntityPutViewModel<EmployerHRRole>
    {
        public EmployerPutHRRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteHRRoleViewModel : EntityDeleteViewModel<EmployerHRRole>
    {
        public EmployerDeleteHRRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsHRRoleViewModel : EntityGetsViewModel<EmployerHRRole>
    {
        public EmployerGetsHRRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
