using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofGOC;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class EmployeePostGOCViewModel : GOCPostViewModel<EmployeeGOC>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostGOCViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutGOCViewModel : GOCPutViewModel<EmployeeGOC>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteGOCViewModel : GOCDeleteViewModel<EmployeeGOC>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsGOCViewModel : GOCGetsViewModel<EmployeeGOC>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
