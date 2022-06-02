using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofHRBusinessPart;
using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR
{
    public class EmployeePostHRBusinessPartViewModel : HRBusinessPartPostViewModel<EmployeeHRBusinessPart>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostHRBusinessPartViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutHRBusinessPartViewModel : HRBusinessPartPutViewModel<EmployeeHRBusinessPart>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutHRBusinessPartViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteHRBusinessPartViewModel : HRBusinessPartDeleteViewModel<EmployeeHRBusinessPart>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteHRBusinessPartViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsHRBusinessPartViewModel : HRBusinessPartGetsViewModel<EmployeeHRBusinessPart>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsHRBusinessPartViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
