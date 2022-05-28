using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofHRRole;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR
{
    public class EmployerPostHRRoleViewModel : HRRolePostViewModel<EmployerHRRole>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostHRRoleViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutHRRoleViewModel : HRRolePutViewModel<EmployerHRRole>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutHRRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteHRRoleViewModel : HRRoleDeleteViewModel<EmployerHRRole>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteHRRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsHRRoleViewModel : HRRoleGetsViewModel<EmployerHRRole>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsHRRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
