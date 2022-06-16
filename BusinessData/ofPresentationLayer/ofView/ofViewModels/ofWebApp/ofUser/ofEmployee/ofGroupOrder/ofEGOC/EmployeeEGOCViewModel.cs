using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofEGOC;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class EmployeePostEGOCViewModel : EGOCPostViewModel<EmployeeEGOC>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostEGOCViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutEGOCViewModel : EGOCPutViewModel<EmployeeEGOC>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutEGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteEGOCViewModel : EGOCDeleteViewModel<EmployeeEGOC>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteEGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsEGOCViewModel : EGOCGetsViewModel<EmployeeEGOC>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsEGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
