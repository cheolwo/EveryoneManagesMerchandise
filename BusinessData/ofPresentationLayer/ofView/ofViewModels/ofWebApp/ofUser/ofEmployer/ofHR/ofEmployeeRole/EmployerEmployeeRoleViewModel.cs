using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofEmployeeRole;
using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR
{
    public class EmployerPostEmployeeRoleViewModel : EmployeeRolePostViewModel<EmployerEmployeeRole>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostEmployeeRoleViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutEmployeeRoleViewModel : EmployeeRolePutViewModel<EmployerEmployeeRole>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutEmployeeRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteEmployeeRoleViewModel : EmployeeRoleDeleteViewModel<EmployerEmployeeRole>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteEmployeeRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsEmployeeRoleViewModel : EmployeeRoleGetsViewModel<EmployerEmployeeRole>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsEmployeeRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
