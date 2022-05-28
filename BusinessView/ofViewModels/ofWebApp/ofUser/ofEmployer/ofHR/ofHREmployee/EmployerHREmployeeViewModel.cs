using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofHREmployee;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR
{
    public class EmployerPostHREmployeeViewModel : HREmployeePostViewModel<EmployerHREmployee>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostHREmployeeViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutHREmployeeViewModel : HREmployeePutViewModel<EmployerHREmployee>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutHREmployeeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteHREmployeeViewModel : HREmployeeDeleteViewModel<EmployerHREmployee>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteHREmployeeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsHREmployeeViewModel : HREmployeeGetsViewModel<EmployerHREmployee>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsHREmployeeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
