using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofGOCC;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class EmployeePostGOCCViewModel : GOCCPostViewModel<EmployeeGOCC>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostGOCCViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutGOCCViewModel : GOCCPutViewModel<EmployeeGOCC>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutGOCCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteGOCCViewModel : GOCCDeleteViewModel<EmployeeGOCC>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteGOCCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsGOCCViewModel : GOCCGetsViewModel<EmployeeGOCC>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsGOCCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
